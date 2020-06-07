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
    /// Interaction logic for PocetnaUser.xaml
    /// </summary>
    public partial class PocetnaUser : UserControl
    {
        public PocetnaUser()
        {
            InitializeComponent();
        }

        private void buttonRaspored_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new RasporedUser();
            (this.Parent as Panel).Children.Add(usc);
//            this.Content = new RasporedUser();
        }

        private void buttonZapocniPregled_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new ZapocniPregled();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonNapisiClanak_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new NapisiClanak();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonZdravstveniKartoni_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new ZdravstveniKartoniLista();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonOdobravanjePregleda_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new OdobravanjeLekova();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonPregledStatistike_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new IzvestajOPotrosnjiLekova();
            (this.Parent as Panel).Children.Add(usc);
        }

    }
}
