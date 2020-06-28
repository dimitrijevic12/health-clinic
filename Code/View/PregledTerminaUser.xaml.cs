using Model.Appointment;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Model.SystemUsers;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for PregledTerminaUser.xaml
    /// </summary>
    public partial class PregledTerminaUser : UserControl
    {
        private Appointment appointment;
        public PregledTerminaUser(Appointment appointment)
        {
            Appointment = appointment;
            InitializeComponent();
            DataContext = this;;
        }

        public Appointment Appointment { get => appointment; set => appointment = value; }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Možete se vratiti na izbor termina klikom na dugme koje izgleda kao strelica koja pokazuje u levo, ili se možete vratiti na početnu stranu ako kliknete na dugme koje izgleda kao kuća";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
