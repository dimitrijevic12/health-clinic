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
using System.Windows.Shapes;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for sala.xaml
    /// </summary>
    public partial class sala : Window
    {
        public sala()
        {
            InitializeComponent();
        }

        private void Button_pocetna(object sender, RoutedEventArgs e)
        {
            
           
            var s = new pocetna();
            s.Show();
            this.Close();

        }

        private void Button_prikaz(object sender, RoutedEventArgs e)
        {
            var s = new prikaz_opreme();
            s.Show();
           
        }

        private void Button_novaSala(object sender, RoutedEventArgs e)
        {
            var s = new dodaj_salu();
            s.Show();
        }

        private void Button_premestanje(object sender, RoutedEventArgs e)
        {
            var s = new premestanje_opreme();
            s.Show();
        }
    }
}
