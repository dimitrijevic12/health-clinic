using Model.SystemUsers;
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
    /// Interaction logic for RasporedUser.xaml
    /// </summary>
    public partial class RasporedUser : UserControl
    {
        Doctor doctor;

        public Doctor Doctor { get => doctor; set => doctor = value; }

        public RasporedUser(Doctor doctor)
        {
            Doctor = doctor;
            InitializeComponent();
        }

        private void buttonIdiNaDatum_Click(object sender, RoutedEventArgs e)
        {
            if (calendar.SelectedDate == null)
            {
                MessageBox.Show("Morate izabrati jedan datum!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DateTime day = (DateTime)calendar.SelectedDate.Value;
            UserControl rasporedTermini = new RasporedTerminiUser(day, doctor);
            (this.Parent as Panel).Children.Add(rasporedTermini);
        }

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
            String message = "Kada izaberete jedan datum i kliknete dugme \"Idi na datum\", dobićete listu vaših zakazanih termina.";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
