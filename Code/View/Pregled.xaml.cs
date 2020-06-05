using System;
using System.Collections.Generic;
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

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for Pregled.xaml
    /// </summary>
    public partial class Pregled : UserControl
    {
       // private String _imePrezime = "Jovan Jovanovic";
        public Pregled()
        {
            InitializeComponent();
//            this._imePrezime = imePrezime;
        }

        private void buttonNapisiRecept_Click(object sender, RoutedEventArgs e)
        {
            //            this.Content = new NapisiRecept(_imePrezime);
            //            this.Content = napisiRecept;
            this.Content = new NapisiRecept();
        }

        private void buttonNapisiUputZaOperaciju_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ZakazivanjeOperacije();
        }

        private void buttonNapisiUputZaSpecijalistu_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ZakazivanjeKodSpecijaliste();
        }

        private void buttonZahtevZaBolnickoLecenje_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ZahtevZaBolnickoLecenje();
        }

        private void buttonNapisiIzvestaj_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new DijagnozaProcedura();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new PocetnaUser();
        }

        private void buttonZakaziKontrolu_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ZakaziKontrolu();
        }

        private void buttonIstorijaBolesti_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ZdravstveniKartoniPacijent();
        }
    }
}
