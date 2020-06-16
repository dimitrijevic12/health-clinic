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
    /// Interaction logic for dodatno.xaml
    /// </summary>
    public partial class dodatno : Window
    {
        public static RoutedCommand Pocetnashortcut = new RoutedCommand();
        public dodatno()
        {
            InitializeComponent();
             
            Pocetnashortcut.InputGestures.Add(new KeyGesture(Key.P, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Pocetnashortcut, Button_pocetna));

            labelDate.Content = DateTime.Now.ToShortDateString();
            labelTime.Content = DateTime.Now.ToShortTimeString();

        }

        private void Button_pocetna(object sender, RoutedEventArgs e)
        {
            var s = new pocetna();
            s.Show();

            this.Close();

        }

       
        private void Button_jezik(object sender, RoutedEventArgs e)
        {
            if ((comboBox.SelectedIndex == -1))
            {
                string message = "Sva polja moraju biti popunjena!";
                string title = "Greška";

                MessageBox.Show(message, title);
            }
            else
            {
                this.Close();
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                Properties.Settings.Default.languageCode = "se-SE";
            }
            else
            {
                Properties.Settings.Default.languageCode = "en-US";
            }
            Properties.Settings.Default.Save();

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
