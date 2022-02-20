using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Example1Polymorfisme
{
    public class Triangle : Shape
    {
        private Polygon _triangle;
        public override double Area => Width * Height /2;
        // aanmaken van de driehoek + op canvas plaatsen
        public override void DisplayOnCanvas(Canvas canvas)
        {
            _triangle = new Polygon()
            {
                Stroke = new SolidColorBrush(Colors.Purple),
                Fill = new SolidColorBrush(Colors.Purple)
            };
            UpdateShape();
            canvas.Children.Add(_triangle);
        }

        public override string ToString()
        {
            return "Triangle" + base.ToString();
        }

        public override void UpdateShape()
        {   if (_triangle != null)
            {
                Point point1 = new Point(X, Y);
                Point point2 = new Point(X, Y + Height);
                Point point3 = new Point(X + Width, Y + Height);
                _triangle.Points.Clear();
                _triangle.Points.Add(point1);
                _triangle.Points.Add(point2);
                _triangle.Points.Add(point3);
            }
        }
    }
}
