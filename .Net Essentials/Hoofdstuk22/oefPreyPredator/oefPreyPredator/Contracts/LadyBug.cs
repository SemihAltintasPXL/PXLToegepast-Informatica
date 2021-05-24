using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace oefPreyPredator.Contracts
{
    class LadyBug : Animal, IPredator
    {
        public int roundsNotEaten;
        public int StarvingTime = 3;
        Color kleur;


        public int RoundsNotEaten { get; set; }
        public LadyBug()
        {
            Random random = new Random();
            position.X = random.Next(0, 15);
            position.Y = random.Next(0, 15);
            Leeftijd = 0;
            kleur = Colors.Red;
        }
        public LadyBug(int xCoord, int yCoord)
        {
            position.X = xCoord;
            position.Y = yCoord;
        }
        public bool CanEat(IAnimal animal)
        {
            if (Distance(animal) < 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Hunt(IList<IAnimal> possibleVictims)
        {
            if (possibleVictims.Count == 0)
            {
                RoundsNotEaten++;
                if (roundsNotEaten >= StarvingTime)
                {
                    IsDead = true;
                }

            }
            else
            {
                RoundsNotEaten = 0;
            }
        }
        public double Distance(IAnimal prooi)
        {
            //dit klopt niet, ik weet niet hoe ik 2 verschillende punten moet doen
            return Math.Sqrt(Math.Pow(position.X - prooi.position.X, 2) + Math.Pow(position.Y - prooi.position.X, 2));
        }
        //public IAnimal Breed()
        //{
        //    if (Leeftijd % 4 == 0)
        //    {
        //        return new LadyBug(position.X, position.Y);
        //    }
        //    return null;
        //}

        public override IAnimal TryBreed()
        {
            if (Leeftijd % 4 == 0)
            {
                return new LadyBug(position.X, position.Y);
            }
            return null;
        }
    }
}
   

