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
    /// Interaction logic for PregledNalogaUser.xaml
    /// </summary>
    public partial class PregledNalogaUser : UserControl
    {
        public PregledNalogaUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
        }

        private void Button_Izadji(object sender, RoutedEventArgs e)
        {
            GridPregled.Children.Clear();
            RegistrovaniPacijentiUser pacijenti = new RegistrovaniPacijentiUser();
            GridPregled.Children.Add(pacijenti);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            GridPregled.Children.Clear();
            HomeUser home = new HomeUser();
            GridPregled.Children.Add(home);
        }
    }
}
