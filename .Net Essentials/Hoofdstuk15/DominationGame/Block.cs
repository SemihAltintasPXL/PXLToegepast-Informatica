using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DominationGame
{
    public class Block
    {
        private Player _owner = Player.none;
        private Rectangle _rectangle;

        public Player Owner { get => _owner; set { _owner = value;
                if (Owner == Player.red)
                {
                    _rectangle.Fill = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    _rectangle.Fill = new SolidColorBrush(Colors.Blue);
                }
            } 
        }

        public Block(int rowIndex, int columIndex, double sizeBlock)
        {
            _rectangle = new Rectangle()
            {
                Width = sizeBlock,
                Height = sizeBlock,
                //mevrouw, hoe moet je de margin berekenen? Ja maar de 10 die je hier gebruikt is ook een variabele (de constante Margin in de powerpoint)
                Margin = new System.Windows.Thickness(sizeBlock * columIndex + (10),sizeBlock * rowIndex + 10, 0, 0),
                Fill = new SolidColorBrush(Colors.White),
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 1
        };
        }

        public void DisplayOn(Canvas canvas)
        {
            canvas.Children.Add(_rectangle);
        }

        public bool IsEmpty()
        {
            //if (Owner == Player.none)
            //{
            //    return true;
            //}
            //return false;
            return Owner == Player.none;
        }

    }
}
