using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsITI.DataAccessLayer
{
    public class DBManager
    {
        //Exexcute Query // Disconnected
        public static DataTable ExexcuteQuery(string query)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Database=ITI;trusted_connection=true;TrustServerCertificate=True");
            SqlCommand sqlcommand = new SqlCommand(query, con);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //Execute NonQuery // Connected

        public static int ExexcuteNonQuery(string query, SqlParameter[] parameters)
        {
            int affected = -1;

            SqlConnection con = new SqlConnection("Data Source=localhost;Database=ITI;trusted_connection=true;TrustServerCertificate=True");
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddRange(parameters);
            try
            {
                con.Open();
                affected = sqlCommand.ExecuteNonQuery();

            }
            catch
            { throw; }
            finally { con.Close(); }

            return affected;
        }
    }
}
