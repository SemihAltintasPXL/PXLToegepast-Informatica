using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;

namespace Opgave23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Vak[] vakArray = new Vak[1000000];
        private List<Vak> vakList = new List<Vak>();
        private Dictionary<string, Vak> vakDictionary = new Dictionary<string, Vak>();
        private DateTime startTime = DateTime.Now;
        private DateTime stopTime;
        private TimeSpan timeSpan;
        private Stopwatch timer = new Stopwatch();

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < vakArray.Length; i++)
            {
                string naam = "vak" + Convert.ToString(i);
                Vak vak = new Vak(naam, "NAAM DOCENT", 5);

                //Array
                vakArray[i] = vak;

                //List
                vakList.Add(vak);

                //Dictionary
                vakDictionary.Add(vak.Naam, vak);

            }
        }

        private void StopTimer()
        {
            stopTime = DateTime.Now;
            timeSpan = stopTime - startTime;
            MessageBox.Show(String.Format("Duur: {0} sec en {1} msec.", timeSpan.Seconds, timeSpan.Milliseconds));
        }

        private void StartTimer()
        {
            startTime = DateTime.Now;
        }

        private void array_Click(object sender, RoutedEventArgs e)
        {
            StartTimer();
            bool gevonden = false;
            for (int i = 0; i < vakArray.Length; i++)
            {
                if (vakArray[i].Naam == inputTextBox.Text)
                {
                    outputTextBlock.Text = "Vakgegevens voor " + vakArray[i].Naam + Environment.NewLine + Environment.NewLine + "Docent: " + vakArray[i].Docent + Environment.NewLine + "Uren: " + vakArray[i].Uren;
                    i = vakArray.Length;
                    gevonden = true;
                }
            }

            if (!gevonden)
            {
                MessageBox.Show("Vak: " + inputTextBox.Text + " niet gevonden.");
            }

            StopTimer();
        }

        private void list_Click(object sender, RoutedEventArgs e)
        {
            StartTimer();
            bool gevonden = false;
            for (int i = 0; i < vakList.Count; i++)
            {
                if (vakList[i].Naam == inputTextBox.Text)
                {
                    outputTextBlock.Text = "Vakgegevens voor " + vakList[i].Naam + Environment.NewLine + Environment.NewLine + "Docent: " + vakList[i].Docent + Environment.NewLine + "Uren: " + vakList[i].Uren;
                    i = vakList.Count;
                    gevonden = true;
                }
            }

            if (!gevonden)
            {
                MessageBox.Show("Vak: " + inputTextBox.Text + " niet gevonden.");
            }
            StopTimer();

        }

        private void dictionary_Click(object sender, RoutedEventArgs e)
        {
            StartTimer();
            string key;
            Vak vak;

            if (inputTextBox.Text != "")
            {
                key = inputTextBox.Text;
                if (vakDictionary.ContainsKey(key))
                {
                    vak = vakDictionary[key];

                    outputTextBlock.Text = "Vakgegevens voor " + vak.Naam + Environment.NewLine + Environment.NewLine + "Docent: " + vak.Docent + Environment.NewLine + "Uren: " + vak.Uren;
                }
                else
                {
                    MessageBox.Show("Vak: " + key + " niet gevonden.");
                }
            }
            StopTimer();

        }
    }
}
