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

namespace Example1ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = itemTextBox.Text;
            shoppingListBox.Items.Add(item);
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
            ListBoxItem item = (ListBoxItem)shoppingListBox.SelectedItem;
            MessageBox.Show($"{item.Content}");
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            int index = Int32.Parse(indexTextBox.Text);
            shoppingListBox.Items.RemoveAt(index);
        }

        private void insertButton_Click(object sender, RoutedEventArgs e)
        {
            int index = Int32.Parse(indexTextBox.Text);
            ListBoxItem item = new ListBoxItem();
            item.Content = itemTextBox.Text;
            shoppingListBox.Items.Insert(index, item);
        }

        private void displayButton_Click(object sender, RoutedEventArgs e)
        {
            int index = Int32.Parse(indexTextBox.Text);
            ListBoxItem item = shoppingListBox.Items[index] as ListBoxItem;
            MessageBox.Show($"item on position {index}: {item.Content}");
        }

        private void findButton_Click(object sender, RoutedEventArgs e)
        {
            string search = itemTextBox.Text;
            for (int i = 0; i < shoppingListBox.Items.Count; i++)
            {
                ListBoxItem item = shoppingListBox.Items[i] as ListBoxItem;
                if (search == Convert.ToString(item.Content))
                {
                    MessageBox.Show($"item {search} found on position {i}");
                    return;
                }
            }
            MessageBox.Show($"item {search} not found");
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            itemTextBox.Clear();
            indexTextBox.Clear();
            // selectie ongedaan maken
            shoppingListBox.SelectedItem = null; // of shoppingListBox.SelectedIndex = -1
            // opgepast evnt selectionChanged vindt plaats => eventhandler wordt opgeroepen
        }
    }
}
