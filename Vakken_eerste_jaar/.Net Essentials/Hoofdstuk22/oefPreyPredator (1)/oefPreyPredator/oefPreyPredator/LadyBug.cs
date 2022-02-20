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
        //Color kleur = Colors.Red;
        //public int roundsNotEaten;
        private const int StarvingTime = 3;
        private const int MaximumAge = 16;
        private const int CatchDistance = 3;
        private int _roundsNotEaten;
        // public int RoundsNotEaten { get; set; }
        //public LadyBug()
        //{
        //    Random random = new Random();
        //    position.X = random.Next(0, 15);
        //    position.Y = random.Next(0, 15);
        //    Leeftijd = 0;
        //}
        //public LadyBug(int xCoord, int yCoord)
        //{
        //    position.X = xCoord;
        //    position.Y = yCoord;
        //}
        public LadyBug() : base(MaximumAge, Colors.Red) { }

        public LadyBug(Position position) : base(MaximumAge, Colors.Red, position)
        {
            _roundsNotEaten = 0;
        }
        public bool CanEat(IAnimal animal)
        {
            //    if (Distance(animal) < 3)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }

            return animal is Louse;
        }


        public void Hunt(IList<IAnimal> possibleVictims)
        {
            //if (possibleVictims.Count == 0)
            //{
            //    RoundsNotEaten++;
            //    if (roundsNotEaten >= StarvingTime)
            //    {
            //        IsDead = true;
            //    }

            //}
            //else
            //{
            //    RoundsNotEaten = 0;
            //}
            _roundsNotEaten++;
            foreach (IAnimal possibleVictim in possibleVictims)
            {
                if (CanEat(possibleVictim) && Distance(possibleVictim) <= CatchDistance)
                {
                    Eat(possibleVictim);
                }
            }

            if (_roundsNotEaten >= StarvingTime)
            {
                IsDead = true;
            }
        }
        public double Distance(IAnimal prooi)
        {
            //dit klopt niet, ik weet niet hoe ik 2 verschillende punten moet doen Is wel oké
            return Math.Sqrt(Math.Pow(Position.X - prooi.Position.X, 2) + Math.Pow(Position.Y - prooi.Position.X, 2));
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
            if (IsDead) return null;
            if (Leeftijd!=0 && Leeftijd % 4 == 0)
            {
                return new LadyBug(Position);
            }
            return null;
        }

        public void Eat(IAnimal victim)
        {
            _roundsNotEaten = 0;
            victim.IsDead = true;
        }
    }
}


