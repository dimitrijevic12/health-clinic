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
    /// Interaction logic for magacin.xaml
    /// </summary>
    public partial class magacin : Window
    {
        public magacin()
        {
            InitializeComponent();
        }

        private void Button_pocetna(object sender, RoutedEventArgs e)
        {
            var s = new pocetna();
            s.Show();
            this.Close();

        }

        private void Button_lekovi(object sender, RoutedEventArgs e)
        {
            var s = new magacin_lekovi();
            s.Show();
            
        }

        private void Button_oprema(object sender, RoutedEventArgs e)
        {
            var s = new magacin_oprema();
            s.Show();
           
        }

        private void Button_noviLek(object sender, RoutedEventArgs e)
        {
            var s = new naruci_lek();
            s.Show();
          
        }

        private void Button_naruciOpremu(object sender, RoutedEventArgs e)
        {
            var s = new naruci_opremu();
            s.Show();
           
        }
    }
}
