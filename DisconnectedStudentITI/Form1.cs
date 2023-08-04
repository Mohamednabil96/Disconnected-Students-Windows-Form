using Microsoft.Data.SqlClient;
using System.Data;

namespace DisconnectedStudentITI
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
            FillStudentsList();
        }

        private void FillStudentsList()
        {
            con = new SqlConnection("Server=localhost;Database=ITI;trusted_connection=true;trustServerCertificate=true");
            command = new SqlCommand();
            command.CommandText = "select St_Id, St_Fname, St_Lname, St_Address, St_Age from student";

            command.Connection = con;

            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            dt = new DataTable();

            adapter.Fill(dt);

            gridStudents.DataSource = dt;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["St_Id"] = txtID.Text;
            dr["St_Fname"] = txtFName.Text;
            dr["St_Lname"] = txtLName.Text;
            dr["St_Address"] = txtAddress.Text;
            dr["St_Age"] = txtAge.Text;

            dt.Rows.Add(dr);
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=localhost;Database=ITI;trusted_connection=true;trustServerCertificate=true");

            // INSERT START
            SqlCommand InsCommand = new SqlCommand();

            InsCommand.CommandText = "insert into student (St_Id,St_Fname,St_Lname,St_Address,St_Age) values (@id,@fname,@lname,@address,@age)";
            InsCommand.Parameters.Add("@id", SqlDbType.Int, 20, "St_Id");
            InsCommand.Parameters.Add("@fname", SqlDbType.VarChar, 20, "St_Fname");
            InsCommand.Parameters.Add("@lname", SqlDbType.VarChar, 20, "St_Lname");
            InsCommand.Parameters.Add("@address", SqlDbType.VarChar, 20, "St_Address");
            InsCommand.Parameters.Add("@age", SqlDbType.Int, 20, "St_Age");

            InsCommand.Connection = con;
            // INSERT END

            // UPDATE START 
            SqlCommand UpdCommand = new SqlCommand();
            UpdCommand.CommandText = "update student set St_Fname=@fname,St_Lname=@lname,St_Address=@address,St_Age=@age where St_Id=@id";

            UpdCommand.Parameters.Add("@id", SqlDbType.Int, 20, "St_Id");
            UpdCommand.Parameters.Add("@fname", SqlDbType.VarChar, 20, "St_Fname");
            UpdCommand.Parameters.Add("@lname", SqlDbType.VarChar, 20, "St_Lname");
            UpdCommand.Parameters.Add("@address", SqlDbType.VarChar, 20, "St_Address");
            UpdCommand.Parameters.Add("@age", SqlDbType.Int, 20, "St_Age");

            UpdCommand.Connection = con;
            //UPDATE END

            //DELETE START
            SqlCommand DelCommand = new SqlCommand();
            DelCommand.CommandText = "delete from STUDENT where St_Id=@id";
            DelCommand.Parameters.Add("@id", SqlDbType.Int, 20, "St_Id");

            DelCommand.Connection = con;
            //DELETE END


            //ADAPTER
            adapter = new SqlDataAdapter();
            adapter.InsertCommand = InsCommand;
            adapter.UpdateCommand = UpdCommand;
            adapter.DeleteCommand = DelCommand;

            var result = adapter.Update(dt);
            lblResult.Text = $"{result} Affected !!!!";
        }
    }
}