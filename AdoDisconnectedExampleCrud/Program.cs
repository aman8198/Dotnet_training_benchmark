using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AdoDisconnectedExampleCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=Emp_db;trusted_connection=true");
            SqlCommand cmd = new SqlCommand("select * from emp1", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
         
            adapter.Fill(ds);
            DataTable tab = ds.Tables[0];

          
            try {
              
                int choice;
                char ch;
                do
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("Press 1 for printing All Employee");
                    Console.WriteLine("press 2 to display employee based on Empno");
                    Console.WriteLine("Press 3 to Insert Employee ");
                    Console.WriteLine("Press 4 to Update Employee");
                    Console.WriteLine("press 5 to Delete Record");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                         
                            
                            foreach (DataRow row in tab.Rows)
                            {
                                Console.WriteLine(row[0].ToString() + "/" + row[1].ToString() + "/" + row[2].ToString() + "/" + row[3].ToString());
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter empno");
                            int empno = Convert.ToInt32(Console.ReadLine());
                            DataRow[] rows = tab.Select("empno=" + empno);
                            Console.WriteLine("Data As follows:");
                            foreach(DataRow row in rows)
                            {
                                Console.WriteLine(row[0].ToString() + "/" + row[1].ToString() + "/" + row[2].ToString() + "/" + row[3].ToString());

                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter empno");
                            int empno1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee Name");
                            string ename = Console.ReadLine();
                            Console.WriteLine("Enter Employee Location");
                            string location = Console.ReadLine();
                            Console.WriteLine("Enter Employee Head");
                            string ehead = Console.ReadLine();
                         
                            DataRow NewRow = tab.NewRow();
                            NewRow["empno"] = empno1;
                            NewRow["ename"] = ename;
                            NewRow["location"] = location;
                            NewRow["ehead"] = ehead;
                            tab.Rows.Add(NewRow);
                            adapter.Update(tab);
                            Console.WriteLine("Record Inserted");
                            break;

                        case 4:
                            Console.WriteLine("Enter empno");
                            int empno2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee Name");
                            string ename1 = Console.ReadLine();
                            Console.WriteLine("Enter Employee Location");
                            string location1 = Console.ReadLine();
                            Console.WriteLine("Enter Employee Head");
                            string ehead1 = Console.ReadLine();

                            DataRow[] ro = tab.Select("empno="+empno2);
                            DataRow NewRow1 = ro[0];
                            
                            NewRow1["ename"] = ename1;
                            NewRow1["location"] = location1;
                            NewRow1["ehead"] = ehead1;
                           
                            adapter.Update(tab);
                            Console.WriteLine("Record Updated");
                            break;
                        case 5:
                            Console.WriteLine("Enter empno:");
                            int empno3 = Convert.ToInt32(Console.ReadLine());
                            DataRow[] rod = tab.Select("empno=" + empno3);
                            DataRow rowdelete = rod[0];
                            rowdelete.Delete();
                            adapter.Update(tab);
                            Console.WriteLine("Record deleted");
                            break;
                        default:
                            Console.WriteLine("Invalid Case");
                            break;

                    }
                    Console.WriteLine("Enter the y or Y");
                    ch = Convert.ToChar(Console.ReadLine());

                } while (ch == 'Y' || ch == 'y');
                Console.ReadLine();


            }
            catch (SqlException se)
            {
                Console.WriteLine("Exception" + se.Message);
            }
            
        }
    }
}
