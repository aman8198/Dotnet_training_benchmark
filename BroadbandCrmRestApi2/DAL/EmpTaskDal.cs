using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using BroadbandCrmRestApi2.Models;
using System.Configuration;

namespace BroadbandCrmRestApi2.DAL
{
    public class EmpTaskDal
    {
        public SqlDataReader GetAllEmpTask() 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("GetAllEmpTask", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;


        }
        public SqlDataReader GetEmpTaskById(int id) 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("GetAllEmpTaskById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Task_Id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;

        
        
        
        
        }
        public void InsertEmptask(EmpTask et)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("InsertEmpTask", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Task_Id", et.Task_Id);
            cmd.Parameters.AddWithValue("TaskModule", et.TaskModule);
            cmd.Parameters.AddWithValue("TaskName", et.TaskName);
            cmd.Parameters.AddWithValue("TaskDescription", et.TaskDescription);
            cmd.Parameters.AddWithValue("TStatus", et.TStatus);
            cmd.Parameters.AddWithValue("StartDate", et.StartDate);
            cmd.Parameters.AddWithValue("EndDate", et.EndDate);
            cmd.Parameters.AddWithValue("Emp_Id", et.Emp_Id);
            cmd.ExecuteNonQuery();        
        
        }

        public void UpdateEmpTask(EmpTask et) 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateEmpTask", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Task_Id", et.Task_Id);
            cmd.Parameters.AddWithValue("TaskModule", et.TaskModule);
            cmd.Parameters.AddWithValue("TaskName", et.TaskName);
            cmd.Parameters.AddWithValue("TaskDescription", et.TaskDescription);
            cmd.Parameters.AddWithValue("TStatus", et.TStatus);
            cmd.Parameters.AddWithValue("StartDate", et.StartDate);
            cmd.Parameters.AddWithValue("EndDate", et.EndDate);
            cmd.Parameters.AddWithValue("Emp_Id", et.Emp_Id);
            cmd.ExecuteNonQuery();



        }

        public void DeleteEmpTask(int id) 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("DeleteEmpTask", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Task_Id", id);
            cmd.ExecuteNonQuery();
        
        
        }
    }
}