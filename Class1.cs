using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public class Cust
    {
        private int _custid;

        public int CustID
        {
            get { return _custid; }
            set { _custid = value; }
        }

        private string  _name;
        public  string CustName
        {
            get { return _name; }
            set { _name = value; }
        }

        public void CalculateDiscount()
        { 
        
        
        }

    }
}
