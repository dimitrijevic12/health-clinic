using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for IzaberiNalogUser.xaml
    /// </summary>
    public partial class IzaberiNalogUser : UserControl
    {
        private int colNum = 0;
        //public ObservableCollection<NalogPacijent> Nalozi
        //{
        //    get;
        //    set;
        //}

        public IzaberiNalogUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
            this.DataContext = this;
        //    Nalozi = new ObservableCollection<NalogPacijent>();
        //    Nalozi.Add(new NalogPacijent() { IDnaloga = 1, Ime = "Petar", Prezime = "Peric", JMBG = 111111, Pol = EnumPol.M, OdabraniDoktor = "Doktor Savo", DatumRodjenja = "13/13/13", IstorijaLecenja = "Neki tekst" });
        //    Nalozi.Add(new NalogPacijent() { IDnaloga = 2, Ime = "Marko", Prezime = "Markovic", JMBG = 222222, Pol = EnumPol.M, OdabraniDoktor = "Doktor Savo", DatumRodjenja = "13/13/13", IstorijaLecenja = "Neki tekst" });
        //    Nalozi.Add(new NalogPacijent() { IDnaloga = 3, Ime = "Nikola", Prezime = "Nikolic", JMBG = 333333, Pol = EnumPol.M, OdabraniDoktor = "Doktor Savo", DatumRodjenja = "13/13/13", IstorijaLecenja = "Neki tekst" });
        }

        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Izaberi(object sender, RoutedEventArgs e)
        {
            GridIzaberi.Children.Clear();
            HomeUser home = new HomeUser();
            GridIzaberi.Children.Add(home);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            GridIzaberi.Children.Clear();
            HomeUser home = new HomeUser();
            GridIzaberi.Children.Add(home);
        }
    }
}
