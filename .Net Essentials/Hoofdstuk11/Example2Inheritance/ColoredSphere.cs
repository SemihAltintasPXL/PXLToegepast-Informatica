using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Example2inheritance
{ // van de klasse ColoredSphere mogen subklassen gemaakt kunnen worden
    public sealed class ColoredSphere : Sphere //  : => extends Java seald => final in Java 
    {
        private SolidColorBrush _brush;
        // coloredsphere heeft steeds een straal 20
        public SolidColorBrush Brush // write only property
        {   private get => _brush; // als je de property Brush wil kunnen gebruiken in een andere methode
            set { _brush = value; UpdateEllipse(); }
        }
        public ColoredSphere(int x, int y, SolidColorBrush brush) : base(x, y, 20) // super in Java = oproepen van de constructor uit de superklasse
        {
           Brush = brush; // updateEllipse wordt uitgevoerd
        }

        public override string ToString()
        {
            return  "Colored" +base.ToString();
        }

        private void UpdateEllipse()
        {
            _ellipse.Stroke = Brush; // omwille van private get
            _ellipse.Fill = _brush;
        }
        // methode Move overschrijven=> cirkel beweegt 5 pixels omhoog
        public override void Move()
        {
            Y -= 5; //updateshape wordt uitgevoerd
          
        }
    }
}
