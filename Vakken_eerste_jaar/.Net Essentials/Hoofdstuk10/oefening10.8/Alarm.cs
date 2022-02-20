using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Threading;

namespace oefening10._8
{
    class Alarm
    {
        private DateTime alarmTime; //de tijd van de alarm
        private DispatcherTimer timerAlarm; //tikkende klok
        private SolidColorBrush visualColor;

        public DateTime AlarmTime
        {
            get { return alarmTime; }
            set 
            { 
                if (value < DateTime.Now) 
                {
                    alarmTime = value.AddDays(1); 
                }
                else
                {
                    alarmTime = value;
                }
            }
        }
        public int Duration
        {
            get; set;
        }
        public Alarm()
        {
            timerAlarm = new DispatcherTimer();
            timerAlarm.Tick += TimerAlarm_Tick;
            alarmTime = DateTime.MaxValue;
            visualColor = new SolidColorBrush(Colors.White);
        }

        private void TimerAlarm_Tick(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            visualColor = new SolidColorBrush(Colors.Red);
        }

        public bool IsAlarmTimePassed()
        {
            if (DateTime.Now > alarmTime)
            {
                timerAlarm.Start();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsBeepedTimePassed()
        {
            DateTime endTime = AlarmTime.AddSeconds(Duration);
            if (DateTime.Now > endTime)
            {
                timerAlarm.Stop();
                Reset();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            alarmTime = DateTime.MaxValue;
            visualColor = new SolidColorBrush(Colors.White);
        }
    }
}
