using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Opdracht_10_8
{
    class beepWekker : Wekker
    {
        internal override SolidColorBrush AlarmEvent()
        {
            SystemSounds.Beep.Play();
            return Wekker.whiteBrush;
        }
    }
}
