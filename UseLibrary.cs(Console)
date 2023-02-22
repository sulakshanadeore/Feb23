using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerLibrary;
namespace DelegatesDemo
{
    class App1
    {
        static void Main(string[] args)
        {
            Cust c = new Cust();
            c.CustID = 1;
            c.CustName = "Anjali";


            Products p = new Products();
            p.Prodid = 1;
            p.Prodname = "Chai";
            p.Price = 10;
            p.CatId = 1;


            Products p1 = new Products();
            p1.Prodid = 2;
            p1.Prodname = "Coffee";
            p1.Price = 20;
            p1.CatId = 1;



            Categories cate = new Categories();
            cate.Catid = 1;
            cate.CatName = "Beverages";
            cate.CatDesc = "tea,coffee,etc";
            List<Products> plist = new List<Products>();
            plist.Add(p);
            plist.Add(p1);
            cate.Prodlist = plist;


            Console.WriteLine(cate.Catid);
            Console.WriteLine(cate.CatName);
            Console.WriteLine(cate.CatDesc);


            foreach (var item in cate.Prodlist)
            {
                Console.WriteLine(item.Prodid);
                Console.WriteLine(item.Prodname);
                Console.WriteLine(item.Price);
            }
            Console.WriteLine("---------------------");


            Categories c2 = new Categories();
            c2.Catid = 2;
            c2.CatName = "Snacks";
            c2.CatDesc = "Some snacks like chips etc";
            c2.Prodlist = new List<Products> 
            {
                new Products {Prodid=3,Prodname="Lays",Price=20 },
                new Products {Prodid=4,Prodname="Kurkure",Price=10 },
                new Products {Prodid=5,Prodname="Bingo",Price=30 } 
            };

            Console.WriteLine(c2.Catid);
            Console.WriteLine(c2.CatName);
            Console.WriteLine(c2.CatDesc);
            foreach (var item in c2.Prodlist)
            {
                Console.WriteLine(item.Prodid);
                Console.WriteLine(item.Prodname);
                Console.WriteLine(item.Price);
            }
            

            Console.Read();






        }
    }
}
