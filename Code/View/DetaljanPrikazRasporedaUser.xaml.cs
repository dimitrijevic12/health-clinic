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
            
            ZakazivanjePregledaUser zakazivanje = new ZakazivanjePregledaUser(date);
            (this.Parent as Panel).Children.Add(zakazivanje);
        }

        private void Button_Otkazivanje(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Izmena(object sender, RoutedEventArgs e)
        {
            
            IzmenaPregledaUser izmena = new IzmenaPregledaUser(date);
            (this.Parent as Panel).Children.Add(izmena);
        }

        private void Button_Guest(object sender, RoutedEventArgs e)
        {
            
            ZakazivanjeGuestNalogaUser zakazivanje = new ZakazivanjeGuestNalogaUser(date);
            (this.Parent as Panel).Children.Add(zakazivanje);
        }

        private void Button_Prikaz(object sender, RoutedEventArgs e)
        {
            
            SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
            (this.Parent as Panel).Children.Add(sale);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {

            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(2, thisCount);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
