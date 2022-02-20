using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    public class Persoon
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Geslacht { get; set; }
        public string Adres { get; set; }
        public string Telefoon { get; set; }
        public DateTime Geboortedatum { get; set; }

        public override string ToString()
        {
            return Voornaam + " " + Naam;
        }
    }
}
