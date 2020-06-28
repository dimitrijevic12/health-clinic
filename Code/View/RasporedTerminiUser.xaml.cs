using Controller;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Repository;
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
    /// Interaction logic for RasporedTerminiUser.xaml
    /// </summary>
    public partial class RasporedTerminiUser : UserControl
    {
        List<Appointment> appointmentsToShow;
        private DateTime day;
        private Doctor doctor;
        public DateTime Day { get => day; set => day = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }
        public List<Appointment> AppointmentsToShow { get => appointmentsToShow; set => appointmentsToShow = value; }

        public RasporedTerminiUser(DateTime day, Doctor doctor)
        {
            List<Appointment> blankAppointments = AppointmentGenerator.Instance.generateList(day);
            AppointmentsToShow = AppointmentGenerator.Instance.generateList(day);
            foreach (Appointment blankAppointment in blankAppointments)
            {
                foreach (Appointment appointment in AppointmentController.Instance.GetAppointmentsByDayAndDoctor(day, doctor))
                {
                    if (blankAppointment.StartDate == appointment.StartDate)
                    {
                        int index = AppointmentsToShow.FindIndex(apt => apt.StartDate == blankAppointment.StartDate);
                        AppointmentsToShow[index] = appointment;
                    }
                    else if (blankAppointment.StartDate >= appointment.StartDate && blankAppointment.EndDate <= appointment.EndDate)
                    {
                        int index = AppointmentsToShow.FindIndex(apt => apt.StartDate == blankAppointment.StartDate);
                        AppointmentsToShow.RemoveAt(index);
                    }
                }
            }
            Doctor = doctor;
            Day = day;
            InitializeComponent();
            DataContext = this;
        }

        private void buttonPregledTermina_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati jedan zakazan termin!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Appointment appointment = (Appointment)listView.SelectedItem;
            if (appointment.Patient == null)
            {
                MessageBox.Show("Morate izabrati jedan zakazan termin!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
//            Console.WriteLine(appointment.Patient.Name);
            UserControl usc = new PregledTerminaUser(appointment);
            (this.Parent as Panel).Children.Add(usc);
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
            String message = "Kada izaberete jedan zakazan termin i kliknete na dugme \"Prikaži termin\", otvoriće se detaljan prikaz termina";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
