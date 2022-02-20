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

namespace Opdracht10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<Person>() { new Person("Bart", "Peeters", "18/5/1963"),
                new Person("James", "Coock", "12/8/1982"),
            new Person("Tristan", "Franssen", "14/9/2001")};
            personListBox.ItemsSource = list; // data binding
                                              // !!! voor de juiste visuele voorstelling ToString methode in de klasse Person overschrijven
        }

        private void personListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int index = personListBox.SelectedIndex;
            MessageBox.Show($"{list[index]} is {list[index].Age} years old");
            //extra selectie ongedaan maken als MessageBox getoond wordt
            personListBox.SelectedItem = null; // opgepast als je een eventhandler hebt voor selectionchanged
        }
        // klikken geselecteerde al dan niet verwijderen
        private void personListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (personListBox.SelectedIndex != -1)
            {
                Person person = list[personListBox.SelectedIndex];
                if (MessageBox.Show("Do you want to delete this person?", person.ToString(), MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
                {
                    list.Remove(person);
                    personListBox.Items.Refresh();
                }
            }
        }
    }
}
