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
    public class AccountDAL
    {
        public SqlDataReader GetAccountData() 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("GetAccount", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;

        }
        public void InsertAccount(Account ac) 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("InsertAccount", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("CustId", ac.CustId);
            cmd.Parameters.AddWithValue("OppId", ac.OppId);
            cmd.Parameters.AddWithValue("Name", ac.Name);
            cmd.Parameters.AddWithValue("PlanName", ac.PlanName);
            cmd.Parameters.AddWithValue("Speed", ac.Speed);
            cmd.Parameters.AddWithValue("Price", ac.Price);
            cmd.Parameters.AddWithValue("Validity", ac.Validity);
            cmd.Parameters.AddWithValue("StartDate", ac.Startdate);
            cmd.Parameters.AddWithValue("EndDate", ac.EndDate);
            cmd.Parameters.AddWithValue("BillingAdddress", ac.BillingAddress);
            cmd.Parameters.AddWithValue("ShippingAddress", ac.ShippingAddress);
            cmd.Parameters.AddWithValue("ConvertedBy", ac.ConvertedBy);
            cmd.Parameters.AddWithValue("Status", ac.Status);

            cmd.ExecuteNonQuery();


        
        }

        public void UpdateAccount(Account ac) 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateAccount", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("CustId", ac.CustId);
            cmd.Parameters.AddWithValue("OppId", ac.OppId);
            cmd.Parameters.AddWithValue("Name", ac.Name);
            cmd.Parameters.AddWithValue("PlanName", ac.PlanName);
            cmd.Parameters.AddWithValue("Speed", ac.Speed);
            cmd.Parameters.AddWithValue("Price", ac.Price);
            cmd.Parameters.AddWithValue("Validity", ac.Validity);
            cmd.Parameters.AddWithValue("StartDate", ac.Startdate);
            cmd.Parameters.AddWithValue("EndDate", ac.EndDate);
            cmd.Parameters.AddWithValue("BillingAdddress", ac.BillingAddress);
            cmd.Parameters.AddWithValue("ShippingAddress", ac.ShippingAddress);
            cmd.Parameters.AddWithValue("ConvertedBy", ac.ConvertedBy);
            cmd.Parameters.AddWithValue("Status", ac.Status);

            cmd.ExecuteNonQuery();

        } 

        public void DeleteAccount(int id) 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteAccount", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("CustId", id);
            cmd.ExecuteNonQuery();
            
        
        
        }



         


    }
}