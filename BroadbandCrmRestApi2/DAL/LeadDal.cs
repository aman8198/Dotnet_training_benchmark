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
    public class LeadDal
    {
        public SqlDataReader getLeadData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("GetAllLead", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        
        
        }

        public void InsertData(Lead ld) 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("InsertLead", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("LeadId", ld.Lead_Id);
            cmd.Parameters.AddWithValue("Name", ld.Name);
            cmd.Parameters.AddWithValue("City", ld.City);
            cmd.Parameters.AddWithValue("State", ld.State);
            cmd.Parameters.AddWithValue("Gender", ld.Gender);
            cmd.Parameters.AddWithValue("PhoneNo", ld.Phoneno);
            cmd.Parameters.AddWithValue("Remark", ld.Remark);
            cmd.Parameters.AddWithValue("CreatedBy", ld.CreatedBy);
            cmd.Parameters.AddWithValue("Status", ld.Status);

            cmd.ExecuteNonQuery();
        
        }

        public void UpdateData(Lead ld)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateLead", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("LeadId", ld.Lead_Id);
            cmd.Parameters.AddWithValue("Name", ld.Name);
            cmd.Parameters.AddWithValue("City", ld.City);
            cmd.Parameters.AddWithValue("State", ld.State);
            cmd.Parameters.AddWithValue("Gender", ld.Gender);
            cmd.Parameters.AddWithValue("PhoneNo", ld.Phoneno);
            cmd.Parameters.AddWithValue("Remark", ld.Remark);
            cmd.Parameters.AddWithValue("CreatedBy", ld.CreatedBy);
            cmd.Parameters.AddWithValue("Status", ld.Status);

            cmd.ExecuteNonQuery();

        }

        public void DeleteData(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteLead", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("LeadId",id);
            cmd.ExecuteNonQuery();
        }
    }
}