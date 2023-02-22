using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManipulations sm = new StringManipulations();
            d1 delobj = new d1(sm.StringLength);//create dele obj and point it to the method
           //int len= delobj("Hello");//Calling/Invoking the delegate
            int len=delobj.Invoke("Hello");

            Console.WriteLine(len);
            Console.WriteLine("---------------");
            d2 delobj2 = new d2(sm.ConcatStrings);
            delobj2("Welcome", " to", " .NET");

            d3 delobj3 = new d3(sm.ConvertToUpper);
            string s1=delobj3("deloitte");
            Console.WriteLine(s1);

            Console.WriteLine("=====================");
            
            StringFuns[] delmulti = new StringFuns[2] { sm.ConvertToUpperCase, sm.ConvertToLowerCase };

            
       StringFuns myobj =(StringFuns)Delegate.Combine(delmulti);
            myobj("hello all");


            Console.WriteLine("==========================");

            StringFuns f1 = new StringFuns(sm.ConvertToUpperCase);
            StringFuns f2 = new StringFuns(sm.ConvertToLowerCase);

            StringFuns sf1=(StringFuns)Delegate.Combine(f2, f1);
            sf1.Invoke("ABCabc");

            Console.WriteLine("-----------------------");










            Console.ReadKey();
        }
    }
}
