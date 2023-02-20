using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable]
    public class Employee
    {
        public int Empid { get; set; }

        
               
        public string Empname { get; set; }
        [NonSerialized]
        float _sal;
        public float Empsal { get { return _sal; } set { _sal = value; } }


        private float Salary { get; set; }

    }
    
}
