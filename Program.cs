using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace HRApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            EmployeeMgt employeeMgt = new EmployeeMgt();
            char input;
            do
            {
                try
                {
                    Console.WriteLine("1 for add, 2 delete , 3 find,4 display, 5 exit");
                    int userchice = int.Parse(Console.ReadLine());
                    switch (userchice)
                    {
                        case 1:
                            Console.WriteLine("enter Employeeid");
                            emp.Empid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter employee name");
                            emp.EName = Console.ReadLine().Trim();
                            Console.WriteLine("enter deptno");
                            emp.Deptno = int.Parse(Console.ReadLine());

                            employeeMgt.AddEmployee(emp);
                            break;
                        case 2:
                            Console.WriteLine("Enter Employee no to find");
                            emp.Empid = Convert.ToInt32(Console.ReadLine());
                            int empid = emp.Empid;
                            employeeMgt.DeleteEmployee(empid);

                            break;
                        case 3:
                            Console.WriteLine("Enter Employee no to find");
                            emp.Empid = Convert.ToInt32(Console.ReadLine());
                            empid = emp.Empid;
                            employeeMgt.Findemployee(empid);
                            break;
                        case 4:

                            foreach (var item in EmployeeMgt.emplist)
                            {
                                Console.WriteLine(item.Empid + "  " + item.EName + " " + item.Deptno);

                            }


                            break;
                        default:
                            Environment.Exit(1);
                            break;
                    }




                }
                catch (EmployeeNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                catch (EmployeeAlreadyExistsException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Thank you,Visit again....");

                }
                Console.WriteLine("do you want to continue? Y/y");
                input = Convert.ToChar(Console.Read());

            } while (input=='Y' || input=='y' );

            
            Console.ReadLine();
        }
    }
}
