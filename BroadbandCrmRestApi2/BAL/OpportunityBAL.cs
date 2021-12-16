using BroadbandCrmRestApi2.DAL;
using BroadbandCrmRestApi2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BroadbandCrmRestApi2.BAL
{
    public class OpportunityBAL
    {
        OpportunityDal d = new OpportunityDal();

        public List<Opportunity> getOpportunity() 
        {
            SqlDataReader reader = d.getAllOpportunity();
            List<Opportunity> slist = new List<Opportunity>();
            while (reader.Read()) 
            {
                Opportunity obj = new Opportunity();
                obj.OppId = Convert.ToInt32(reader["OppId"]);
                obj.Name = reader["Name"].ToString();
                obj.PlanName = reader["PlanName"].ToString();
                obj.price = reader["Price"].ToString();
                obj.ConvertedBy = reader["ConvertedBy"].ToString();
                obj.Remark = reader["Remark"].ToString();
                obj.LeadId = Convert.ToInt32(reader["LeadId"]);
                slist.Add(obj);
                
            
            }
            return slist; 
        }

        public int InsertData(int oppid, string planname, string price,string convertedby, string remark, int leadid, string name) 
        {
            try 
            {
                Opportunity op = new Opportunity() {OppId=oppid,PlanName=planname,price=price, ConvertedBy=convertedby,Remark=remark,LeadId=leadid, Name=name };
                d.InsertOpportunity(op);
                return 1;            
            
            }catch(Exception ex) { return 0; }
        
        }

        public int UpdateData(int oppid,  string planname, string price, string convertedby, string remark, int leadid, string name)
        {
            try
            {
                Opportunity op = new Opportunity() { OppId = oppid, PlanName = planname, price = price, ConvertedBy = convertedby, Remark = remark, LeadId = leadid, Name=name };
                d.UpdateOpportunity(op);
                return 1;

            }
            catch (Exception ex) { return 0; }


        }

        public int DeleteData(int id)
        {
            try { 
                d.DeleteOpportunity(id);
                return 1;
            
            }catch(Exception ex) { return 0; }
        
        }






    }
}