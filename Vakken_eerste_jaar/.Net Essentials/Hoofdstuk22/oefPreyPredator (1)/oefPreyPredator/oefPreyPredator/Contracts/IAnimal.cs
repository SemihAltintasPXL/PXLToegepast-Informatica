using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefPreyPredator.Contracts
{
    public interface IAnimal:IDisplayable
    {
        Position Position { get; }
        bool IsDead { get; set; }
        void Move();/*  hier mag geen code staan is een abstracte methode
        {
            
            Random random = new Random();
            int keuze = random.Next(1, 4);
            //gaat ook met een if
            switch (keuze)
            {
                case 1:
                    position.MoveForward();
                    break;
                case 2:
                    position.MoveBack();
                    break;
                case 3:
                    position.MoveLeft();
                    break;
                case 4:
                    position.MoveRight();
                    break;
            
            }
            
        }
            */
        IAnimal TryBreed(); // hier mag ook geen code staan
            /*
        {
            //een nieuwgeboren dier terug geven
            if (!IsDead)
            {
                //return new IAnimal(); dit gaat niet
            }
            return null;
        }
            */
    }
}
