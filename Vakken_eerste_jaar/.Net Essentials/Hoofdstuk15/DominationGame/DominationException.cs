using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominationGame
{
    public class DominationException : Exception
    {
        public DominationException(string mes) : base(mes)
        {
        }
    }
}
