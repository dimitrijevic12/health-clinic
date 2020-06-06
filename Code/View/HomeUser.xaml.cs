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
            GridHome.Children.Clear();
            DateTime date = DateTime.Now;
            DetaljanPrikazRasporedaUser detaljan = new DetaljanPrikazRasporedaUser(date);
            GridHome.Children.Add(detaljan);
        }

        private void Button_Smestaj(object sender, RoutedEventArgs e)
        {
            GridHome.Children.Clear();
            SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
            GridHome.Children.Add(sale);
        }

        private void Button_Raspored(object sender, RoutedEventArgs e)
        {
            GridHome.Children.Clear();
            Kalendar kalendar = new Kalendar();
            GridHome.Children.Add(kalendar);
        }

        private void Button_Pacijenti(object sender, RoutedEventArgs e)
        {
            GridHome.Children.Clear();
            RegistrovaniPacijentiUser pacijenti = new RegistrovaniPacijentiUser();
            GridHome.Children.Add(pacijenti);
        }

        private void Button_Doktori(object sender, RoutedEventArgs e)
        {
            GridHome.Children.Clear();
            Doktori doktori = new Doktori();
            GridHome.Children.Add(doktori);
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
            GridHome.Children.Clear();
            GenerisiIzvestajUser generisi = new GenerisiIzvestajUser();
            GridHome.Children.Add(generisi);
        }

        private void Button_Prioritet(object sender, RoutedEventArgs e)
        {
            GridHome.Children.Clear();
            OdabirPrioritetaUser prioritet = new OdabirPrioritetaUser();
            GridHome.Children.Add(prioritet);
        }
    }
}
