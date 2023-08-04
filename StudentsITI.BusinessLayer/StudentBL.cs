using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsITI.BusinessLayer
{
    public class StudentBL
    {
        public static DataTable GetAll()
        {
            string query = "select * from student";
            return StudentsITI.DataAccessLayer.DBManager.ExexcuteQuery(query);
        }



        public static DataTable GetById()
        {
            string query = "select * from student where id=@id";
            return StudentsITI.DataAccessLayer.DBManager.ExexcuteQuery(query);

        }

        public static Student GetById2(string id)
        {
            string query = $"select * from student where St_Id={id}";
            var dt = StudentsITI.DataAccessLayer.DBManager.ExexcuteQuery(query);
            return new Student
            {
                Id = dt.Rows[0]["St_Id"].ToString(),
                FName = dt.Rows[0]["St_Fname"].ToString(),
                LName = dt.Rows[0]["St_Lname"].ToString(),
                Address = dt.Rows[0]["St_Address"].ToString(),
            };

        }

        public static int Add(Student student)
        {
            string query = "insert into student(St_Id, St_Fname, St_Lname, St_Address) values(@id, @fn, @ln, @address)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",student.Id),
                new SqlParameter("@fn",student.FName),
                new SqlParameter("@ln",student.LName),
                new SqlParameter("@address",student.Address),

            };
            return StudentsITI.DataAccessLayer.DBManager.ExexcuteNonQuery(query, parameters);

        }


        public static int Update(Student student)
        {
            string query = "update student set St_Fname=@fn,St_Lname=@ln,St_Address=@address where St_Id=@id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",student.Id),
                new SqlParameter("@fn",student.FName),
                new SqlParameter("@ln",student.LName),
                new SqlParameter("@address",student.Address),

            };
            return StudentsITI.DataAccessLayer.DBManager.ExexcuteNonQuery(query, parameters);

        }



        public static int Delete(Student student)
        {
            string query = "delete from student where St_Id=@id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",student.Id),


            };
            return StudentsITI.DataAccessLayer.DBManager.ExexcuteNonQuery(query, parameters);

        }


    }
}
