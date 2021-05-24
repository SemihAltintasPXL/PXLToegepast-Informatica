using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Example2Polymorfisme
{
    public class Square : Shape
    {
        private Rectangle _square;
        // als de hoogte wijzigt moet ook de breedte wijzigen
        public override double Height { get => base.Height; set { base.Height = value; base.Width = value; } }
        public override double Width { get => base.Width; set { base.Width = value; base.Height = value; } }
        public override double Area => Width * Width;

        // aanmaken _square gebeurt in onderstaande methode + op canvas plaatsen
        public override void DisplayOnCanvas(Canvas canvas)
        {
            _square = new Rectangle()
            {
                Stroke = new SolidColorBrush(Colors.Blue),
                Fill = new SolidColorBrush(Colors.Blue),
                //Margin = new Thickness(X, Y, 0, 0),
                //Width = this.Width,
                //Height = Height
            };
            UpdateShape(); // vervangt R28-R30
            canvas.Children.Add(_square);
        }

        //public override void Scale(double factor) beter in Shape
        //{
        //    Width *= Math.Sqrt(factor);
        //}

        public override string ToString()
        {
            return "Square" + base.ToString();
        }

        public override void UpdateShape()
        {   if (_square != null)
            {
                _square.Margin = new Thickness(X, Y, 0, 0);
                _square.Width = Width; _square.Height = Height;
            }
        }
    }
}
