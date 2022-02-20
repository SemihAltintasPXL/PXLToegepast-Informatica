using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Threading;

namespace Opdracht_10_8
{
    abstract class Wekker
    {
        private DateTime alarmTijd = DateTime.Now.AddYears(100);
        public DispatcherTimer Timer { get; set; }
        public int Aflooptijd { get; set; } = 10;
        public int AfTeLopenTijd { get; set; }
        public DateTime AlarmTijd { set { alarmTijd = value; } }
        public string HuidigeTijd { get { return DateTime.Now.ToString("HH:mm:ss"); } }
        public static SolidColorBrush ReturnBrush = new SolidColorBrush(Colors.White);
        public static SolidColorBrush redBrush = new SolidColorBrush(Colors.Red);
        public static SolidColorBrush whiteBrush = new SolidColorBrush(Colors.White);

        public Wekker()
        {
            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Start();
        }

        public Boolean CheckOfAlarmAfGaat()
        {
            if (alarmTijd <= DateTime.Now)
            {
                return true;
            }
            return false;
        }

        public SolidColorBrush AlarmGaatAf()
        {
            if (AfTeLopenTijd == 0)
            {
                AfTeLopenTijd = Aflooptijd;
            }
            else
            {
                AfTeLopenTijd--;
                ReturnBrush = AlarmEvent();
                if (AfTeLopenTijd == 0)
                {
                    alarmTijd = DateTime.Now.AddYears(100);
                    ReturnBrush = whiteBrush;
                }
            }
            return ReturnBrush;
        }

        internal abstract SolidColorBrush AlarmEvent();
    }
}
