using System;
using System.Media;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace oefening10._8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Alarm alarm;
        private DispatcherTimer timerClock;
        private SolidColorBrush labelSolidColorBrush;
        public MainWindow()
        { // naamgeving vairavelen beginnend met een kleine letter!!! 
            InitializeComponent();
            alarm = new Alarm();
            timerClock = new DispatcherTimer();
            timerClock.Tick += TimerClock_Tick;
            timerClock.Interval = TimeSpan.FromSeconds(1);
            timerClock.Start();

            labelSolidColorBrush = new SolidColorBrush(Colors.White);
            
            alarm.Duration = 10;
            
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            CurrentLabel.Content = $"{DateTime.Now:T}";      
            if (alarm.IsAlarmTimePassed())
            {
                if (alarm.IsBeepedTimePassed())
                {
                    alarmTextBox.Text = "";
                }
            }
        }

        private void setButton_Click(object sender, RoutedEventArgs e)
        {
            // instellen van de alarmtime
            
            alarm.AlarmTime = Convert.ToDateTime(alarmTextBox.Text);
            
        }
    }
}
