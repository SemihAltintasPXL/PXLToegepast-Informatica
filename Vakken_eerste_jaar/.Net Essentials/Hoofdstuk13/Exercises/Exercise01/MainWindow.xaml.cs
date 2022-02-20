using System.Windows;

namespace Exercise01
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            mainListBox.Items.Remove(mainListBox.SelectedItem);
        }
    }
}
