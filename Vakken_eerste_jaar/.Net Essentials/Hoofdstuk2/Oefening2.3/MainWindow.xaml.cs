using System.Windows;

namespace Oefening2._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Semih Altintas");
        }

        //dit komt meteen op beeld
        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ik ben 18 jaar");
        }
        //maar eigenlijk wordt dit gevraagd 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ik ben 18 jaar");
        }
    }
}
