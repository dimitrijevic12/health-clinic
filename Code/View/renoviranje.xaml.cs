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
        public static RoutedCommand Pocetnashortcut = new RoutedCommand();
        public renoviranje()
        {
            InitializeComponent();
            Pocetnashortcut.InputGestures.Add(new KeyGesture(Key.P, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Pocetnashortcut, Button_pocetna));
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
        private void MenuItem_lekar(object sender, RoutedEventArgs e)
        {
            var s = new lekar();
            s.Show();
            this.Close();
        }



        private void MenuItem_izvestaj(object sender, RoutedEventArgs e)
        {
            var s = new izvestaj();
            s.Show();
            this.Close();
        }


        private void MenuItem_pocetna(object sender, RoutedEventArgs e)
        {
            var s = new pocetna();
            s.Show();
            this.Close();
        }

        private void MenuItem_magacin(object sender, RoutedEventArgs e)
        {
            var s = new magacin();
            s.Show();
            this.Close();
        }

        private void MenuItem_pomoc(object sender, RoutedEventArgs e)
        {

        }
    }
}
