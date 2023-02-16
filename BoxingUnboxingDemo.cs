using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class BoxingUnboxingDemo
    {
        static void Main(string[] args)
        {
            int i = 100;
            //int j;
            //j = i;

            object j;
            j=i;//Boxing

            int k;
            k =(int) j;//Casting used to achieve unboxing




        }
    }
}
