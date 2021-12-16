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
    public class OpportunityDal
    {
      

        public SqlDataReader getAllOpportunity()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("GetOpportunity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void InsertOpportunity(Opportunity op)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("InsertOpportunity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("OppId", op.OppId);
            cmd.Parameters.AddWithValue("PlanName", op.PlanName);
            cmd.Parameters.AddWithValue("Price", op.price);
            cmd.Parameters.AddWithValue("ConvertedBy", op.ConvertedBy);
            cmd.Parameters.AddWithValue("Remark", op.Remark);
            cmd.Parameters.AddWithValue("LeadId", op.LeadId);
            cmd.Parameters.AddWithValue("Name", op.Name);
            cmd.ExecuteNonQuery();

        }

        public void UpdateOpportunity(Opportunity op) 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateOpportunity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("OppId", op.OppId);
            cmd.Parameters.AddWithValue("PlanName", op.PlanName);
            cmd.Parameters.AddWithValue("Price", op.price);
            cmd.Parameters.AddWithValue("ConvertedBy", op.ConvertedBy);
            cmd.Parameters.AddWithValue("Remark", op.Remark);
            cmd.Parameters.AddWithValue("LeadId", op.LeadId);
            cmd.Parameters.AddWithValue("Name", op.Name);
            cmd.ExecuteNonQuery();
        }

        public void DeleteOpportunity(int id) 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteOpportunity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("OppId", id);
            cmd.ExecuteNonQuery();
        }
    }
}