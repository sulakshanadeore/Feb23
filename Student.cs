using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public class Student
    {
        public int Rollno { get; set; }
        public string Studname { get; set; }

        public void ShowDetails(Student[] students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item.Rollno);
                Console.WriteLine(item.Studname);
            }
        
        }

        public void PrintCountStudents(int cnt)
        {
            if (cnt>5)
            {
                throw new IndexOutOfRangeException("We dont have so many students");
            }
            else
            {
                Console.WriteLine("the count= "+ cnt);
            }
        
        }

    }
}
