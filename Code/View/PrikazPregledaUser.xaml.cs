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
    /// Interaction logic for PrikazPregledaUser.xaml
    /// </summary>
    public partial class PrikazPregledaUser : UserControl
    {
        public PrikazPregledaUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
        }

        private void Button_Izadji(object sender, RoutedEventArgs e)
        {
            GridPrikaz.Children.Clear();
            DetaljanPrikazRasporedaUser detaljan = new DetaljanPrikazRasporedaUser(DateTime.Now);
            GridPrikaz.Children.Add(detaljan);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            GridPrikaz.Children.Clear();
            HomeUser home = new HomeUser();
            GridPrikaz.Children.Add(home);
        }
    }
}
