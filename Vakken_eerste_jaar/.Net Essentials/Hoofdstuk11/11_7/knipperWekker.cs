using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Opdracht_10_8
{
    class knipperWekker : Wekker
    {
        internal override SolidColorBrush AlarmEvent()
        {
            if (AfTeLopenTijd % 2 == 0)
            {
                return Wekker.redBrush;
            } else
            {
                return Wekker.whiteBrush;
            }
        }
    }
}
