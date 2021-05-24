using System;
using System.IO;
using System.Windows;

namespace DirectoryDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            filesTextBox.Clear();
            foldersTextBox.Clear();

            // Display all file names
            string[] files = Directory.GetFiles(folderTextBox.Text);
            foreach (string file in files)
            {// alleen de naam van het bestand tonen
                filesTextBox.AppendText(System.IO.Path.GetFileName(file));
                filesTextBox.AppendText(Environment.NewLine);
            }

            // Display all folder names
            string[] directories = Directory.GetDirectories(folderTextBox.Text);
            foreach (string directory in directories)
            {
                foldersTextBox.AppendText(directory);
                foldersTextBox.AppendText(Environment.NewLine);
            }
        }
    }
}
