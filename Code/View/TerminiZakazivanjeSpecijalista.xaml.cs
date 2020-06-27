using Controller;
using health_clinicClassDiagram.Model.Treatment;
using health_clinicClassDiagram.Repository;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
using Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for TerminZaOperaciju.xaml
    /// </summary>
    public partial class TerminiZakazivanjeSpecijalista : UserControl
    {
//        List<Appointment> appointmentsToShow;
        private Doctor doctor;
        private String cause;
        private DateTime day;
        private List<ExamOperationRoom> allRooms = ExamOperationRoomRepository.Instance.GetAll();
        private TypeOfAppointment type;
        private Patient patient;
        private SpecialistAppointment specialistAppointment;
        public ObservableCollection<Appointment> AppointmentsToShow
        {
            get;
            set;
        }
        public string Cause { get => cause; set => cause = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }
 //       public List<Appointment> AppointmentsToShow { get => appointmentsToShow; set => appointmentsToShow = value; }
        public List<ExamOperationRoom> AllRooms { get => allRooms; set => allRooms = value; }
        public DateTime Day { get => day; set => day = value; }
        public TypeOfAppointment Type { get => type; set => type = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public SpecialistAppointment SpecialistAppointment { get => specialistAppointment; set => specialistAppointment = value; }

        public TerminiZakazivanjeSpecijalista(Doctor doctor, String cause, DateTime day, TypeOfAppointment type, Patient patient, SpecialistAppointment specialistAppointment)
        {
            InitializeComponent();
            Day = day;
            Type = type;
            Patient = patient;
            SpecialistAppointment = specialistAppointment;
            //ExamOperationRoom room = (ExamOperationRoom)comboBoxListaSoba.SelectedItem;
            ExamOperationRoom room = new ExamOperationRoom(1);
            List<Appointment> blankAppointments = AppointmentGenerator.Instance.generateList(day);
            AppointmentsToShow = new ObservableCollection<Appointment>(blankAppointments);
            foreach (Appointment blankAppointment in blankAppointments)
            {
                foreach (Appointment appointment in AppointmentController.Instance.GetAppointmentsByDayAndDoctorAndRoomAndPatient(day, doctor, room, patient))
                {
                    if (blankAppointment.StartDate == appointment.StartDate)
                    {
                        int index =  AppointmentsToShow.IndexOf(blankAppointment);
                        AppointmentsToShow[index] = appointment;
                    }
                    else if (blankAppointment.StartDate >= appointment.StartDate && blankAppointment.EndDate <= appointment.EndDate)
                    {
                        int index = AppointmentsToShow.IndexOf(blankAppointment);
                        AppointmentsToShow.RemoveAt(index);
                    }
                }
            }
            Doctor = doctor;
            Cause = cause;
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

        private void buttonPotvrdiZakazivanje_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati slobodne termine!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            List<Appointment> appointments = new List<Appointment>();
            IList rows = listView.SelectedItems;
            foreach (var row in rows)
            {
                Appointment appointment = (Appointment)row;
                if (appointment.Patient != null)
                {
                    MessageBox.Show("Morate izabrati slobodne termine!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                appointments.Add((Appointment)row);
            }

            String message = "Pregled kod specijaliste će biti zakazan\n\n Da li ste sigurni da želite da potvrdite sve informacije o pregledu kod specijaliste?";
            MessageBoxButton button = MessageBoxButton.OKCancel;
            MessageBoxResult result = MessageBox.Show(message, "Potvrda pregleda kod specijaliste", button, MessageBoxImage.Question);

            if (result == MessageBoxResult.Cancel)
            {
                return;
            }
            else
            {
                DateTime startDate = appointments[0].StartDate;
                DateTime endDate = appointments[appointments.Count - 1].EndDate;
                ExamOperationRoom room = (ExamOperationRoom)comboBoxListaSoba.SelectedItem;
                Appointment specialistAppointment = new Appointment(Doctor, Patient, room, Type, startDate, endDate);
                AppointmentController.Instance.Create(specialistAppointment);

                SpecialistAppointment.Cause = Cause;
                SpecialistAppointment.Doctor = Doctor;
                int thisCount = (this.Parent as Panel).Children.IndexOf(this);
                (this.Parent as Panel).Children.RemoveRange(5, thisCount);
                return;
            }
        }

        private void comboBoxListaSoba_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ExamOperationRoom room = (ExamOperationRoom)comboBoxListaSoba.SelectedItem;
            if (room == null) room = new ExamOperationRoom(0);
            List<Appointment> blankAppointments = AppointmentGenerator.Instance.generateList(Day);
            AppointmentsToShow = new ObservableCollection<Appointment>(blankAppointments);
            foreach (Appointment blankAppointment in blankAppointments)
            {
                foreach (Appointment appointment in AppointmentController.Instance.GetAppointmentsByDayAndDoctorAndRoomAndPatient(Day, doctor, room, Patient))
                {
                    if (blankAppointment.StartDate == appointment.StartDate)
                    {
                        int index = AppointmentsToShow.IndexOf(blankAppointment);
//                        int index = AppointmentsToShow.FindIndex(apt => apt.StartDate == blankAppointment.StartDate);
                        AppointmentsToShow[index] = appointment;
                    }
                    else if (blankAppointment.StartDate >= appointment.StartDate && blankAppointment.EndDate <= appointment.EndDate)
                    {
                        int index = AppointmentsToShow.IndexOf(blankAppointment);
//                        int index = AppointmentsToShow.FindIndex(apt => apt.StartDate == blankAppointment.StartDate);
                        AppointmentsToShow.RemoveAt(index);
                    }
                }
            }
            listView.ItemsSource = AppointmentsToShow;
        }
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
            return;
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Kada izaberete slobodne termine i kliknete na dugme \"Potvrdi zakazivanje\", pregled kod specijaliste će biti zakazan";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
