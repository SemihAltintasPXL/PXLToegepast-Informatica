using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Opdracht_10_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Wekker wekker;
        private Wekker beepWekker = new beepWekker();
        private Wekker knipperWekker = new knipperWekker();

        private SolidColorBrush witBrush = new SolidColorBrush(Colors.White);
        private SolidColorBrush roodBrush = new SolidColorBrush(Colors.Red);

        public MainWindow()
        {
            InitializeComponent();
            wekker = beepWekker;
            wekker.Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            huidigeTijdLabel.Content = Convert.ToString(wekker.HuidigeTijd);
            if (wekker.CheckOfAlarmAfGaat())
            {
                SolidColorBrush brush = wekker.AlarmGaatAf();
                huidigeTijdLabel.Background = brush;
            }
        }

        public Brush ColorLabel
        {
            get { return huidigeTijdLabel.Background; }
            set { huidigeTijdLabel.Background = value; }
        }

        private void alarmTijdButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime alarm = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(alarmTijdTextBox.Text.Substring(0, 2)), Convert.ToInt32(alarmTijdTextBox.Text.Substring(3, 2)), Convert.ToInt32(alarmTijdTextBox.Text.Substring(6, 2)));
            if (beepRadioButton.IsChecked == true)
            {
                wekker = knipperWekker;
                wekker.Timer.Tick -= Timer_Tick;
                wekker = beepWekker;
                wekker.Timer.Tick -= Timer_Tick;
                wekker = beepWekker;
                wekker.Timer.Tick += Timer_Tick;
            }
            else
            {
                wekker = knipperWekker;
                wekker.Timer.Tick -= Timer_Tick;
                wekker = beepWekker;
                wekker.Timer.Tick -= Timer_Tick;
                wekker = knipperWekker;
                wekker.Timer.Tick += Timer_Tick;
            }
            wekker.AlarmTijd = alarm;
        }
    }
}
