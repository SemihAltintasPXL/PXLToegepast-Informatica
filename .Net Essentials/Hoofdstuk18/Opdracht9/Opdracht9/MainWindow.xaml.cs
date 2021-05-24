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

namespace Opdracht9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { private string _filePath;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openItem_Click(object sender, RoutedEventArgs e)
        {// lezen van bestand, via dialoogvenster, startdirectory map mijndocumenten, filter alleen txt bestanden
            StreamReader reader = null;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                dialog.Filter = "Text files|*.txt";
                if (dialog.ShowDialog() == true)
                {
                    _filePath = dialog.FileName;
                    reader = File.OpenText(dialog.FileName);
                    outputTextBox.Text = reader.ReadToEnd();
                    if (outputTextBox.Text != "")
                    {
                        rewriteItem.IsEnabled = true;
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader?.Close();
            }


        }

        private void rewriteItem_Click(object sender, RoutedEventArgs e)
        {// vervang de tekst in tekstbox bvb allemAal2356 =>LllemLLl2356
            string text = outputTextBox.Text.Trim();
            // laatste letter bepalen
            int place = text.Length - 1;
            while (!Char.IsLetter(text[place]))
            {
                place--;
            }
            char last = Char.ToUpper(text[place]);
            // alle letters = eerste letter (in kleine letter)  vervangen door last
            char first = text[0];
            text = text.Replace(Char.ToLower(first), last);
            // alle letters = eerste letter (in hoofdletter)  vervangen door last
            text = text.Replace(Char.ToUpper(first), last);
            outputTextBox.Text = text;
            appendItem.IsEnabled = true;
        }

        private void appendItem_Click(object sender, RoutedEventArgs e)
        {// gewijzigde text toevoegen aan bestaand bestand
            StreamWriter writer = null;
            try
            {
                FileStream fileStream = new FileStream(_filePath, FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(fileStream);
                writer.WriteLine(outputTextBox.Text);
                outputTextBox.Clear();
                rewriteItem.IsEnabled = false;
                appendItem.IsEnabled = false;
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                writer?.Close();
            }

        }

        private void exitItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
