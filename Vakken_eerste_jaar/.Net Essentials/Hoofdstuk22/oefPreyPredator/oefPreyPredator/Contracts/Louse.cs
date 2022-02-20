using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace oefPreyPredator.Contracts
{
    public class Louse : Animal
    {
        private const int MaxLeeftijd = 6;
        private const int BreedingTime = 2;

        public Louse()
        {
            Random random = new Random();
            position.X = random.Next(0, 15);
            position.Y = random.Next(0, 15);
            Leeftijd = 0;
        }
        public Louse(int xCoord, int yCoord)
        {
            position.X = xCoord;
            position.Y = yCoord;
        }
        public Louse(int maxLeeftijd, Color kleur) : base(maxLeeftijd, kleur)
        {
            maxLeeftijd = MaxLeeftijd;
            kleur = Colors.GreenYellow;
        }
        
        public override IAnimal TryBreed()
        {
            
            if (Leeftijd % BreedingTime == 0)
            {
                return new Louse(position.X, position.Y);
            }
            return null;
        }
        
    }
}
