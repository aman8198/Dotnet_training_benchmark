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
    public class OpportunityController : ApiController
    {
        OpportunityBAL b = new OpportunityBAL();
        [HttpGet]
        public List<Opportunity> GetOpportunityL() {
            List<Opportunity> slist = b.getOpportunity();
            return slist;
        }

        [HttpPost]
        public int InsertOpp(Opportunity op)
        {
            int res = b.InsertData(op.OppId, op.PlanName, op.price, op.ConvertedBy, op.Remark, op.LeadId, op.Name);
            return res;
        
        }

        [HttpPut]
        public int UpdateOpp(Opportunity op) 
        {
            int res = b.UpdateData(op.OppId, op.PlanName, op.price, op.ConvertedBy, op.Remark, op.LeadId, op.Name);
            return res;
        
        }

        [HttpDelete]
        public int DeleteOpp(Opportunity op) 
        {
            int res = b.DeleteData(op.OppId);
            return res;
        
        }


    }
}
