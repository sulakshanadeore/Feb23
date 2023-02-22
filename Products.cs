using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
  public  class Products
    {
        public int Prodid { get; set; }
        public string Prodname { get; set; }
        public int Price { get; set; }

        public int CatId { get; set; }

    }

   public class Categories
    {
        public int Catid { get; set; }
        public string CatName { get; set; }
        public string CatDesc { get; set; }
        public List<Products> Prodlist { get; set; }

    }
}
