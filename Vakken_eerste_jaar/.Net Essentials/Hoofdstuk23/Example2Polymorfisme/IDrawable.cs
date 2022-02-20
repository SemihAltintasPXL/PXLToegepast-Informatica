using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Example2Polymorfisme
{
    public interface IDrawable : IScaleable
    {
        // abstracte properties
        int X { get; set; }
        int Y { get; set; }
        double Height { get; set; }
        double Width { get; set; }

        // abstracte methode
        void DisplayOnCanvas(Canvas canvas);
        void MoveRight();
        void UpdateShape();
    }
}
