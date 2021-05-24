namespace Opgave23
{
    public class Vak
    {
        public Vak(string naam, string docent, int uren)
        {
            Naam = naam;
            Docent = docent;
            Uren = uren;
        }

        public string Naam { get; set; }
        public string Docent { get; set; }
        public int Uren { get; set; }
    }
}
