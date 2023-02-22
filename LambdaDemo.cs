using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    //public delegate int d1(string s); //length

    //public delegate void PrintData(string s);
    class LambdaDemo
    {
        static void Main(string[] args)
        {

            List<Orders> orderlist = new List<Orders>();
            orderlist.Add(new Orders { Orderid=1,OrderDate=new DateTime(2023,01,11),ItemName="Mobiles",Qty=10,Brand="Apple"});

            orderlist.Add(new Orders { Orderid = 2, OrderDate = new DateTime(2023, 01, 01), ItemName = "Laptops", Qty = 1,Brand="Apple"});

            orderlist.Add(new Orders { Orderid = 3, OrderDate = new DateTime(2023, 01, 13), ItemName = "Mouse", Qty = 20,Brand="Samsung" });

            orderlist.Add(new Orders { Orderid = 4, OrderDate = new DateTime(2023, 01, 15), ItemName = "Harddisk", Qty =20,Brand = "Seagate" });

            orderlist.Add(new Orders { Orderid = 5, OrderDate = new DateTime(2023, 01, 14), ItemName = "Keyboard", Qty = 15,Brand = "HP" });


            orderlist.Add(new Orders { Orderid = 6, OrderDate = new DateTime(2023, 01, 14), ItemName = "Keyboard", Qty = 15, Brand = "HP" });



            var dateWiseOrders =orderlist.OrderByDescending(o => o.OrderDate);
            Console.WriteLine("{0,-10}{1,-25}{2,-35}{3,-70}", "ORDERID", "ORDERDATE", "ITEMNAME", "QTY");
            foreach (var item in dateWiseOrders)
            {
                Console.WriteLine("{0,-10}{1,-25}{2,-35}{3,-70}",item.Orderid,item.OrderDate,item.ItemName,item.Qty);
            }

            Console.WriteLine("-------------------------------------");

            int maxqty=orderlist.Max(o => o.Qty);
           var data= orderlist.Where(o => o.Qty == maxqty);
            foreach (var item in data)
            {
                Console.WriteLine(item.Orderid + " " + item.OrderDate + " " + item.ItemName + "  " + item.Qty);
                
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Enter brand for search");
            string b = Console.ReadLine().Trim();

            var ordersBrand=orderlist.Where(o => o.Brand == b);
            foreach (var item in ordersBrand)
            {
                Console.WriteLine(item.Orderid + " " + item.OrderDate + " " + item.ItemName + "  " + item.Qty);
            }



            //Action 
            //PrintData pd = s => {
            //    Console.WriteLine(s);
            //};
            //pd("Bangalore");

            ////Func
            //DoCalculations dc = (p1, p2) =>
            //{
            //    int addans = p1 + p2;
            //    Console.WriteLine(addans);
            //    if (p2 > 0)
            //    {
            //        int subans = p1 - p2;
            //        Console.WriteLine(subans);

            //        int divans = p1 / p2;
            //        Console.WriteLine(divans);

            //    }
            //    int multi = p1 * p2;
            //    return multi;

            //};

            //int mans=dc(20, 2);
            //Console.WriteLine(mans);


            //d1 obj = s => {
            //    Console.WriteLine("The length of the string {s} =" + s.Length);
            //    Console.WriteLine(s);
            //    s = s.Replace("e", "aa");
            //    Console.WriteLine(s);
            //    return s.Length + 1;

            //};

            //obj("Welcome");
            Console.ReadLine();


        }
    }
}
