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
    /// Interaction logic for HomeUser.xaml
    /// </summary>
    public partial class HomeUser : UserControl
    {
        public HomeUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
        }

        private void Button_DanasnjiRaspored(object sender, RoutedEventArgs e)
        {
            
            DateTime date = DateTime.Now;
            DetaljanPrikazRasporedaUser detaljan = new DetaljanPrikazRasporedaUser(date);
            (this.Parent as Panel).Children.Add(detaljan);
        }

        private void Button_Smestaj(object sender, RoutedEventArgs e)
        {
            
            SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
            
            (this.Parent as Panel).Children.Add(sale);
        }

        private void Button_Raspored(object sender, RoutedEventArgs e)
        {
            
            Kalendar kalendar = new Kalendar();
            (this.Parent as Panel).Children.Add(kalendar);
        }

        private void Button_Pacijenti(object sender, RoutedEventArgs e)
        {
            
            RegistrovaniPacijentiUser pacijenti = new RegistrovaniPacijentiUser();
            (this.Parent as Panel).Children.Add(pacijenti);
        }

        private void Button_Doktori(object sender, RoutedEventArgs e)
        {
            
            Doktori doktori = new Doktori();
            (this.Parent as Panel).Children.Add(doktori);
        }

        private void Button_Help(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Odjava(object sender, RoutedEventArgs e)
        {
            var s = new MainWindow();
            s.Show();
            
        }

        private void Button_Izvestaj(object sender, RoutedEventArgs e)
        {
            
            GenerisiIzvestajUser generisi = new GenerisiIzvestajUser();
            (this.Parent as Panel).Children.Add(generisi);
        }

        private void Button_Prioritet(object sender, RoutedEventArgs e)
        {
            
            OdabirPrioritetaUser prioritet = new OdabirPrioritetaUser();
            (this.Parent as Panel).Children.Add(prioritet);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
