﻿using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for lista_lekova.xaml
    /// </summary>
    public partial class magacin_oprema : Window
    {
        private int colNum = 0;

        //public static ObservableCollection<oprema> Oprema
        //{
        //    get;
        //    set;
        //}
        public magacin_oprema()
        {
            InitializeComponent();
            this.DataContext = this;
            //Oprema = new ObservableCollection<oprema>();
            //Oprema.Add(new oprema() { VrstaOpreme = "Sto",  Sifra="1", Kolicina = "10" });
            //Oprema.Add(new oprema() { VrstaOpreme = "Krevet", Sifra = "2", Kolicina = "20" });

        }

        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_izadji(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void Button_detaljno(object sender, RoutedEventArgs e)
        {
            var s = new odabrana_oprema();
            s.Show();
           
        }

        private void dataGridMagacinOprema_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}