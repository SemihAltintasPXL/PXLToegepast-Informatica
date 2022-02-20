using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Example2Polymorfisme
{
    public abstract class Shape : IDrawable
    {
        private int _x;
        private int _y;
        private double _height;
        private double _width;
        public int X { get => _x; set { _x = value; UpdateShape(); } }
        public int Y { get { return _y; } set { _y = value; UpdateShape(); } }
        // Height en Width moet overschreven kunnen worden => virtual
        public virtual double Height { get => _height; set { _height = value; UpdateShape(); } }
        public virtual double Width { get => _width; set { _width = value; UpdateShape(); } }
        // abstract property read only
        public abstract double Area { get; }

        public override string ToString()
        {
            return $"({X}, {Y}, {Height:F0}, {Width:F0}) area {Area:F2}";
        }

        // abstract methode
        public abstract void UpdateShape();
        public abstract void DisplayOnCanvas(Canvas canvas);
        // methode om figuur 5 posities naar R te verplaatsen
        public void MoveRight()
        {
           X += 5; // UpdateShpae wordt uitgevoerd (zie code property)
        }

        public void Scale(double factor)
        {
            Width *= Math.Sqrt(factor);
            Height *= Math.Sqrt(factor);
        }

        // public abstract void Scale(double factor);
    }
}
