using StudentsITI.BusinessLayer;

namespace SudentsITI.PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FillStudentToGridView();

            FillStudentToComboBox();
        }

        private void FillStudentToGridView()
        {
            dataGridView1.DataSource = StudentsITI.BusinessLayer.StudentBL.GetAll();
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {
            var student = new Student
            {
                Id = txtId.Text,
                FName = txtFName.Text,
                LName = txtLName.Text,
                Address = txtAddress.Text,


            };
            var tmp = StudentsITI.BusinessLayer.StudentBL.Add(student);
            labelaffected.Text = $"{tmp} rows Affected ";
            FillStudentToGridView();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var student = StudentsITI.BusinessLayer.StudentBL.GetById2(comboBox1.SelectedValue.ToString());
            txtId.Text = student.Id;
            txtFName.Text = student.FName;
            txtLName.Text = student.LName;
            txtAddress.Text = student.Address;
        }
        private void FillStudentToComboBox()
        {
            comboBox1.DataSource = StudentsITI.BusinessLayer.StudentBL.GetAll();
            comboBox1.DisplayMember = "St_Fname";
            comboBox1.ValueMember = "St_Id";

        }


        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            var student = new Student
            {
                Id = txtId.Text,
                FName = txtFName.Text,
                LName = txtLName.Text,
                Address = txtAddress.Text,

            };

            var tmp = StudentsITI.BusinessLayer.StudentBL.Update(student);
            labelaffected.Text = $"{tmp} rows Affected ";
            FillStudentToGridView();
        }


        private void btnDel_Click_1(object sender, EventArgs e)
        {
            var student = new Student
            {
                Id = txtId.Text,
            };

            var tmp = StudentsITI.BusinessLayer.StudentBL.Delete(student);
            labelaffected.Text = $"{tmp} rows Affected ";
            FillStudentToGridView();
            FillStudentToComboBox();
        }


    }
}