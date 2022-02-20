using Microsoft.Win32;
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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Reading
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

        private void reading1Button_Click(object sender, RoutedEventArgs e)
        {
            // lezen van bestand onder ...bin\debug
            StreamReader reader = null;
            try
            {
                reader = File.OpenText("writing1.txt");
                outputTextBox.Text = reader.ReadToEnd();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("bestand niet gevonden");
            }
            finally
            {
                //if (reader != null)
                //{
                //    reader.Close();
                //}
                // of korter
                reader?.Close();
            }
        }

        private void reading2Button_Click(object sender, RoutedEventArgs e)
        {
            // lezen van bestand onder ...H18\Writing\
            StreamReader reader = File.OpenText(@"C:\Users\20002375\Documents\Ingrid\C#\20202021\klassen\1TINE\H18\Writing\writing2.txt");
            outputTextBox.Text = reader.ReadToEnd();
            reader.Close();
        }

        private void reading3Button_Click(object sender, RoutedEventArgs e)
        {
            // lezen van bestand op bureaublad
            string pathName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(pathName, "writing3.txt");
            StreamReader reader = File.OpenText(filePath);
            string line = reader.ReadLine();

            int countWords = 0;
            while (line != null)
            {
                outputTextBox.AppendText(line + "\n");
                string[] words = line.Split(' ');
                countWords += words.Length;
                line = reader.ReadLine();
            }
            outputTextBox.AppendText($"Deze tekst bevat {countWords} woorden");
            reader.Close();

        }

        private void reading4Button_Click(object sender, RoutedEventArgs e)
        {
            // lezen mbv filestream bestand staat in bin\debug
            StreamReader reader = null;
            try
            {
                FileStream fileStream = new FileStream("writing1.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fileStream);
                outputTextBox.Text = reader.ReadToEnd();
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader?.Close();
            }
        }

        private void reading5Button_Click(object sender, RoutedEventArgs e)
        {
            // lezen mbv fileDialog
            StreamReader reader = null;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                // startdirectory bureaublad
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                // filter alleen txt bestanden en word documenten
                dialog.Filter = "Text files|*.txt|Word documents|*.doc; *.docx";
                if (dialog.ShowDialog() == true)
                {
                    reader = File.OpenText(dialog.FileName);
                    outputTextBox.Text = reader.ReadToEnd();
                }
            }catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader?.Close();
            }
        }
    }
}
