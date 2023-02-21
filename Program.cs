using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Black;

            
            Student s1 = new Student();
            s1.ClassId = 10;
            s1.Studname = "Hari";
            s1.Marks = 40;


            Student s2 = new Student();
            s2.ClassId = 10;
            s2.Studname = "Harish";
            s2.Marks = 60;

            Student s3 = new Student();
            s3.ClassId = 10;
            s3.Studname = "Mary";
            s3.Marks = 50;


            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(new Student {ClassId=10,Studname="ankita",Marks=70 });
            students.Add(new Student(10,"Payal",80));


            
            
            students.Sort();

            foreach (var item in students)
            {
                Console.WriteLine(item.ClassId);
                Console.WriteLine(item.Studname);
                Console.WriteLine(item.Marks);
                Console.WriteLine();
            }

         Student smax = students.Max();


            //Console.WriteLine();

        //    List<int> m = new List<int>();


        //    foreach (var item in students)
        //    {
            
        //        m.Add(item.Marks);


        //    }

        //    int maxmarks = m.Max();
        //Console.WriteLine(maxmarks);



            //SortedList<int, string> empnames = new SortedList<int, string>();
            //empnames.Add(1, "Anil");
            //empnames.Add(20, "Sunil");
            //empnames.Add(200, "Anita");
            //empnames.Add(2, "Pramila");


            //foreach (KeyValuePair<int,string> item in empnames)
            //{
            //    Console.Write(item.Key + "  ");
            //    Console.WriteLine(item.Value);
            //}

            //Console.WriteLine("-------------");
            //KeyValuePair<int,string> data=empnames.ElementAt(1);
            //Console.WriteLine(data.Key);
            //Console.WriteLine(data.Value);



            //SortedSet<int> s = new SortedSet<int>();
            //s.Add(10);
            //s.Add(200);
            //s.Add(55);
            //s.Add(5);

            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> intlist = new List<int>();
            //intlist.Add(10);
            //intlist.Add(200);
            //intlist.Add(55);
            //intlist.Add(5);

            //intlist.Sort();
            //foreach (var item in intlist)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------");
            //Console.WriteLine("sum= " + intlist.Sum());

            //Console.WriteLine("Average= " + intlist.Average());




            //Stack<string> s = new Stack<string>();
            //s.Push("Anisha");
            //s.Push("Atul");
            //s.Push("Amita");
            //s.Push("Sunita");

            //s.Push("Deeksha");




            Console.ReadKey();





        }
    }
}
