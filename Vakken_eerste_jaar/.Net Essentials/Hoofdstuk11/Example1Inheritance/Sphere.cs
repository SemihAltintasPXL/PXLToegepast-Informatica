using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;

namespace Example1inheritance
{
    public class Sphere
    {
        protected int _x; // protected = toegankelijk vanuit elke subklasse van deze klasse
        protected int _y ;// geen accessmodifier =  private 
        protected double _radius;
        protected Ellipse _ellipse;

        public Sphere(int x, int y, double radius) // shadowing
        {
            _x = x; _y = y;_radius = radius;
            CreateEllipse();
        }

        public void CreateEllipse()
        {
            _ellipse = new Ellipse()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 2,
                Width = 2 * _radius,
                Height = 2* _radius,
                Margin = new Thickness(_x, _y, 0, 0)
            };
            
        }

        public void DisplayOnCanvas(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(_ellipse);
        }

      // methode figuur 5 pixels naar R, 5 pixels naar B
      public virtual void Move() // virtual => toelating geven om deze methode te overschrijven
        {
            _x += 5; _y += 5;
            _ellipse.Margin = new Thickness(_x, _y, 0, 0);
        }
    }
}
