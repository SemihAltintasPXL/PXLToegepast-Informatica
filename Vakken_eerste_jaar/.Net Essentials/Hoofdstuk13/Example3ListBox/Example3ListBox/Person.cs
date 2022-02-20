using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3ListBox
{// Maak een klasse Person aan met als properties Name, Firstname en BirthDay(DateTime)
    // voorzie een constructor met 3 parameters firstnaam, name, birthDay(string)
    // voorzie de property Age
    public class Person
    {
        public string FirstName { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }

        public int Age => ComputeAge(); // read only property
        public Person(string firstname, string name, string birthday)
        {
            FirstName = firstname; Name = name; BirthDay = DateTime.Parse(birthday);
        }
        public Person(string firstname, string name) // om gemakkelijk personen in de lijst op te zoeken zie opgave
        {
            FirstName = firstname; Name = name;
        }

        public override string ToString()
        {
            return FirstName + " " + Name;
        }

        private int ComputeAge()
        {
            //TimeSpan timeSpan = DateTime.Today - BirthDay;
            // voorgaande kanniet uitgedrukt worden in jaren wel bvb in dagen timeSpan.TotalDays()
            
            int age = DateTime.Today.Year - BirthDay.Year;
            // indien nog niet verjaard bovenstaande -1
            if (BirthDay.AddYears(age) > DateTime.Today)
            {
                age--;

            }
            return age;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   FirstName == person.FirstName &&
                   Name == person.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = -902933168;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
