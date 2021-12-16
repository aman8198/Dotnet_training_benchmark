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
    public class EmpTaskController : ApiController
    {
        EmpTaskBAL etb = new EmpTaskBAL();

        [HttpGet]
        public List<EmpTask> GetAllT() 
        {
            List<EmpTask> slist = etb.GetAllTask();
            return slist;
        
        }

        [HttpPost]
        public int Insert(EmpTask et) 
        {
            int res = etb.InsertTask(et.Task_Id, et.TaskName, et.TaskModule, et.TaskDescription, et.TStatus, et.StartDate, et.EndDate, et.Emp_Id);
            return res;

        }

        [HttpPut]
        public int Update(EmpTask et) 
        {
            int res = etb.UpdateTask(et.Task_Id, et.TaskName, et.TaskModule, et.TaskDescription, et.TStatus, et.StartDate, et.EndDate, et.Emp_Id);
            return res;
        }

        [HttpDelete]
        public int Delete(EmpTask et) 
        {
            int res = etb.DeleteTask(et.Task_Id);
            return res;
        
        }


    }
}
