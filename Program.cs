using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList(2);
            a.Add(1);
            a.Add("Hello");
              a.Add(344.33f);
            a.Add(true);
            a.Add(false);
            a.Add(new DateTime(2023, 02, 21, 11, 31, 10));
            Console.WriteLine("All elements");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("after adding");
            //a.Add("I am added now");
            //  a.Insert(1, "I am added now");

            ArrayList a1 = new ArrayList();
            a1.Add(100);
            a1.Add(200);
            a1.Add(300);

            a.InsertRange(1, a1);

            //Console.WriteLine("After remvoing");

            //a.Remove("Hello");
            // a.RemoveAt(1);
            //a.RemoveRange(1, 3);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            //a.RemoveAt(2);
            //a.Insert(2, "welcome");

            //a.RemoveRange(2, 3);



            Console.Read();
        }
    }
}
