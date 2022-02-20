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

namespace Example3ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// listbox van Persoon objecten. Vertrekkend van klasse Person uit H22 ExampleList
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> personList;
        public MainWindow()
        {
            InitializeComponent();
            personList = new List<Person>()
            {
                new Person("Mo", "Bouli", "15/5/2010"),
                new Person("Kim", "Persoons", "12/6/1986"),
                new Person("Marc", "VanRanst", "26/9/1965")

            };
            personListBox.ItemsSource = personList; // data binding
            // opgepast voor de visuele voorstelling van deze objecten in de listbox
            // wordt de ToString methode van de klasse Person gebruikt => eventueel overschrijven!!!
        }

        private void personListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Person person = personListBox.SelectedItem as Person;
            MessageBox.Show($"{person} is {person.Age} years old");
            // extra na tonen van MessageBox moet de selectie ongedaan gemaakt worden
            personListBox.SelectedItem = null; // opgepast genereert een selectionchanged event
        }
    }
}
