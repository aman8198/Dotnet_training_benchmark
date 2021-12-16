using BroadbandCrmRestApi2.DAL;
using BroadbandCrmRestApi2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BroadbandCrmRestApi2.BAL
{
    public class LeadBAL
    {
        LeadDal d = new LeadDal();

        public List<Lead> GetLeads() 
        {
            SqlDataReader reader = d.getLeadData();
            List<Lead> slist = new List<Lead>();
            while (reader.Read())
            {
                Lead ld = new Lead();
                ld.Lead_Id = Convert.ToInt32(reader["LeadId"]);
                ld.Name = reader["Name"].ToString();
                ld.City = reader["City"].ToString();
                ld.State = reader["State"].ToString();
                ld.Gender = reader["Gender"].ToString();
                ld.Phoneno = reader["PhoneNo"].ToString();
                ld.Remark = reader["Remark"].ToString();
                ld.CreatedBy = reader["CreatedBy"].ToString();
                ld.Status = reader["Status"].ToString();
                slist.Add(ld);

            }
            return slist;
        
        }

        public int InsertLead(int LeadId, string name, string city, string state, string gender, string phoneno, string remark, string createdBy, string status)
        {
            try {
                Lead ld = new Lead() { Lead_Id = LeadId, Name = name, City = city, State = state, Gender = gender, Phoneno = phoneno, Remark = remark, CreatedBy = createdBy, Status = status };
                d.InsertData(ld);
                return 1;
            
            
            }catch(Exception ex) { return 0; }
            
        
        }

        public int UpdateLead(int LeadId, string name, string city, string state, string gender, string phoneno, string remark, string createdBy, string status) 
        {
            try
            {
                Lead ld = new Lead() { Lead_Id = LeadId, Name = name, City = city, State = state, Gender = gender, Phoneno = phoneno, Remark = remark, CreatedBy = createdBy, Status = status };
                d.UpdateData(ld);
                return 1;


            }
            catch (Exception ex) { return 0; }


        }

        public int DeleteLead(int id)
        {
            try
            {
                d.DeleteData(id);
                return 1;
            }catch(Exception ex) 
            {
                return 0;
            
            }
        } 
    }
}