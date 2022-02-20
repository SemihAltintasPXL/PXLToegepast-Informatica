using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef10_3
{
    public class BankAccount
    {  // Kan je dit ook oplossen zonder de instantievariabele saldo?
        //private int saldo;

        //public int Saldo  => saldo;
        // read only auto property maar saldo moet gewijzigd kunnen worden in de deze klasse
        public int Saldo { get; private set; }

        
        public void Deposit(int amount)
        {
            //saldo += amount;
            Saldo += amount;
        }

        public void WithDraw(int amount)
        {
            Saldo -= amount;
        }

    }
}
