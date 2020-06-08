using System;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for novi_lekar.xaml
    /// </summary>
    public partial class novi_lekar : Window
    {
        public novi_lekar()
        {
            InitializeComponent();
        }

        private void Button_otkazi(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            String ID = IdLekara.Text;
            String IME = Ime.Text;
            String PREZIME = Prezime.Text;
            String POL = "M";
            String JMBG = Jmbg.Text;
            String DATUMRODJ = DatumRodjenja.Text;
            String RADNOVREM = RadnoVreme.Text;
            String SPECIJALISTA = "DA";

            //lekari L = new lekari { IdLekara = ID, Ime = IME, Prezime = PREZIME, Pol = POL, Jmbg = JMBG, DatumRodjenja = DATUMRODJ, RadnoVreme = RADNOVREM, Specijalista = SPECIJALISTA};
            //Console.WriteLine(L);

            //lekar.Lekari.Add(new lekari() { IdLekara = ID, Ime = IME, Prezime = PREZIME, Pol = POL, Jmbg = JMBG, DatumRodjenja = DATUMRODJ, RadnoVreme = RADNOVREM, Specijalista = SPECIJALISTA } );

           
            this.Close();

        }

        private void IdLekara_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
