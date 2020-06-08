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
    /// Interaction logic for renoviranje.xaml
    /// </summary>
    public partial class renoviranje : Window
    {
        public renoviranje()
        {
            InitializeComponent();
        }

        private void Button_pocetna(object sender, RoutedEventArgs e)
        {
            var s = new pocetna();
            s.Show();
            this.Close();
           

        }

        private void Button_krecenje(object sender, RoutedEventArgs e)
        {
            var s = new krecenje();
            s.Show();
          
        }

        private void Button_namena(object sender, RoutedEventArgs e)
        {
            var s = new namena_sale();
            s.Show();
           
        }


        private void Button_podela(object sender, RoutedEventArgs e)
        {
            var s = new podela_sale();
            s.Show();
           
        }

        private void Button_spajanje(object sender, RoutedEventArgs e)
        {
            var s = new spajanje_sala();
            s.Show();
            
        }
    }
}
