using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefPreyPredator.Contracts
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            //ik weet niet of die random percee moet
            Random random = new Random();
            x = random.Next(0, 15);
            y = random.Next(0, 15);
            X = x;
            Y = y;
        }
        
        public void MoveForward()
        {
            Y += 1;
            if (Y > 15)
            {
                Y = Y - 2;
            }
        }
        public void MoveBack()
        {
            Y -= 1;
            if (Y < 0)
            {
                Y = Y + 2;
            }
        }

        public void MoveLeft()
        {
            X -= 1;
            if (X < 0)
            {
                X = X + 2;
            }
        }
        public void MoveRight()
        {
            X += 1;
            if (X > 15)
            {
                X = X - 2;
            }
        }
        
        
    }
}
