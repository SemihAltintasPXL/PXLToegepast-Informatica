using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

namespace ExampleTimeDate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("open eerst de output window");
            ExercisesDateTime();
        }

        private void ExercisesDateTime()
        {
            // klase DateTime: een datum zonder tijd of een een datum met tijd
            // alleen datum (eigenlijk een datum met tijd op 0:0:0
            DateTime day1 = DateTime.Today;
            DateTime day2 = new DateTime(1999, 5, 27);
            DateTime day3 = Convert.ToDateTime("27/5/1999");
            DateTime day4 = DateTime.Parse("17/12/20");
            DateTime day5 = day3.AddDays(1);

            // datum + tijd
            DateTime dayTime1 = DateTime.Now;
            DateTime dayTime2 = new DateTime(2000, 6, 19, 12, 5, 16);
            DateTime dayTime3 = Convert.ToDateTime("19/6/2000 12:5:06");
            DateTime dayTime4 = DateTime.Parse("20/5/19 15:5:06");
            DateTime dayTime5 = DateTime.Parse("12:05:45"); // vandaag wordt als datum gebruikt

            // afdrukken 5/05/1996 9:05:03
            Console.WriteLine(day4); 
            Console.WriteLine(dayTime5);
            // alleen de datum vrijdag 7 mei 1999
            Console.WriteLine(day2.ToLongDateString());
            Console.WriteLine($"{day3:dddd dd MMMM yyyy}");
            Console.WriteLine($"{day4:D}");
            // alleen de tijd  
            Console.WriteLine($"{dayTime2:T}"); //5:16:06
            Console.WriteLine($"{dayTime3:t}"); // 5:16
            Console.WriteLine($"{dayTime4:hh:mm:ss}"); //05:16:06
            // datum en tijd 19/3/20 8:5:6
            Console.WriteLine($"{dayTime5:dd/M/yy h:m:s}");

            // dag oproepen van day4 => moet een int om eventueel mee te rekenen
            Console.WriteLine(day4.Day);
            // dag in het Engels
            Console.WriteLine(day4.DayOfWeek);
            // dag in het Nederlands
            Console.WriteLine($"{day4:dddd}");

            // rekenen met DateTime
            Console.WriteLine($"DayTime2 before day2? {dayTime2 < day2}");
            TimeSpan timeSpan = dayTime2 - day2;
            // aantal dagen
            Console.WriteLine(timeSpan.Days);
            Console.WriteLine(timeSpan.TotalDays);
            // aantal uren
            Console.WriteLine(timeSpan.Hours);
            Console.WriteLine(timeSpan.TotalHours); // vergelijkbaar met ChronoUnit in Java ganse tijdsduur uitgedrukt in uren
            // van timeSpan kan je dagen, uren minuten seconden .. maar geen jaren!!!

            // klasse TimeSpan: een tijdstip of een tijdsduur
            TimeSpan time1 = TimeSpan.Parse("12:5:09");
            TimeSpan time2 = new TimeSpan(12, 10, 56);
            TimeSpan time3 = TimeSpan.FromSeconds(1); // tijdsduur van 1 seconde
            // Convert.ToTimeSpan bestaat niet !!!
            // rekenen met een TimeSpan
            TimeSpan time = time2.Subtract(time1);
            Console.WriteLine(time);
            // alleen de seconden
            Console.WriteLine(time.Seconds); // hiermee kan je rekenen
            Console.WriteLine($"{time:ss}"); //steeds ss niet s
            // ganse tijd 
            Console.WriteLine($"{time:T}");
            Console.WriteLine($"{time:hh\\:mm\\:ss}");

            // tijd opmeten
            DateTime before = DateTime.Now;
            DateTime after = DateTime.Now;
            TimeSpan duration = after - before;
            Console.WriteLine(duration.TotalMilliseconds); // deze  oplossing werkt niet nauwkeurig

            // alternatief maar nauwkeuriger
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            TimeSpan duration2 = stopwatch.Elapsed;
            Console.WriteLine(duration2.TotalMilliseconds);

        }
    }
}
