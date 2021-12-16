using BroadbandCrmRestApi2.BAL;
using BroadbandCrmRestApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BroadbandCrmRestApi2.Controllers
{
    public class AccountController : ApiController
    {
        AccountBAL b = new AccountBAL();

        [HttpGet]
        public List<Account> GetAccountList() 
        {
            List<Account> slist = b.getAccount();
            return slist;
        
        }

        [HttpPost]
        public int InsertAcc(Account ac) 
        {
            int res = b.InsertData(ac.CustId, ac.OppId, ac.Name, ac.PlanName, ac.Speed, ac.Price, ac.Validity, ac.Startdate, ac.EndDate, ac.BillingAddress, ac.ShippingAddress, ac.ConvertedBy, ac.Status);
            return res;
        
        }

        [HttpPut]
        public int UpdateAcc(Account ac) 
        {

            int res = b.UpdateData(ac.CustId, ac.OppId, ac.Name, ac.PlanName, ac.Speed, ac.Price, ac.Validity, ac.Startdate, ac.EndDate, ac.BillingAddress, ac.ShippingAddress, ac.ConvertedBy, ac.Status);
            return res;
        }

        public int DeleteAcc(Account ac)
        {
            int res = b.DeleteData(ac.CustId);
            return res;
        }

    }
}
