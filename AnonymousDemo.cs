using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    //public delegate int d1(string s); //length

    //public delegate void StringFuns(string s);
    public delegate int DoCalculations(int n1, int n2);
    class AnonymousDemo
    {
        static void Main(string[] args)
        {

            DoCalculations obj1 = delegate (int i, int j) {
                int addans = i + j;
                Console.WriteLine(addans);
                if (i > 0)
                {
                    int subans = i - j;
                    Console.WriteLine(subans);

                    int divans = i / j;
                    Console.WriteLine(divans);

                }
                int multi = i * j;
                return multi;
                            };

            int multians=obj1.Invoke(10, 2);
            Console.WriteLine(multians);





            
            d1 obj = delegate (string s) { 
                Console.WriteLine("The length of the string {s} =" + s.Length);
                Console.WriteLine(s);
                s=s.Replace("e", "aa");
                Console.WriteLine(s);
                return s.Length + 1;
            
            };
            int len=obj("Hello");
            Console.WriteLine(len);

            Console.Read();
        }
    }
}
