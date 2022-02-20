using oefPreyPredator.Contracts;
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

namespace oefPreyPredator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IAnimalWorld _insectWorld;
        //private Canvas canvas; 
        private int aantalLieveheersbeestjes;
        private int aantalLuizen;
        
        public MainWindow()
        {
            for (int i = 0; i < 100; i++)
            {
                Louse luis = new Louse();
                _insectWorld.AddAnimal(luis);
            }
            for (int i = 0; i < 10; i++)
            {
                LadyBug lieveheersbeetje = new LadyBug();
                _insectWorld.AddAnimal(lieveheersbeetje);
            }
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _insectWorld.ProcessRound();
            DisplayStatistics();
        }


        private void DisplayStatistics()
        {
            foreach (Animal dier in _insectWorld.AllAnimals)
            {
                if (dier is Louse)
                {
                    aantalLuizen++;
                }
                else
                {
                    aantalLieveheersbeestjes++;
                }

                louseTextBlock.Text = Convert.ToString(aantalLuizen);
                ladybugTextBlock.Text = Convert.ToString(aantalLieveheersbeestjes);
                roundTextBlock.Text = Convert.ToString(_insectWorld.CurrentRoundNumber);

            }
        }
    }
}
