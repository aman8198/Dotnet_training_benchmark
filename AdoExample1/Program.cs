using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AdoExample1
{
    class EmpData
    {
        public SqlDataReader GetEmployee()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Emp_db;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("GetEmployeeData", con);
                cmd.CommandType =CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
            }catch(SqlException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            return reader;
        }
        public SqlDataReader GetEmployeeUsingEno(int empno)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Emp_db;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("GetEmpUsingEmpno", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("empno", empno);
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();


            }catch(SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            return reader;
        }
        public int InsertEmployee(int empno, string ename, string location, string ehead)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server = .;Database=Emp_db;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("empno", empno);
                cmd.Parameters.AddWithValue("ename", ename);
                cmd.Parameters.AddWithValue("location", location);
                cmd.Parameters.AddWithValue("ehead", ehead);
                no = cmd.ExecuteNonQuery();
                con.Close();
            }catch(SqlException ex)
            {
                Console.WriteLine("Exception" + ex.Message);
            }
            return no;
        }
        public int UpdateEmployee(int empno, string ename, string location, string ehead)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Emp_db;trusted_connection=true";
                con.Open();
                SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("empno", empno);
                cmd.Parameters.AddWithValue("ename", ename);
                cmd.Parameters.AddWithValue("location", location);
                cmd.Parameters.AddWithValue("ehead", ehead);
                no = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception" + ex.Message);

            }
            return no;
            
        }
        public int DeleteEmployee(int empno)
        {
            int no =0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Emp_db;trusted_connection=true";
                con.Open();
                SqlCommand cmd = new SqlCommand("DeleteEmpUsingEmpno", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("empno", empno);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }catch(SqlException ex)
            {
                Console.WriteLine("Exception" + ex.Message);
            }
            return no;


        }


    }
    class Employee
    {
        EmpData dat = new EmpData();
        public int empno
        {
            get;
            set; 
        }
        public string ename
        {
            get;
            set;
        }
        public string location
        {
            get;
            set;
        }

        public string ehead
        {
            get;
            set;
        }
        public void PrintEmployeeData()
        {
            SqlDataReader reader = dat.GetEmployee();
            Console.WriteLine("empno\tename\tlocation\tehead");
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3]);           
            }
        }

        public void PrintEmployee()
        {
            SqlDataReader reader = dat.GetEmployeeUsingEno(empno);
            Console.WriteLine("empno\tename\tlocation\tehead");
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3]);
            }
        }

        public void InsertEmployee()
        {
            int no = dat.InsertEmployee(empno, ename, location, ehead);
            if (no > 0)
            {
                Console.WriteLine("Data Inserted Succesfully");
            }
        }
        public void UpdateEmployee()
        {
            int no = dat.UpdateEmployee(empno, ename, location, ehead);
            if(no > 0)
            {

                Console.WriteLine("Data Updated Successfully");
            }
        }
        public void DeleteEmployee()
        {
            int no = dat.DeleteEmployee(empno);
            if (no > 0)
            {
                Console.WriteLine("Data deleted successfully");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            char ch;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Print All Employee ");
                Console.WriteLine("2.Print Employee Based on Empno");
                Console.WriteLine("3.Insert Employee");
                Console.WriteLine("4. Update all Employee ");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("Enter choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Employee e = new Employee();
                        e.PrintEmployeeData();
                        break;
                    case 2:
                        Employee e1 = new Employee();
                        Console.WriteLine("Enter employee no to view details");
                        e1.empno = Convert.ToInt32(Console.ReadLine());
                        e1.PrintEmployee();
                        break;
                    case 3:
                        Employee e2 = new Employee();
                        Console.WriteLine("Enter Employee Details to enter eno, ename, location, ehead");
                        e2.empno = Convert.ToInt32(Console.ReadLine());
                        e2.ename = Console.ReadLine();
                        e2.location = Console.ReadLine();
                        e2.ehead = Console.ReadLine();
                        e2.InsertEmployee();
                        break;
                    case 4:
                        Employee e3 = new Employee();
                        Console.WriteLine("Enter Employee Details to update empno, ename, location, ehead");
                        e3.empno = Convert.ToInt32(Console.ReadLine());
                        e3.ename = Console.ReadLine();
                        e3.location = Console.ReadLine();
                        e3.ehead = Console.ReadLine();
                        e3.UpdateEmployee();
                        break;
                    case 5:
                        Employee e4 = new Employee();
                        Console.WriteLine("Enter employee no to delete");
                        e4.empno = Convert.ToInt32(Console.ReadLine());
                        e4.DeleteEmployee();
                        break;
                    default:
                        Console.WriteLine("Invalid Case");
                        break;

                }
                Console.WriteLine("Enter y or Y to continue");
                ch = Convert.ToChar(Console.ReadLine());



            } 
            while (ch == 'Y'|| ch == 'y');
            Console.ReadLine();

        }
    }
}
