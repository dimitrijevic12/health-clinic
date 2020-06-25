using health_clinicClassDiagram.Model.Treatment;
using Model.Appointment;
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
    /// Interaction logic for DatumZaOperacijuKalendar.xaml
    /// </summary>
    public partial class KalendarZaSpecijalistu : UserControl
    {
        private Specialist specialist;
        private String cause;
        private Patient patient;
        private SpecialistAppointment specialistAppointment;

        public Specialist Specialist { get => specialist; set => specialist = value; }
        public string Cause { get => cause; set => cause = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public SpecialistAppointment SpecialistAppointment { get => specialistAppointment; set => specialistAppointment = value; }

        public KalendarZaSpecijalistu(Specialist specialist, String cause, Patient patient, SpecialistAppointment specialistAppointment)
        {
            Specialist = specialist;
            Cause = cause;
            Patient = patient;
            SpecialistAppointment = specialistAppointment;
            InitializeComponent();
            DataContext = this;
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Ako napustite pregled sve izmene koje ste napravili će biti poništene\n\nDa li ste sigurni da želite da napustite pregled?";
            MessageBoxButton button = MessageBoxButton.OKCancel;
            MessageBoxResult result = MessageBox.Show(message, "Prekidanje pregleda", button, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Cancel)
            {
                return;
            }
            else
            {
                int thisCount = (this.Parent as Panel).Children.IndexOf(this);
                (this.Parent as Panel).Children.RemoveRange(3, thisCount);
                return;
            }
        }

        private void buttonIdiNaDatum_Click(object sender, RoutedEventArgs e)
        {
            if (calendar.SelectedDate == null)
            {
                MessageBox.Show("Morate izabrati jedan datum!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DateTime day = (DateTime)calendar.SelectedDate;
            UserControl usc = new TerminiZakazivanjeSpecijalista(specialist, cause, day, TypeOfAppointment.EXAM, Patient, specialistAppointment);
            (this.Parent as Panel).Children.Add(usc);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
            return;
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Kada izaberete jedan datum i kliknete dugme \"Idi na datum\", dobićete listu zakazanih i slobodnih termina.";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
