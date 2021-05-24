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

namespace Writing
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

        private void writing1Button_Click(object sender, RoutedEventArgs e)
        {
            // wegschrijven naar ..\bin\debug
            StreamWriter writer = File.CreateText("writing1.txt");
            writer.WriteLine("gegevens wegschrijven naar ...\\bin\\debug");
            writer.WriteLine(inputTextBox.Text);
            inputTextBox.Clear();
            writer.Close();
        }

        private void writing2Button_Click(object sender, RoutedEventArgs e)
        {
            // wegschrijven naar ...\H18\Writing\...
            // dit NOOIT gebruiken op een examen
            StreamWriter writer = File.CreateText(@"C:\Users\20002375\Documents\Ingrid\C#\20202021\klassen\1TINE\H18\Writing\writing2.txt");
            writer.WriteLine("gegevens wegschrijven naar ...\\H18\\Writing\\...");
            writer.WriteLine(inputTextBox.Text);
            inputTextBox.Clear();
            writer.Close();
        }

        private void writing3Button_Click(object sender, RoutedEventArgs e)
        {
            // wegschrijven op het bureaublad
            string pathName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(pathName, "writing3.txt");
            StreamWriter writer = File.CreateText(filePath);
            writer.WriteLine("gegevens wegschrijven naar bureaublad");
            writer.WriteLine(inputTextBox.Text);
            inputTextBox.Clear();
            writer.Close();
        }

        private void writing4Button_Click(object sender, RoutedEventArgs e)
        {
            // schrijven bestand onder..\bin\debug
            StreamWriter writer = null;
            try
            {// => exception indien bestand al bestaat
             //FileStream fileStream = new FileStream("writing1.txt", FileMode.CreateNew, FileAccess.Write);
             // indien bestand bestaat toevoegen aan het bestand
                FileStream fileStream = new FileStream("writing1.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(fileStream);
                writer.WriteLine(inputTextBox.Text);
                inputTextBox.Clear();
            } catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                writer?.Close();
            }
        }

        private void writing5Button_Click(object sender, RoutedEventArgs e)
        {
            // wegschrijven via filedialog
            StreamWriter writer = null;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                // startdirectory mijnDocumenten
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                // alleen txt bestand en word documenten
                saveFileDialog.Filter = "Text files|*.txt|Word doucments|*.doc; *.docx"; 
                if (saveFileDialog.ShowDialog() == true)
                {
                    writer = File.CreateText(saveFileDialog.FileName);
                    writer.WriteLine(inputTextBox.Text);
                    inputTextBox.Clear();
                }
            } catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                writer?.Close();
            }
        }
    }
}
