using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using System;

namespace Example2inheritance
{
    public class Sphere : Shape
    {
       
        protected Ellipse _ellipse;
        // als de hoogte wijzigt moet ook de breedte wijzigen
        public override double Height { get => base.Height; set { base.Height = value; base.Width = value; } }
        public override double Width { get => base.Width; set { base.Width = value; base.Height = value; } }

        public Sphere(int x, int y, double radius) 
        {
            CreateEllipse(); // als eerste om problemen met Updateshape te vermijden
            X = x; Y = y;Width = 2 *radius; // Height wordt automatisch aangepast
           
        }

        public override string ToString()
        {
            return "Sphere" + base.ToString();
        }

        public override double Area => Math.PI * (Width /2) *(Width/2);

        public void CreateEllipse()
        {
            _ellipse = new Ellipse()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 2,
                //Width = this.Width,   overbodig in constructor wordt met X=x de methode updateshape uitgevoerd
                //Height = Width,
                //Margin = new Thickness(X, Y, 0, 0)
            };
            
        }

        public override void DisplayOnCanvas(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(_ellipse);
        }

       

        // methode figuur 5 pixels naar R, 5 pixels naar B
        public virtual void Move() // virtual => toelating geven om deze methode te overschrijven
        {
            X += 5; Y += 5; // updateshape wordt uitgevoerd
            // _ellipse.Margin = new Thickness(X, Y, 0, 0); overbodig 
        }

        public override void UpdateShape()
        {
            _ellipse.Margin = new Thickness(X, Y, 0, 0);
            _ellipse.Width = Width; _ellipse.Height = Height;
        }
    }
}
