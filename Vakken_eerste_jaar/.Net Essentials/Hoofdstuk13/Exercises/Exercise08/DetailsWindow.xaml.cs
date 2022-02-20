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
using System.Windows.Shapes;

namespace Exercise08
{
    /// <summary>
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        Persoon persoon;

        public DetailsWindow()
        {
            InitializeComponent();

          
        }

        public void plaatsGegevens(Persoon persoon)
        {
            this.persoon = persoon;

            naamTextBox.Text = persoon.Naam;
            voornaamTextBox.Text = persoon.Voornaam;
            geslachtTextBox.Text = persoon.Geslacht;
            adresTextBox.Text = persoon.Adres;
            telefoonTextBox.Text = persoon.Telefoon;
            geboortedatumTextBox.Text = persoon.Geboortedatum.Day + "/" + persoon.Geboortedatum.Month + "/" + persoon.Geboortedatum.Year;
            

        }



        private void bewarenButton_Click(object sender, RoutedEventArgs e)
        {
            persoon.Naam = naamTextBox.Text;
            persoon.Voornaam = voornaamTextBox.Text;
            persoon.Geslacht = geslachtTextBox.Text;
            persoon.Adres = adresTextBox.Text;
            persoon.Telefoon = telefoonTextBox.Text;
            try
            {
                persoon.Geboortedatum = new DateTime(Convert.ToInt32(geboortedatumTextBox.Text.Substring(6, 4)),
                    Convert.ToInt32(geboortedatumTextBox.Text.Substring(3, 2)),
                    Convert.ToInt32(geboortedatumTextBox.Text.Substring(0, 2)));
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            this.Close();
        }
    }
}
