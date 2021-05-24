using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefPreyPredator.Contracts
{
    public class Position
    {
        private int _x;
        public int X
        {
            get => _x; set { if (value < 0) { _x = 0; } else if (value > 15) { _x = 15; } else { _x = value; } }
        }
        public int Y { get; set; } // identiek aan de X property 

        public Position(int x, int y)
        {
            //ik weet niet of die random percee moet => nee
            //Random random = new Random();
            //x = random.Next(0, 15);
            //y = random.Next(0, 15);
            X = x;
            Y = y;
        }

        public void MoveForward()
        {
            Y += 1;
            //if (Y > 15) controle moet in de property
            //{
            //    Y = Y - 2;
            //}
        }
        public void MoveBack()
        {
            Y -= 1;
            //if (Y < 0) controle moet in de property
            //{
            //    Y = Y + 2;
            //}
        }

        public void MoveLeft()
        {
            X -= 1;
            //if (X < 0) controle in de property
            //{
            //    X = X + 2;
            //}
        }
        public void MoveRight()
        {
            X += 1;
            //if (X > 15) controle in de property
            //{
            //    X = X - 2;
            //}
        }


    }
}
