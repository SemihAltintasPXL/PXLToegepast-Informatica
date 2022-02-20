using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Example2ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { // bij toevoegen aan list wordt de listbox noet automatisch bijgewerkt
        // geen synchronisatie tussen list en listbox
        // oplossing 1: telkens refreshen
        // oplossing 2: klasse ObservableCollection gebruiken
        //private List<string> list; oplossing1
        private IList<string> list;
        public MainWindow()
        {
            InitializeComponent();
            //list = new List<string>() { "coffee", "milk", "bread" }; oplossing 1
            list = new ObservableCollection<string>() { "coffee", "milk", "bread" };
            shoppingListBox.ItemsSource = list; // data binding

        }
       
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
           list.Add(itemTextBox.Text);
            //shoppingListBox.Items.Refresh(); // bij oplossing1

        }
        // event bij het klikken op een item
        private void shoppingListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (shoppingListBox.SelectedItem != null) // zie resetButton
            {
                MessageBox.Show($"selected index {shoppingListBox.SelectedIndex}");
            }
        }
        // event bij dubbel klikken op een item
        private void shoppingListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
          
            MessageBox.Show($"{list[shoppingListBox.SelectedIndex]}");
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            int index = Int32.Parse(indexTextBox.Text);
            list.RemoveAt(index);
            // shoppingListBox.Items.Refresh(); //bij oplossing1
        }

        private void insertButton_Click(object sender, RoutedEventArgs e)
        {
            int index = Int32.Parse(indexTextBox.Text);
            
            list.Insert(index, itemTextBox.Text);
            // shoppingListBox.Items.Refresh(); // bij oplossing1
        }

        private void displayButton_Click(object sender, RoutedEventArgs e)
        {
            int index = Int32.Parse(indexTextBox.Text);
           
            MessageBox.Show($"item on position {index}: {list[index]}");
        }

        private void findButton_Click(object sender, RoutedEventArgs e)
        {
            string search = itemTextBox.Text;
            int index = list.IndexOf(search);
            if (index != -1) {
                MessageBox.Show($"item {search} found on position {index}");

            }
            else {
                MessageBox.Show($"item {search} not found");
            }
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            itemTextBox.Clear();
            indexTextBox.Clear();
            // selectie ongedaan maken
            shoppingListBox.SelectedItem = null; // of shoppingListBox.SelectedIndex = -1
            // opgepast event selectionChanged vindt plaats => eventhandler wordt opgeroepen
        }

        private void sortButton_Click(object sender, RoutedEventArgs e)
        { // onderstaande werkt niet bij OservableCollection!!!
            //// rangschikken van klein naar groot of hier alfabetisch
            //list.Sort();
            //// rangschikken van groot naar klein of laatste in het alfabet als eerste 
            //list.Reverse();
            //shoppingListBox.Items.Refresh();

        }
    }
}
