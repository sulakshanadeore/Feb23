using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPs;
namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a, b, c;
            //string s;
            try
            {
                //Console.WriteLine("Enter a");
                //a = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Enter b");
                //b = Convert.ToInt32(Console.ReadLine());
                //c = a / b;
                //Console.WriteLine(c);

                int[][] depts = new int[3][];
                depts[0] = new int[5] { 10, 11, 12, 13, 14 };
                depts[1] = new int[3] { 100, 200, 300 };
                depts[2] = new int[10] { 1000, 2000, 3000 ,4000,5000,6000,7000,8000,9000,10000};
              foreach (var item in depts)
                {
                    foreach (int i in item)
                    {
                        Console.Write(i+ " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("------------------------------");
                Products[] p = new Products[3];
                p[0] = new Products("Chai", 20);
                p[1] = new Products("Coffee", 30);
                p[2] = new Products("Green tea", 50);

                foreach (var item in p)
                {
                    Console.WriteLine(item.Productid);
                    Console.WriteLine(item.ProductName);
                    Console.WriteLine(item.Price);
                     Console.WriteLine(item.TotalPrice());
                }





            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("This is called");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("this is format exception block");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("some other exception occured...");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                //releasing the resources,
                //closing the connections.
                //closing the files etc.
                //disposing objects created
                Console.WriteLine("Finally block executed...");
                Console.WriteLine("Pls visit again");
            }


            Console.ReadKey();
        }
    }
}
