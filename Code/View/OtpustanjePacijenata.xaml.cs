using Controller;
using health_clinicClassDiagram.Controller;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
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

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for OdobravanjeLekova.xaml
    /// </summary>
    public partial class OtpustanjePacijenata : UserControl
    {
        private List<RehabilitationRoom> rooms = RehabilitationRoomController.Instance.GetAll();
        public ObservableCollection<Patient> Patients
        {
            get;
            set;
        }
        public List<RehabilitationRoom> Rooms { get => rooms; set => rooms = value; }

        public OtpustanjePacijenata()
        {
            InitializeComponent();
            Patients = new ObservableCollection<Patient>();
            RehabilitationRoom room = RehabilitationRoomController.Instance.GetAll()[0];
            RehabilitationRoom rehabilitationRoom = RehabilitationRoomController.Instance.getRoom(room);
            foreach (MedicalRecord medicalRecord in rehabilitationRoom.Patients)
            {
                Patients.Add(medicalRecord.Patient);
            }

            dataGridPacijenti.ItemsSource = Patients;
            
            DataContext = this;
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void buttonOdobriLek_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
            return;
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Klikom na dugme \"Odobri lek\", odobravate lek i on se briše iz liste lekova koji još nisu odobreni.";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void buttonOtpusti_Click(object sender, RoutedEventArgs e)
        {
            IList rows = dataGridPacijenti.SelectedItems;
            List<Patient> patientToRelease = new List<Patient>();
            foreach (var row in rows)
            {
                Patient patient = (Patient)row;
                patientToRelease.Add(patient);
            }
            foreach(Patient patient in patientToRelease)
            {
                RehabilitationRoomController.Instance.releasePatient(MedicalRecordController.Instance.GetMedicalRecordByPatient(patient), comboBoxListaSoba.SelectedItem as RehabilitationRoom);
                Patients.Remove(patient);
            }
        }

        private void comboBoxListaSoba_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Patients = new ObservableCollection<Patient>();
            RehabilitationRoom room = (RehabilitationRoom)comboBoxListaSoba.SelectedItem;
            RehabilitationRoom rehabilitationRoom = RehabilitationRoomController.Instance.getRoom(room);
            foreach(MedicalRecord medicalRecord in rehabilitationRoom.Patients)
            {
                Patients.Add(medicalRecord.Patient);
            }

            dataGridPacijenti.ItemsSource = Patients;
        }
    }
}
