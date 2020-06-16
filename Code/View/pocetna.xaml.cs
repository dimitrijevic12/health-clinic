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
        public static RoutedCommand Lekarshortcut = new RoutedCommand();
        public static RoutedCommand Pocetnashortcut = new RoutedCommand();
        public static RoutedCommand Izvestajshortcut = new RoutedCommand();
        public static RoutedCommand Magacinshortcut = new RoutedCommand();
        public static RoutedCommand Salashortcut = new RoutedCommand();
        public static RoutedCommand Pomocshortcut = new RoutedCommand();
        public static RoutedCommand Opcijeshortcut = new RoutedCommand();
        public static RoutedCommand Renoviranjeshortcut = new RoutedCommand();
        public pocetna()
        {
            InitializeComponent();
            Lekarshortcut.InputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Lekarshortcut, s1click));

            Izvestajshortcut.InputGestures.Add(new KeyGesture(Key.I, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Izvestajshortcut, s2click));

            Magacinshortcut.InputGestures.Add(new KeyGesture(Key.M, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Magacinshortcut, s3click));

            Salashortcut.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Salashortcut, s4click));


            Pomocshortcut.InputGestures.Add(new KeyGesture(Key.P, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Pomocshortcut, s5click));

            Opcijeshortcut.InputGestures.Add(new KeyGesture(Key.O, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Opcijeshortcut, s6click));

            Renoviranjeshortcut.InputGestures.Add(new KeyGesture(Key.R, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Renoviranjeshortcut, s7click));

            labelDate.Content = DateTime.Now.ToShortDateString();
            labelTime.Content = DateTime.Now.ToShortTimeString();
            

        }
        private void s1click(object sender, RoutedEventArgs e)
        {
            var s = new lekar();
            s.Show();
            this.Close();

        }
        private void s2click(object sender, RoutedEventArgs e)
        {
            var s = new izvestaj();
            s.Show();
            this.Close();

        }

        private void s3click(object sender, RoutedEventArgs e)
        {
            var s = new magacin();
            s.Show();
            this.Close();

        }
        private void s4click(object sender, RoutedEventArgs e)
        {
            var s = new sala();
            s.Show();
            this.Close();

        }
        private void s5click(object sender, RoutedEventArgs e)
        {
            var s = new izaberi_izvestaj();
            s.Show();
            this.Close();

        }
        private void s6click(object sender, RoutedEventArgs e)
        {
            var s = new dodatno();
            s.Show();
            this.Close();

        }
        private void s7click(object sender, RoutedEventArgs e)
        {
            var s = new renoviranje();
            s.Show();
            this.Close();

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

       

        private void Button_pomoc(object sender, RoutedEventArgs e)
        {
            var s = new izaberi_izvestaj();
            s.Show();
            this.Close();
        }
    }
}
