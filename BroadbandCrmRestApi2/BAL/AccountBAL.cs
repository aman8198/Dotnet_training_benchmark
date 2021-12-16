using BroadbandCrmRestApi2.DAL;
using BroadbandCrmRestApi2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BroadbandCrmRestApi2.BAL
{
    public class AccountBAL
    {
        AccountDAL d = new AccountDAL();

        public List<Account> getAccount()
        {
            SqlDataReader reader = d.GetAccountData();
            List<Account> slist = new List<Account>();
            while (reader.Read())
            {
                Account acc = new Account();
                acc.CustId = Convert.ToInt32(reader["CustId"]);
                acc.OppId = Convert.ToInt32(reader["OppId"]);
                acc.Name = reader["Name"].ToString();
                acc.PlanName = reader["PlanName"].ToString();
                acc.Speed = reader["Speed"].ToString();
                acc.Price = reader["Price"].ToString();
                acc.Validity = reader["Validity"].ToString();
                acc.Startdate = reader["StartDate"].ToString();
                acc.EndDate = reader["EndDate"].ToString();
                acc.BillingAddress = reader["BillingAdddress"].ToString();
                acc.ShippingAddress = reader["ShippingAddress"].ToString();
                acc.ConvertedBy = reader["ConvertedBy"].ToString();
                acc.Status = reader["Status"].ToString();
                slist.Add(acc);



            }
            return slist;

        }

        public int InsertData(int custid, int oppid, string name, string planname, string speed, string price, string validity, string startdate, string enddate, string billingaddress, string shippingaddress, string covertedby, string status)
        {
            try
            {
                Account a = new Account() { CustId = custid, OppId = oppid, Name = name, PlanName = planname, Speed = speed, Price = price, Validity = validity, Startdate = startdate, EndDate = enddate, BillingAddress = billingaddress, ShippingAddress = shippingaddress, ConvertedBy = covertedby, Status = status };
                d.InsertAccount(a);
                return 1;
            }
            catch (Exception ex) { return 0; }

        }

        public int UpdateData(int custid, int oppid, string name, string planname, string speed, string price, string validity, string startdate, string enddate, string billingaddress, string shippingaddress, string covertedby, string status)
        {
            try
            {
                Account a = new Account() { CustId = custid, OppId = oppid, Name = name, PlanName = planname, Speed = speed, Price = price, Validity = validity, Startdate = startdate, EndDate = enddate, BillingAddress = billingaddress, ShippingAddress = shippingaddress, ConvertedBy = covertedby, Status = status };
                d.UpdateAccount(a);
                return 1;
            }
            catch (Exception ex) { return 0; }

        }

        public int DeleteData(int id)
        {
            try {
                d.DeleteAccount(id);
                return 1;
            }catch(Exception ex) { return 0; }
        }

    } 

   }
