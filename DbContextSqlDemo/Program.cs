using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContextSqlDemo.Data;
using DbContextSqlDemo.Models;
using IO = System.Console;
namespace DbContextSqlDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDbContext empdb = new EmployeeDbContext();
            string str = "1-Add New Employee\n2-Show Students\n3-Search By ID";
            string flag = "yes";
            int option = 0;
            while (flag != "no")
            {
                Console.Clear();
                Console.WriteLine(str);

                Console.Write("Choose Option:");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("I want to add new student");
                        Employee emp = new Employee();
                        IO.Write("Enter Name:");
                        emp.Name = IO.ReadLine();
                        IO.Write("Enter Job: ");
                        emp.Job = IO.ReadLine();
                        IO.Write("Enter Age: ");
                        emp.Age = int.Parse(IO.ReadLine());
                        empdb.Employees.Add(emp);
                        //db.SaveChanges();
                        if (empdb.SaveChanges() > 0)
                        {
                            IO.WriteLine("New Record Saved....");
                        }
                        break;
                    case 2:
                        Console.Clear();
                       
                        var emplist =    empdb.Employees.ToList();
                        foreach(var em in emplist)
                        {
                            IO.WriteLine(em.Id.ToString()+"  "+em.Name+"   "+em.Job+"   "+em.Age.ToString());
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter Number of Id:");
                        int y = int.Parse(IO.ReadLine());
                       var empmember = empdb.Employees.Find(y);
                        IO.WriteLine(empmember.Id.ToString()+ "  "+ empmember.Name+ "   "+ empmember.Job+ "   "+ empmember.Age.ToString());
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid option");
                        break;

                }

                Console.Write("Do you want to continue(yes/no):");
                flag = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
