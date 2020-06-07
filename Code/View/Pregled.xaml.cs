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
            UserControl usc = new NapisiRecept();
            (this.Parent as Panel).Children.Add(usc);
            //            this.mainPanel.Children.Remove();
            //            this.mainPanel.Children.Add(napisiRecept);
            //            (this.Parent as Panel).Children.Add(napisiRecept);
            //            this.Content = this.;
            //            this.Content = new NapisiRecept();
        }

        private void buttonNapisiUputZaOperaciju_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new ZakazivanjeOperacije();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonNapisiUputZaSpecijalistu_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new ZakazivanjeKodSpecijaliste();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonZahtevZaBolnickoLecenje_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new ZahtevZaBolnickoLecenje();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonNapisiIzvestaj_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new DijagnozaProcedura();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void buttonZakaziKontrolu_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new ZakaziKontrolu();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonIstorijaBolesti_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new ZdravstveniKartoniPacijent();
            (this.Parent as Panel).Children.Add(usc);
        }
    }
}
