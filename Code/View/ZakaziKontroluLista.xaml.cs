using Controller;
using health_clinicClassDiagram.Repository;
using Model.Appointment;
using Model.Rooms;
using Model.Treatment;
using Repository;
using System;
using System.Collections;
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
using View.Util;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for ZakaziKontroluLista.xaml
    /// </summary>
    public partial class ZakaziKontroluLista : UserControl
    {
        private Appointment appointment;
        private DateTime day;
        private List<ExamOperationRoom> allRooms = ExamOperationRoomRepository.Instance.GetAll();
        public ObservableCollection<Appointment> AppointmentsToShow
        {
            get;
            set;
        }
        public Appointment Appointment { get => appointment; set => appointment = value; }
        public DateTime Day { get => day; set => day = value; }
        public List<ExamOperationRoom> AllRooms { get => allRooms; set => allRooms = value; }

        public ZakaziKontroluLista(Appointment thisAppointment, DateTime day)
        {
            InitializeComponent();
            ExamOperationRoom room = ExamOperationRoomRepository.Instance.GetAll()[0];
            List<Appointment> blankAppointments = AppointmentGenerator.Instance.generateList(day);
            AppointmentsToShow = new ObservableCollection<Appointment>(blankAppointments);
            foreach (Appointment blankAppointment in blankAppointments)
            {
                foreach (Appointment appointment in AppointmentController.Instance.GetAppointmentsByDayAndDoctorAndRoomAndPatient(day, thisAppointment.Doctor, room, thisAppointment.Patient))
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
            Day = day;
            Appointment = thisAppointment;
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
            String message = "Kontrolni pregled će biti zakazan\n\n Da li ste sigurni da želite da potvrdite sve informacije o kontrolnom pregledu?";
            MessageBoxButton button = MessageBoxButton.OKCancel;
            MessageBoxResult result = MessageBox.Show(message, "Potvrda kontrolnog pregleda", button, MessageBoxImage.Question);

            if (result == MessageBoxResult.Cancel)
            {
                return;
            }
            else
            {
                DateTime startDate = appointments[0].StartDate;
                DateTime endDate = appointments[appointments.Count - 1].EndDate;
                ExamOperationRoom room = (ExamOperationRoom)comboBoxListaSoba.SelectedItem;
                Appointment controlAppointment = new Appointment(Appointment.Doctor, Appointment.Patient, room, TypeOfAppointment.EXAM, startDate, endDate);
                AppointmentRepository.Instance.Save(controlAppointment);
                int thisCount = (this.Parent as Panel).Children.IndexOf(this);
                (this.Parent as Panel).Children.RemoveRange(5, thisCount);
                return;
            }
            ;
        }

        private void comboBoxListaSoba_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ExamOperationRoom room = (ExamOperationRoom)comboBoxListaSoba.SelectedItem;
            if (room == null) room = ExamOperationRoomRepository.Instance.GetAll()[0];
            List<Appointment> blankAppointments = AppointmentGenerator.Instance.generateList(Day);
            AppointmentsToShow = new ObservableCollection<Appointment>(blankAppointments);
            foreach (Appointment blankAppointment in blankAppointments)
            {
                foreach (Appointment appointment in AppointmentController.Instance.GetAppointmentsByDayAndDoctorAndRoomAndPatient(Day, Appointment.Doctor, room, Appointment.Patient))
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
            String message = "Kada izaberete slobodne termine i kliknete na dugme \"Potvrdi zakazivanje\", kontrolni pregled će biti zakazan";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
