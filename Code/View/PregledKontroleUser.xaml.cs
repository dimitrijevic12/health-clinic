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
    /// Interaction logic for PregledKontroleUser.xaml
    /// </summary>
    public partial class PregledKontroleUser : UserControl
    {
        public PregledKontroleUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
        }

        private void Button_Izadji(object sender, RoutedEventArgs e)
        {
            GridPregled.Children.Clear();
            IzvestajPacijentaUser izvestaj = new IzvestajPacijentaUser();
            GridPregled.Children.Add(izvestaj);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            GridPregled.Children.Clear();
            HomeUser home = new HomeUser();
            GridPregled.Children.Add(home);
        }
    }
}
