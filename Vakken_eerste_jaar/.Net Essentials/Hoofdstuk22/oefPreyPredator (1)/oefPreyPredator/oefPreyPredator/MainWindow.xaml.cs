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
        //private int aantalLieveheersbeestjes; // moet in het Engels
        //private int aantalLuizen; // moet in het Engels
        
        public MainWindow()
        {
            InitializeComponent();
            _insectWorld = new AnimalWorld(paperCanvas);
            for (int i = 0; i < 100; i++)
            {
                Louse luis = new Louse(); // in het Engels
                _insectWorld.AddAnimal(luis);
            }
            for (int i = 0; i < 10; i++)
            {
                LadyBug lieveheersbeetje = new LadyBug(); // in het Engels
                _insectWorld.AddAnimal(lieveheersbeetje);
            }
          
            DisplayStatistics();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _insectWorld.ProcessRound();
            DisplayStatistics();
        }


        private void DisplayStatistics()
        {
            int aantalLuizen = 0; // moet in het Engels
            int aantalLieveheersbeestjes = 0;
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
