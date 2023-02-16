// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

namespace OOPs // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = null;
            //int? i = null;
            //Nullable<int> j = null;


            //Console.WriteLine(name);


            //Console.WriteLine("Hello World!");

            //Products p = new Products();
            //Console.WriteLine("enter productid");
            //p.Productid = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter productname");
            //p.ProductName = Console.ReadLine();
            ////p.Price = 20;
            //Console.WriteLine("Enter the quantity");
            //p.Qty= Convert.ToInt32(Console.ReadLine()); 
            //if (p.Productid!=0)
            //{
            //    Console.WriteLine(p.Productid);
            //    Console.WriteLine(p.ProductName);
            //    Console.WriteLine(p.Price);
            //    int amt=p.TotalPrice();
            //    Console.WriteLine($"Total Amount={amt}");

            //}
            
            Products p = new Products("Mobiles",2);
            float tot=p.TotalPrice();
            Console.WriteLine("Generated Productid= " + p.Productid);
            Console.WriteLine("Total Price= " +  tot);
            Console.WriteLine("After Discount= " + p.CalculateDiscount(tot));
            Console.WriteLine("---------------------------");
            Products p1 = new Products( "Laptop", 3, "Bengaluru");
            Console.WriteLine("Generated Productid= " + p1.Productid);
            tot = p1.TotalPrice();
            Console.WriteLine("Total Price= " + tot);
            Console.WriteLine("After Discount= " + p1.CalculateDiscount(tot));

            Console.WriteLine("------------------------");
            Products p2 = new Products();
            Console.WriteLine("Generated Productid= " + p2.Productid);
            p2.ProductName = "Others";
            p2.Qty = 10;
            tot = p2.TotalPrice();
            Console.WriteLine("Total Price= " + tot);
            Console.WriteLine("After Discount= " + p2.CalculateDiscount(tot));

            //ElectronicsProducts products = new ElectronicsProducts();
            //products.Productid = 1;
            //products.ProductName= "Mobiles";
            //products.Qty = 2;
            //products.Warranty = 3;
            //products.SerialNo = 01;
            //products.ProductMake = "Apple";
            //float amt=products.TotalPrice();
            //Console.WriteLine("Total Amt=" + amt);



            //double FinalAmt=products.CalculateDiscount(amt);
            //Console.WriteLine("Final Amt after Discount="  +FinalAmt);






            Console.Read();

        }
    }
}
