using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Student:IComparable
       {

        public int ClassId { get; set; }
        public string Studname { get; set; }
        public int Marks { get; set; }


        public Student()
        {

        }


        public Student(int classid,string name,int m1)
        {
            this.ClassId = classid;
            this.Marks = m1;
            this.Studname = name;
        }
        public int CompareTo(object obj)
        {
            Student obj1 = obj as Student;
            return Marks.CompareTo(obj1.Marks);
        }
    }
}
