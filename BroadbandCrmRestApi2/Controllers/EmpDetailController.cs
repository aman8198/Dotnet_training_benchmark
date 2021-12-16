using BroadbandCrmRestApi2.BAL;
using BroadbandCrmRestApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace BroadbandCrmRestApi2.Controllers
{

    public class EmpDetailController : ApiController
    {
        EmpDetailsBAL eb = new EmpDetailsBAL();

        [System.Web.Http.HttpGet]
        public List<EmpDetails> GetEmpDetails()
        {
            List<EmpDetails> eblist = eb.getEmployee();
            return eblist;
        }


        [System.Web.Http.HttpGet]
        public EmpDetails GetEmpDetailsid(int id)
        {
            EmpDetails ed = eb.GetEmpDetailbysId(id);
            return ed;
        
        
        }

        [System.Web.Http.HttpPost]
        public int Insert(EmpDetails ed) 
        {
            int res = eb.InsertEmp(ed.Emp_Id, ed.EmpName, ed.EmpAddress, ed.phoneno, ed.Email);
            return res;
        
        }

        [System.Web.Http.HttpPut]

        public int Update(EmpDetails ed)
        {
            int res = eb.UpdateEmp(ed.Emp_Id, ed.EmpName, ed.EmpAddress, ed.phoneno, ed.Email);
            return res;



        }

        [System.Web.Http.HttpDelete]
        public int Delete(EmpDetails ed) 
        {
            int res = eb.DeleteEmp(ed.Emp_Id);
            return res;
        
        }
    }
}
