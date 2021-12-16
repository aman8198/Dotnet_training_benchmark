using BroadbandCrmRestApi2.DAL;
using BroadbandCrmRestApi2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BroadbandCrmRestApi2.BAL
{
    public class EmpDetailsBAL
    {
        EmpDetailDAL ed = new EmpDetailDAL();

        public List<EmpDetails> getEmployee()
        {
            SqlDataReader reader = ed.getEmpDetails();
            {
                List<EmpDetails> edlist = new List<EmpDetails>();
                while (reader.Read())
                {
                    EmpDetails obj = new EmpDetails();
                    obj.Emp_Id = Convert.ToInt32(reader["Emp_Id"]);
                    obj.EmpName = Convert.ToString(reader["EmpName"]);
                    obj.EmpAddress = Convert.ToString(reader["EmpAddress"]);
                    obj.phoneno = Convert.ToString(reader["Phoneno"]);
                    obj.Email = Convert.ToString(reader["Email"]);
                    edlist.Add(obj);


                }
                return edlist;
            }

        }

        public EmpDetails GetEmpDetailbysId(int id)
        {
            SqlDataReader reader = ed.getEmpDetailsusingId(id);
            reader.Read();

            EmpDetails obj = new EmpDetails();
            obj.Emp_Id = Convert.ToInt32(reader["Emp_Id"]);
            obj.EmpName = Convert.ToString(reader["EmpName"]);
            obj.EmpAddress = Convert.ToString(reader["EmpAddress"]);
            obj.phoneno = Convert.ToString(reader["Phoneno"]);
            obj.Email = Convert.ToString(reader["Email"]);

            return obj;




        }

        public int InsertEmp(int Emp_Id, string EmpName, string EmpAddress, string Phoneno, string Email)
        {
            try 
            {
                EmpDetails ed1 = new EmpDetails() { Emp_Id = Emp_Id, EmpName = EmpName, EmpAddress = EmpAddress, phoneno=Phoneno, Email=Email};
                ed.InsertEmpDetails(ed1);
                return 1;
            
            
            
            }catch(Exception ex) 
            {
                return 0;
            
            }
        
        
        
        }

        public int UpdateEmp(int Emp_Id, string EmpName, string EmpAddress, string Phoneno, string Email) 
        {
            try 
            {
                EmpDetails ed1 = new EmpDetails() { Emp_Id = Emp_Id, EmpName = EmpName, EmpAddress = EmpAddress, phoneno = Phoneno, Email = Email };
                ed.UpdateEmpDetails(ed1);
                return 1;
            
            
            }
            catch(Exception ex) 
            {
                return 0;
            
            
            }
        
        }

        public int DeleteEmp(int Emp_Id) 
        {
            try 
            {
                ed.DeleteEmpDetails(Emp_Id);
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
        
        
        
        }



    }
}