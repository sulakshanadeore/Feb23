using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Employee
    {
              

        public int Empid { get; set; }
        string _ename;
        public string EName { 
            get 
            {
                return _ename;
            
            } 
            
            
            set {
                if ((value.Length>0) && (!string.IsNullOrEmpty(value)))
                {
                    _ename = value;
                }
                else
                {
                    throw new FormatException("Ename cannot be empty");
                }

            } 
            
        
        }
        public int Deptno { get; set; }


        
        

    }
}
