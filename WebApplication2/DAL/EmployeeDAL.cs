using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace WebApplication2.DAL
{
    public class EmployeeDAL
    {
        public SqlDataReader GetEmpData()
        {
            SqlConnection con = new SqlConnection("Server=.;Database=Emp_db;trusted_connection=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select*from Emp", con);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;

        }
    }
}