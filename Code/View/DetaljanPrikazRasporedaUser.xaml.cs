using System;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for DetaljanPrikazRasporedaUser.xaml
    /// </summary>
    public partial class DetaljanPrikazRasporedaUser : UserControl
    {
        private DateTime date;
        public DetaljanPrikazRasporedaUser(DateTime date)
        {
            InitializeComponent();
            Datum.Content = date.ToShortDateString();
            this.date = date;
            labelDateTime.Content = DateTime.Now.ToShortDateString();

        }

        private void Button_Zakazivanje(object sender, RoutedEventArgs e)
        {
            GridDetaljan.Children.Clear();
            ZakazivanjePregledaUser zakazivanje = new ZakazivanjePregledaUser(date);
            GridDetaljan.Children.Add(zakazivanje);
        }

        private void Button_Otkazivanje(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Izmena(object sender, RoutedEventArgs e)
        {
            GridDetaljan.Children.Clear();
            IzmenaPregledaUser izmena = new IzmenaPregledaUser(date);
            GridDetaljan.Children.Add(izmena);
        }

        private void Button_Guest(object sender, RoutedEventArgs e)
        {
            GridDetaljan.Children.Clear();
            ZakazivanjeGuestNalogaUser zakazivanje = new ZakazivanjeGuestNalogaUser(date);
            GridDetaljan.Children.Add(zakazivanje);
        }

        private void Button_Prikaz(object sender, RoutedEventArgs e)
        {
            GridDetaljan.Children.Clear();
            SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
            GridDetaljan.Children.Add(sale);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            GridDetaljan.Children.Clear();
            HomeUser home = new HomeUser();
            GridDetaljan.Children.Add(home);
        }
    }
}
