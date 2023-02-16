using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Customers:Products
    {

        public int Custid { get; set; }

        public string? CustCity { get; set; }

        public void AddToCart(string prodname,int qty)
        { 
        
            base.ProductName = prodname;
            base.Qty = qty;
        }

        public void AddToCart(int custid,string prodname,int qty)
        {
            this.Custid = custid;
            base.ProductName= prodname;
           base.Qty = qty;

        }
        public void AddToCart(int custid, string prodname, int qty, string city)
        {
            this.Custid = custid;
           base.ProductName = prodname;
            base.Qty = qty;
            this.CustCity = city;

        }

    }
}
