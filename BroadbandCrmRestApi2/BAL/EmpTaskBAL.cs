using BroadbandCrmRestApi2.DAL;
using BroadbandCrmRestApi2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BroadbandCrmRestApi2.BAL
{
    public class EmpTaskBAL
    {
        EmpTaskDal etd = new EmpTaskDal();

        public List<EmpTask> GetAllTask() 
        {
            SqlDataReader reader = etd.GetAllEmpTask();
            List<EmpTask> slist = new List<EmpTask>();
            while (reader.Read()) 
            {
                EmpTask et = new EmpTask();
                et.Task_Id = Convert.ToInt32(reader["Task_Id"]);
                et.TaskName = reader["TaskName"].ToString();
                et.TaskModule = reader["TaskModule"].ToString();
                et.TaskDescription = reader["TaskDescription"].ToString();
                et.TStatus = reader["TStatus"].ToString();
                et.StartDate = reader["StartDate"].ToString();
                et.EndDate = reader["EndDate"].ToString();
                et.Emp_Id = Convert.ToInt32(reader["Emp_Id"]);
                slist.Add(et);
                
            }
            return slist;

        
        }

        public int InsertTask(int task_Id, string taskname, string taskmodule, string taskdescription, string taskstatus, string startdate, string enddate, int Emp_Id) 
        {
            try {
                EmpTask et = new EmpTask() { Task_Id = task_Id, TaskName = taskname, TaskModule = taskmodule, TaskDescription = taskdescription, TStatus = taskstatus, StartDate = startdate, EndDate = enddate, Emp_Id = Emp_Id };
                etd.InsertEmptask(et);
                return 1;
            
            }catch(Exception ex) 
            
            {
                return 0;
            
            }
        
        
        }

        public int UpdateTask(int task_Id, string taskname, string taskmodule, string taskdescription, string taskstatus, string startdate, string enddate, int Emp_Id) 
        {
            try {
                EmpTask et = new EmpTask() { Task_Id = task_Id, TaskName = taskname, TaskModule = taskmodule, TaskDescription = taskdescription, TStatus = taskstatus, StartDate = startdate, EndDate = enddate, Emp_Id = Emp_Id };
                etd.UpdateEmpTask(et);
                return 1;


            }
            catch(Exception ex)
            {
                return 0;
            
            }
        
        
        }

        public int DeleteTask(int id)
        {
            try {
                etd.DeleteEmpTask(id);
                return 1;
            
            
            }catch(Exception ex) 
            {
                return 0;
            }
        
        
        }

    }
}