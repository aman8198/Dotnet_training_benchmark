using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.ViewModel;
using WebApplication2.DAL;
using System.Data.SqlClient;
namespace WebApplication2.BAL
{
    public class EmployeeBAL
    {
        public List<EmployeeVM> GetEmpList()
        {
            EmployeeDAL d = new EmployeeDAL();
            SqlDataReader reader = d.GetEmpData();
            List<EmployeeVM> elist = new List<EmployeeVM>();
            while (reader.Read())
            {
                EmployeeVM o = new EmployeeVM();
                o.empno = Convert.ToInt32(reader["empno"].ToString());
                o.ename = reader["ename"].ToString();
                o.location = reader["location"].ToString();
                o.ehead = reader["ehead"].ToString();
                elist.Add(o);
            }
            return elist;
        }
    }
}