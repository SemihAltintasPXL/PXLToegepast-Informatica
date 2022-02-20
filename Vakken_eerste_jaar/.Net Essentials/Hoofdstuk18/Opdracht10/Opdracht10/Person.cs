using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht10
{// maak een klasse Person met properties Name, FirstName, Birthday(DateTime)
 // voorzie een constructor met parameters name, firstname, birthday(string)
 // voorzie een property age
    public class Person
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }

        public int Age => ComputeAge(); // read only property

        public Person( string firstname, string name, string birthDay)
        {
            Name = name; FirstName = firstname; BirthDay = DateTime.Parse(birthDay);
        }

        public Person(string firstname, string name) // om te kunnen zoeken op bais van naam en voornaam
        {
            Name = name; FirstName = firstname; 
        }

        public override string ToString()
        {
            return FirstName + " " + Name;
        }

        private int ComputeAge()
        {
            // TimeSpan timeSpan = DateTime.Now - BirthDay;
            // voorgaande niet oké omdat timeSpan niet kan uitgedrukt worden in jaren
            int age = DateTime.Now.Year - BirthDay.Year;
            // nagaan of persoon nog niet verjaard is => age
            if (BirthDay.AddYears(age) > DateTime.Now)
            {
                age--;
            }
            return age;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Name == person.Name &&
                   FirstName == person.FirstName;
        }

        public override int GetHashCode()
        {
            int hashCode = 771303728;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            return hashCode;
        }
    }
}
