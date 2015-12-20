using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOPExceptionHandling
{
    [Serializable]
    class InvalidDoubleException : Exception
    {

        public InvalidDoubleException() : base()
        {

        }

        public InvalidDoubleException(string message): base(message)
        {
            
        }
        public InvalidDoubleException(string message,Exception innerException) : base(message, innerException)
        {

        }

    }
}
