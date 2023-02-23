using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class EmployeeMgt
    {

        public static List<Employee> emplist = new List<Employee>();
        public EmployeeMgt()
        {

            emplist.Add(new Employee { Empid = 1, EName = "Akshit", Deptno = 10 });
            emplist.Add(new Employee { Empid = 2, EName = "Jim", Deptno = 20 });
            emplist.Add(new Employee { Empid = 3, EName = "Mary", Deptno = 10 });
            emplist.Add(new Employee { Empid = 4, EName = "Raj", Deptno = 20 });


        }


        Employee empfound;
        public void Findemployee(int empno)
        {

            if ((empno != 0) && empno > 0)
            {
              empfound = emplist.Find(e => e.Empid == empno);
                if (empfound != null)
                {
                    Console.WriteLine(empfound.Empid);
                    Console.WriteLine(empfound.EName);
                    Console.WriteLine(empfound.Deptno);
                }


            }
            else
            {
                throw new EmployeeNotFoundException("Pls check the empno you trying to find.....");
            }


        }

        public void AddEmployee(Employee emp)
        {
            Employee e1 = emplist.Find(e => e.Empid == emp.Empid);

            if (e1==null)
            {
                emplist.Add(new Employee { Empid = emp.Empid, EName = emp.EName, Deptno = emp.Deptno });
                
            }
            else
            {
             
                throw new EmployeeAlreadyExistsException("this record already exists");
            }

        }
        public void DeleteEmployee(int empno)
        {
            Findemployee(empno);
            emplist.Remove(empfound);




        }
    }
}
