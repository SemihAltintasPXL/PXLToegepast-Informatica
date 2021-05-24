using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht17_6
{
    public class InvalidEmailException : ApplicationException
    {
        public InvalidEmailException(string message) : base(message)
        {
        }
    }
}
