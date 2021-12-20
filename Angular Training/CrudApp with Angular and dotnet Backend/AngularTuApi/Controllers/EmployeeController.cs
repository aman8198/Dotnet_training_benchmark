using AngularTuApi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace AngularTuApi.Controllers
{
    public class EmployeeController : ApiController
    {
        public HttpResponseMessage Get() 
        {
            string query = @"select EmployeeId, EmployeeName, Department, DateOfJoining, PhotoFileName from dbo.AngularEmployee";
            DataTable table = new DataTable();
            using(var con = new SqlConnection(ConfigurationManager.ConnectionStrings["conns"].ConnectionString))
                using(var cmd = new SqlCommand(query, con))
                using(var da = new SqlDataAdapter(cmd)) 
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);
        
        }

        public string Post(Employee emp) 
        {
            try
            {
                string query = @"insert into dbo.AngularEmployee values(
                          '" + emp.EmployeeName + @"',
                           '" + emp.Department + @"',
                            '" + emp.DateOfJoining + @"',
                             '" + emp.PhotoFileName + @"'
                            
                    )";
                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["conns"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Added Sucessfully!!";

            }
            catch(Exception ) 
            {
                return "Failed to Add!!";
            }
        
        }

        public string Put(Employee emp) 
        {
            try 
            {
                string query = @"update dbo.AngularEmployee set
                               EmployeeName='" + emp.EmployeeName + @"',
                               Department='" + emp.Department + @"',
                               DateOfJoining='" + emp.DateOfJoining + @"',
                               PhotoFileName='" + emp.PhotoFileName + @"'
                               where EmployeeId=" + emp.EmployeeId + @"

                           ";
                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["conns"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Updated Successfully!!";


            }
            catch (Exception) 
            {
                return "Failed to Update!!";
            }
        }

        public string Delete(int id) 
        {
            try 
            {
                string query = @"delete from dbo.AngularEmployee where EmployeeId=" + id + @"";
                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["conns"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Deleted Successfully!!";


            }
            catch (Exception) { return "Failed to Delete!"; }
        
        }

        [Route("api/Employee/GetAllDepartmentNames")]
        [HttpGet]
        public HttpResponseMessage GetAllDepartmentNames()
        {
            string query = @"select DepartmentName from dbo.AngularDepartment";
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["conns"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        [Route("api/Employee/SaveFile")]
        public string SaveFile() 
        {
            try 
            {
                var httpRequest = HttpContext.Current.Request;
                var postedFiles = httpRequest.Files[0];
                string filename = postedFiles.FileName;
                var physicalPath = HttpContext.Current.Server.MapPath("~/Photos/" + filename);
                postedFiles.SaveAs(physicalPath);
                return filename;
            } catch (Exception) { return "anonymous.png"; }
        
        }




    }
}
