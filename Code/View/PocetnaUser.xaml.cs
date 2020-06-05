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
            this.Content = new RasporedUser();
        }

        private void buttonZapocniPregled_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ZapocniPregled();
        }

        private void buttonNapisiClanak_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new NapisiClanak();
        }

        private void buttonZdravstveniKartoni_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ZdravstveniKartoniLista();
        }

        private void buttonOdobravanjePregleda_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new OdobravanjeLekova();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new PocetnaUser();
        }

        private void buttonPregledStatistike_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new IzvestajOPotrosnjiLekova();
        }
    }
}
