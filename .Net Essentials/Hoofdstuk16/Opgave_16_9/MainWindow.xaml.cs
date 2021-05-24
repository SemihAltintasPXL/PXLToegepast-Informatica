using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Opgave_16_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, RoutedEventArgs e)
        {
            //START TIME
            DateTime start = DateTime.Now;

            if (((ComboBoxItem)algoritmeComboBox.SelectedItem).Content.ToString() == "AskFrasier methode")
            {
                outputTextBlock.Text = Change(outputTextBlock.Text, searchTextBox.Text, replaceWithTextBox.Text);
            }
            else
            {
                if (((ComboBoxItem)algoritmeComboBox.SelectedItem).Content.ToString() == "StringBuilder methode")
                {
                    outputTextBlock.Text = ChangeStringBuilder(outputTextBlock.Text, searchTextBox.Text, replaceWithTextBox.Text);
                }
                else
                {
                    outputTextBlock.Text = outputTextBlock.Text.Replace(searchTextBox.Text, replaceWithTextBox.Text);
                }
            }

            //STOP TIME
            DateTime end = DateTime.Now;
            TimeSpan period = end - start;
            timerLabel.Content =
                $"timer: {period.Minutes} minutes, {period.Seconds} seconds and {period.Milliseconds} milliseconds.";
        }

        private string Change(string original, string fromText, string toText)
        {

            string leftBit, rightBit;
            int startSearch = 0;
            int place = original.IndexOf(fromText);

            if (fromText.Length != 0)
            {
                while (place >= startSearch)
                {
                    leftBit = original.Substring(0, place);
                    rightBit = original.Substring(place + fromText.Length,
                        original.Length - place - fromText.Length);
                    original = leftBit + toText + rightBit;
                    startSearch = leftBit.Length + toText.Length;
                    place = original.IndexOf(fromText);
                }
            }
            return original;
        }

        //WERKT NIET 100% CORRECT...
        private string ChangeStringBuilder(string original, string fromText, string toText)
        {
            StringBuilder text = new StringBuilder("");
            string leftBit, rightBit;
            int startSearch = 0;
            int place = original.IndexOf(fromText);

            if (fromText.Length != 0)
            {
                while (place >= startSearch)
                {
                    leftBit = original.Substring(0, place);
                    rightBit = original.Substring(place + fromText.Length,
                        original.Length - place - fromText.Length);
                    text.Append(leftBit);
                    text.Append(toText);
                    text.Append(rightBit);
                    startSearch = leftBit.Length + toText.Length;
                    place = original.IndexOf(fromText);
                }
            }
            return text.ToString();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            outputTextBlock.Text = "";
            timerLabel.Content = "";
        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            //START TIME
            DateTime start = DateTime.Now;

            outputTextBlock.Text = "";
            string word = "";
            for (int i = 0; i < 10000; i++)
            {
                word = "";
                for (int j = 0; j < rand.Next(1, 6); j++)
                {
                    word += GetCharacterByValue();
                }

                outputTextBlock.Text += word + " ";
            }

            //STOP TIME
            DateTime end = DateTime.Now;
            TimeSpan period = end - start;
            timerLabel.Content =
                $"timer: {period.Minutes} minutes, {period.Seconds} seconds and {period.Milliseconds} milliseconds.";
        }

        private string GetCharacterByValue()
        {
            int temp = rand.Next(1, 4);
            switch (temp)
            {
                case 1:
                    return "a";
                    break;
                case 2:
                    return "b";
                    break;
                case 3:
                    return "c";
                    break;
            }

            return null;
        }
    }
}