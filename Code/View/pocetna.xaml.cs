using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for pocetna.xaml
    /// </summary>
    public partial class pocetna : Window
    {
        public pocetna()
        {
            InitializeComponent();
            
            labelDate.Content = DateTime.Now.ToShortDateString();
            labelTime.Content = DateTime.Now.ToShortTimeString();
            

        }

        private void Button_magacin(object sender, RoutedEventArgs e)
        {
            var s = new magacin();
            s.Show();
            this.Close();
          
        }

        private void Button_sala(object sender, RoutedEventArgs e)
        {
            var s = new sala();
            s.Show();
            this.Close();
        }

        private void Button_izvestaj(object sender, RoutedEventArgs e)
        {
            var s = new izvestaj();
            s.Show();
            this.Close();
        }

        private void Button_renoviranje(object sender, RoutedEventArgs e)
        {
            var s = new renoviranje();
            s.Show();
            this.Close();
        }

        private void Button_dodatno(object sender, RoutedEventArgs e)
        {
            var s = new dodatno();
            s.Show();
            this.Close();
        }

        private void Button_lekar(object sender, RoutedEventArgs e)
        {
            var s = new lekar();
            s.Show();
            this.Close();
        }

        private void Button_odjava(object sender, RoutedEventArgs e)
        {
            var s = new MainWindow();
            s.Show();

            this.Close();


        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
