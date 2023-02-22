using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    //declaration of delegate
    //same signature of the method
    public delegate int d1(string s);

    public delegate void d2(string p1, string p2, string s3);

    public delegate string d3(String s);

    public delegate void StringFuns(string s);
    public class StringManipulations
    {

        //Methods
        public int StringLength(string s)
        {
            return s.Length;
        
        }

        public void ConcatStrings(string s1, string s2, string s3)
        {
            string temp=string.Concat(s1, s2);
            string fullstr = string.Concat(temp, s3);
            Console.WriteLine(fullstr);
        
        }

        public string ConvertToUpper(string s)
        {

            return s.ToUpper();
        
        }
       public void ConvertToUpperCase(string s)
        {

            Console.WriteLine(s.ToUpper());

        }
        public void ConvertToLowerCase(string s)
        {

            Console.WriteLine(s.ToLower());

        }


    }
}
