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
    public class LeadController : ApiController
    {
        LeadBAL b = new LeadBAL();

        public List<Lead> GetLeadList() 
        {
            List<Lead> slist = b.GetLeads();
            return slist;
        
        }

        [HttpPost]
        public int InsertL(Lead l) 
        {
            int res = b.InsertLead(l.Lead_Id, l.Name, l.City, l.State, l.Gender, l.Phoneno, l.Remark, l.CreatedBy, l.Status);
            return res;

        }

        [HttpPut]
        public int UpdateL(Lead l)
        {
            int res = b.UpdateLead(l.Lead_Id, l.Name, l.City, l.State, l.Gender, l.Phoneno, l.Remark, l.CreatedBy, l.Status);
            return res;
        
        }

        [HttpDelete]
        public int DeleteDept(Lead l) 
        {
            int res = b.DeleteLead(l.Lead_Id);
            return res;
        
        }


    }
}
