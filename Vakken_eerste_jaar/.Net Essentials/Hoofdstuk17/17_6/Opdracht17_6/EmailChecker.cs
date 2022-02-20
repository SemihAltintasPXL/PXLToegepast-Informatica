using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht17_6
{
    class EmailChecker
    {
        public void CheckAddress(string email)
        {
            if (email.Contains("@"))
            {
                // other validation code
            }
            else
            {
                throw new InvalidEmailException(email + " does not contain @-sign!");
            }
        }
    }
}
