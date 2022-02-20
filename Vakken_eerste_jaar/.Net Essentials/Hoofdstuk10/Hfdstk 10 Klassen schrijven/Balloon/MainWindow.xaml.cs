using System;
using System.Collections.Generic;
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

namespace BalloonApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Balloon balloon1;
        private Balloon balloon2;
        
        public MainWindow()
        {
            InitializeComponent();

            balloon1 = new Balloon();
            // wijzig de y coördinaat in 80, diameter naar 20
            balloon1.Y = 80; balloon1.Diameter = 20;
            //balloon1.Name = "eerste ballon";
            // kleur wijzigen met een methode
            balloon1.ChangeColor(Colors.PapayaWhip);
            // kleur wijzigen met een property
            balloon1.Color = Colors.Aquamarine;
            // 2de balloon x=150, y =20 en diameter =60
            balloon2 = new Balloon(150, 20, 60);
            UpdateTextBlock();
            balloon1.DisplayOn(drawingCanvas);
            balloon2.DisplayOn(drawingCanvas);
        }

        private void UpdateTextBlock()
        {   // probleem tekst wordt niet volledig getoond in de textblock
            // oplossing textbox gebruiken met VerticalScrollBar
            outputTextBox.Text = $"De ballon ({balloon1.Name}) bevindt zich op positie ({balloon1.X}," +
                           $"{balloon1.Y}) met een oppervlakte van {balloon1.Area:F2} \n + " +
                           $"De ballon ({balloon2.Name}) bevindt zich op positie ({balloon2.X}," +
                           $"{balloon2.Y}) met een oppervlakte van {balloon2.Area:F2}";
        }
        private void moveButton_Click(object sender, RoutedEventArgs e)
        {
            balloon1.MoveRight(20);
            // balloon2 beweegt 10 pixels naar links
            balloon2.MoveRight(-10);
            UpdateTextBlock();
        }

        private void growButton_Click(object sender, RoutedEventArgs e)
        {
            balloon1.ChangeSize(20);
            UpdateTextBlock(); 
        }

        private void countButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"De methode MovRight werd {Balloon.CountMoveRight} keer opgeroepen");
        }
    }
}
