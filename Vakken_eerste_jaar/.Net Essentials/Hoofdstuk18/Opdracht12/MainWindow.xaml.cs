using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Opdracht12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml7 
    /// oefening 18.7
    /// FolderBrowserDialog wordt niet ondersteund door WPF, daarom moet je teruggaan
    /// naar de WinForms versie, zie ook:
    /// http://stackoverflow.com/questions/1922204/open-directory-dialog
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _pathDirectory;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            // startdirectory op MyComputer opm staat standaard op desktop
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _pathDirectory = dialog.SelectedPath;
                folderTextBlock.Text = dialog.SelectedPath;
            }
        }

        private void countButton_Click(object sender, RoutedEventArgs e)
        {
            // alle txt bestanden opvragen onder deze directory
            string[] files = Directory.GetFiles(_pathDirectory, "*.txt"); // met filter
            StreamReader reader = null;
            try
            {
                int countLines = 0;
                foreach(string file in files)
                {
                    reader = File.OpenText(file);
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        countLines++;
                        line = reader.ReadLine();
                    }
                    reader.Close();
                }
                resultTextBlock.Text = $"Er zijn {countLines} lijnen in {files.Length} txt files";
            }
            catch(IOException ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            finally
            {
                reader?.Close();
            }
        }
    }
}
