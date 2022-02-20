using System;
using System.IO;
using System.Windows;

namespace DomineeringGame
{
    /// <summary>
    /// Interaction logic for MovesWindow.xaml
    /// </summary>
    public partial class MovesWindow
    {
        public MovesWindow()
        {
            InitializeComponent();
        }

        internal void FillOutput()
        {
            StreamReader inputStream = null;
            try
            {
                outputTextBlock.Text = "";
                string sourcepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string myfile = System.IO.Path.Combine(sourcepath, "domineering.txt");
                inputStream = File.OpenText(myfile);
                string line = inputStream.ReadLine();
                while (line != null)
                {
                    outputTextBlock.Text += line;
                    outputTextBlock.Text += Environment.NewLine;
                    line = inputStream.ReadLine();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error, we could not find the domineering.txt file in your Documents.");
            }
            finally
            {
                inputStream?.Close();
            }
        }
    }
}
