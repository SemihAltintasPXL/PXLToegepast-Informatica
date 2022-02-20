using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Example1inheritance
{
    public class ColoredSphere : Sphere // extends Java
    {
        private SolidColorBrush _brush;
        // coloredsphere heeft steeds een straal 20
        public SolidColorBrush Brush // write only property
        {   private get => _brush; // als je de property Brush wil kunnen gebruiken in een andere methode
            set { _brush = value; UpdateEllipse(); }
        }
        public ColoredSphere(int x, int y, SolidColorBrush brush) : base(x, y, 20) // super in Java = oproepen van de constructor uit de superklasse
        {
            //_brush = brush;
            //_ellipse.Stroke = _brush;
            //_ellipse.Fill = _brush;
            Brush = brush; // updateEllipse wordt uitgevoerd
        }

        private void UpdateEllipse()
        {
            _ellipse.Stroke = Brush; // omwille van private get
            _ellipse.Fill = _brush;
        }
        // methode Move overschrijven=> cirkel beweegt 5 pixels omhoog
        public override void Move()
        {
            _y -= 5;
            _ellipse.Margin = new System.Windows.Thickness(_x, _y, 0, 0);
        }
    }
}
