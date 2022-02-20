using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Exercise08
{
    public partial class MainWindow : Window
    {
        private List<Persoon> personen = new List<Persoon>();
        private IList<Persoon> personenLijst = new List<Persoon>();

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Persoon persoon = new Persoon();
                persoon.Naam = "Persoon " + Convert.ToString(i + 1);
                personen.Add(persoon);
                //ListBoxItem persoonListBoxItem = new ListBoxItem();
                //persoonListBoxItem.Content = persoon.ToString();
                //persoonListBoxItem.DataContext = persoon;
                personenLijst.Add(persoon);
            }

            personenListBox.ItemsSource = personenLijst;
        }

        private void detailsButton_Click(object sender, RoutedEventArgs e)
        {
            int index = personenListBox.SelectedIndex;
            //^^ Overbodig, maar moet voor groene test
            DetailsWindow w = new DetailsWindow();
         
            w.Show();
            w.plaatsGegevens(personenLijst[index]);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            personenListBox.ItemsSource = null;
            personenListBox.ItemsSource = personenLijst;
        }
    }
}
