using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
  public  class ElectronicsProducts : Products
    {
		public ElectronicsProducts()
		{
			Console.WriteLine("Default Constructor of Electronics Products");
		}

		private int _srno;

		public int SerialNo
		{
			get { return _srno; }
			set { _srno = value; }
		}

		private string? _prodmake;

		public string? ProductMake
		{
			get { return _prodmake; }
			set { _prodmake = value; }
		}

		private int _warranty;

		public int Warranty
		{
			get { return _warranty; }
			set { _warranty = value; }
		}

		//public double TotalPriceOfProduct()
		//{
		//	int amt=base.TotalPrice();
		//	//int oAmt = amt;
		//	double tax=amt-(amt * 0.5);
		//	double FinalAmt=amt - tax;
		//	return FinalAmt;
		//}

        public new float TotalPrice()
        {
            float amt = base.TotalPrice();
			//int oAmt = amt;
			
			float FinalAmt = (float)(amt + (amt * 0.05));
            //double FinalAmt = amt - tax;
            return FinalAmt;
        }

		public override double CalculateDiscount(float finalAmt)
		{
            double DiscountedAmt;
            if ((finalAmt > 200000) && (finalAmt < 300000))
            {
                DiscountedAmt = finalAmt - (finalAmt * .10);
            }
            else if (finalAmt <= 200000)
            {

                DiscountedAmt = finalAmt - (finalAmt * .05);
            }
            else
            {
                DiscountedAmt = finalAmt - (finalAmt * .20);
            }
            return DiscountedAmt;

        }

		public virtual double CalculateOfferPrice()
		{
			return Price + (Price * 10);
		}


    }
}
