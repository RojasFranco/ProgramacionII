using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PatenteInvalidaException : Exception
    {
        public PatenteInvalidaException(string message) : this(message, null)
        {
        }

        public PatenteInvalidaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
