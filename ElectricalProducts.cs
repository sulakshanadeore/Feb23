using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
   public sealed class ElectricalProducts:ElectronicsProducts
    {

        public  override double CalculateDiscount(float finalAmt)
        {
            return base.CalculateDiscount(finalAmt);
        }

        public  override double CalculateOfferPrice()
        {
            return Price + (Price * 20);
        }


    }



  //public  class Grocery : ElectricalProducts
  //  {
  //      public override double CalculateDiscount(float finalAmt)
  //      {
  //          return base.CalculateDiscount(finalAmt);
  //      }

  //  }
}
