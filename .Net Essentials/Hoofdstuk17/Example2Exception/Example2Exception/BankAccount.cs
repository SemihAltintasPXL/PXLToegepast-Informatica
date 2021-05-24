using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2Exception
{
    public class BankAccount
    {  // Kan je dit ook oplossen zonder de instantievariabele saldo?
        //private int saldo;

        //public int Saldo  => saldo;
        // read only auto property maar saldo moet gewijzigd kunnen worden in de deze klasse
        public int Saldo { get; private set; }

        
        public void Deposit(int amount)
        {// indien meer dan 2500 euro gestort wordt moet er een BankException
            // opgegooid worden
            if (amount > 2500)
            {
                throw new BankException("Deposit is over 2500 euro");
            }
            else
            {
                Saldo += amount;
            }
        }

        public void WithDraw(int amount)
        { // indien het saldo negatief zou worden => BankException opgooien
            if (amount > Saldo)
            {
                throw new BankException("Withdrawal is too large");
            }
            else
            {
                Saldo -= amount;
            }
        }

    }
}
