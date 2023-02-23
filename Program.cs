using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemos
{
    class Program
    {
        static void Main(string[] args)
        {
//Object LINQ(Language Integrated Query)    -----        OLINQ//
            int[] arr = new int[] {12,34,56,4,46290,22,225,764 };

            var evenNos = from d in arr
                          where d % 2 == 0
                          select d;
            foreach (var item in evenNos)
            {
                Console.Write (item +" " );
            }
            Console.WriteLine(  );


            Console.WriteLine("-----------------------------");

            List<Students> students = new List<Students>() { 
            new Students{Rollno=1,Name="Anish",CrsID=10,Marks=40 },
            new Students{Rollno=2,Name="Anisha",CrsID=10,Marks=30 },
            new Students{Rollno=3,Name="Manish",CrsID=10,Marks=50 },
            new Students{ Rollno=4,Name="Manisha",CrsID=11,Marks=60},
            new Students{Rollno=5,Name="Ankit",CrsID=10,Marks=80 }
            
            };

            var data = from s in students
                       where s.Marks > 40 && s.CrsID==10
                       select s;

            foreach (var item in data)
            {
                Console.WriteLine(item.Rollno + "   " + item.Name + "  " + item.CrsID + "  "  +item.Marks);

            }

            var d1=students.Where(s => s.Marks > 40).ToList();
            Console.WriteLine("-------------------------");
           
            List<Students> studlist = new List<Students>() {
            new Students{Rollno=1,Name="Anish",CrsID=10,Marks=40 },
            new Students{Rollno=2,Name="Anisha",CrsID=10,Marks=30 },
            new Students{Rollno=13,Name="Manish",CrsID=11,Marks=50 },
            new Students{ Rollno=3,Name="Manisha",CrsID=11,Marks=60},
            new Students{Rollno=5,Name="Ankit",CrsID=10,Marks=80 },
            new Students{Rollno=6,Name="Ankita",CrsID=11,Marks=70 },
            new Students{Rollno=7,Name="Ankita",CrsID=12,Marks=70 },
                  };

            //var crsWiseData = from s in studlist
            //                  orderby s.Rollno
            //                  group s by s.CrsID;

            //var groupByData=studlist.OrderBy(s1=>s1.Rollno).GroupBy(s => s.CrsID);
            //foreach (var Crs in crsWiseData)
            //{
            //    Console.WriteLine("course= " + Crs.Key);
            //    foreach (var item in Crs)
            //    {
            //        Console.WriteLine(item.Rollno + "  " + item.Name + item.Marks);

            //    }

            //}


            var crsWiseData = from s in studlist
                              group s by s.CrsID into StudData
                              select new { CourseID=StudData.Key, st=StudData };

           foreach (var item in crsWiseData)
            {
                Console.WriteLine(item.CourseID);
                foreach (var  i in item.st)
                {
                    Console.WriteLine(i.Rollno);
                    Console.WriteLine(i.Name);
                    Console.WriteLine(i.Marks);
                    Console.WriteLine(item.CourseID);
                }
            }
            

            Console.WriteLine("-------------------------------");


            var d2 = from s in studlist
                     where s.Marks > 40
                     select new { s.Rollno, s.Name };

            foreach (var item in d2)
            {
                Console.WriteLine(item.Name + item.Rollno);
            }


            Console.WriteLine("---------------------------------------");


            List<Customers> customers = new List<Customers>() {
            new Customers{Custid=1,Custname="A",City="Bengaluru" },
            new Customers{ Custid=2,Custname="B" ,City="Hyderabad"},
            new Customers{ Custid=3,Custname="C" ,City="Bengaluru" },
                new Customers{ Custid=4,Custname="D" ,City="Hyderabad"},

            };

            var custdata = from a in customers
                           group a by a.City into CityData
                           select new { cityname = CityData.Key, mylist = CityData };


            foreach (var item in custdata)
            {
                Console.WriteLine(item.cityname);

                foreach (var i in item.mylist)
                {
                    Console.WriteLine(i.Custid);
                    Console.WriteLine(i.Custname);
                    Console.WriteLine(i.City);
                }
            }










            Console.ReadKey();
        }
    }
}
