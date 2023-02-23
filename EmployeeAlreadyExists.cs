using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{

    [Serializable]
    public class EmployeeAlreadyExistsException : Exception
    {
        public EmployeeAlreadyExistsException() { }
        public EmployeeAlreadyExistsException(string message) : base(message) { }
        public EmployeeAlreadyExistsException(string message, Exception inner) : base(message, inner) { }
        protected EmployeeAlreadyExistsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
