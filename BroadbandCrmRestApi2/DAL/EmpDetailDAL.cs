using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using BroadbandCrmRestApi2.Models;

namespace BroadbandCrmRestApi2.DAL
{
    public class EmpDetailDAL
    {
        public SqlDataReader getEmpDetails()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("EmpdetailsGetAllEmp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

         public void InsertEmpDetails(EmpDetails ed) 
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("InsertEmpDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Emp_Id", ed.Emp_Id);
            cmd.Parameters.AddWithValue("EmpName", ed.EmpName);
            cmd.Parameters.AddWithValue("EmpAddress", ed.EmpAddress);
            cmd.Parameters.AddWithValue("Email", ed.Email);
            cmd.Parameters.AddWithValue("Phoneno", ed.phoneno);

            cmd.ExecuteNonQuery();


        }

        public void UpdateEmpDetails(EmpDetails ed) 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("UpdateEmpDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Emp_Id", ed.Emp_Id);
            cmd.Parameters.AddWithValue("EmpName", ed.EmpName);
            cmd.Parameters.AddWithValue("EmpAddress", ed.EmpAddress);
            cmd.Parameters.AddWithValue("Email", ed.Email);
            cmd.Parameters.AddWithValue("Phoneno", ed.phoneno);

            cmd.ExecuteNonQuery();

        }

        public void DeleteEmpDetails(int id) 
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("DeleteEmpDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Emp_Id", id);
            cmd.ExecuteNonQuery();


        }

        public SqlDataReader getEmpDetailsusingId(int id) 
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("EmpdetailsGetAllEmpById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Emp_Id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;

        }



    }
}