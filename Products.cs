using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Products
    {
        static int cnt;
        static Products()
        {
            cnt = 0;
            Console.WriteLine("Thsi is called only once in the lifetime of the class, before any other constructor gets called... I m used for initializations");
        }


        public Products()
        {
            cnt += 1;
            this.Productid = cnt;
            Console.WriteLine("Default Constructor");
        }

        public Products(string pname,int p_qty)
        {
            cnt += 1;
            this.Productid = cnt;
            //this.Productid = pid;
            this.ProductName = pname;
            this.Qty = p_qty;
        }
        public Products(string pname,int p_qty,string city):this(pname,p_qty)
        {
            
            
            this.City = city;
        }
        string _city;
        public string City
        { get { return _city; } set { _city = value; } }


        int prodid;//variable
        public int Productid//property
        {
            //Accept value from user & assign to variable
            set
            {


                prodid = value;
                //if (value > 0)
                //{
                //    prodid = value;
                //}
                //else
                //{
                //    Console.WriteLine("Invalid product id...");
                //}
            }

            
            get { return prodid; }//return the value to the user

        
        }


        private string prodname;

        public string ProductName
        {
            get { return prodname; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {

                    prodname = value;

                    if (prodname == "Chai")
                    {
                        _price = 10;
                    }
                    else if (prodname == "Coffee")
                    {
                        _price = 20;
                    }
                    else
                    {

                        _price = 30;

                    }
                }
                else
                {
                    Console.WriteLine("Not a valid product");
                }
            }
        }


        //Read only property
        int _price;
        public int Price
        {

            get {
            
                return _price; 
            }
        }

        int _qty;
        public int Qty
        {
            set { _qty = value; }
        
        }

        public float TotalPrice()
        {
            Console.WriteLine($"U ordered {_qty} at the price of Rs. {_price} so following is your amt");
            return _price * _qty;
        
        }

        public virtual double CalculateDiscount(float finalAmt)
        {
            double DiscountedAmt;
            if ((finalAmt > 200000) && (finalAmt < 300000))
            {
                DiscountedAmt = finalAmt - (finalAmt * .01);
            }
            else if (finalAmt <= 200000)
            {

                DiscountedAmt = finalAmt;
            }
            else
            {
                DiscountedAmt = finalAmt - (finalAmt * .02);
            }
            return DiscountedAmt;

        
        
        }
        


    }
}
