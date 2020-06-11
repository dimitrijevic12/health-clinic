using Model.Appointment;
using Model.Treatment;
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
using View.Util;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for ZapocniPregled.xaml
    /// </summary>
    public partial class ZapocniPregled : UserControl
    {
        List<Appointment> blankAppointments = AppointmentGenerator.Instance.generateList(DateTime.Today);

        public List<Appointment> BlankAppointments { get => blankAppointments; set => blankAppointments = value; }

        public ZapocniPregled()
        {
            InitializeComponent();
            DataContext = this;
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

        private void buttonPregledTermina_Click(object sender, RoutedEventArgs e)
        {
            Appointment appointment = (Appointment) listView.SelectedItem;
            Treatment treatment = new Treatment(appointment.StartDate, appointment.EndDate);
            UserControl usc = new Pregled(treatment);
            (this.Parent as Panel).Children.Add(usc);
        }
    }
}
