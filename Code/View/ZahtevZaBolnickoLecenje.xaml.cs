using Controller;
using health_clinicClassDiagram.Controller;
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

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for ZahtevZaBolnickoLecenje.xaml
    /// </summary>
    public partial class ZahtevZaBolnickoLecenje : UserControl
    {
        private Appointment appointment;
        private ReferralToHospitalTreatment referralToHospitalTreatment;
        private List<RehabilitationRoom> allRooms = RehabilitationRoomController.Instance.GetAll();
        private List<Drug> allDrugs = DrugRepository.Instance.GetAll();
        private DateTime startDate;
        private DateTime endDate;
        private String cause;

        public ObservableCollection<Drug> PresrcibedDrugs
        {
            get;
            set;
        }

        public Appointment Appointment { get => appointment; set => appointment = value; }
        public ReferralToHospitalTreatment ReferralToHospitalTreatment { get => referralToHospitalTreatment; set => referralToHospitalTreatment = value; }
        public List<RehabilitationRoom> AllRooms { get => allRooms; set => allRooms = value; }
        public List<Drug> AllDrugs { get => allDrugs; set => allDrugs = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string Cause { get => cause; set => cause = value; }

        public ZahtevZaBolnickoLecenje(Appointment appointment, ReferralToHospitalTreatment referralToHospitalTreatment)
        {
            Appointment = appointment;
            ReferralToHospitalTreatment = referralToHospitalTreatment;
            PresrcibedDrugs = new ObservableCollection<Drug>(referralToHospitalTreatment.Drugs);
            
            if (ReferralToHospitalTreatment.CauseForHospitalTreatment == null)
            {
                Cause = "";
            }
            else
            {
                Cause = ReferralToHospitalTreatment.CauseForHospitalTreatment;
            }

            DataContext = this;
            InitializeComponent();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Ako napustite pregled sve izmene koje ste napravili će biti poništene\n\nDa li ste sigurni da želite da napustite pregled?";
            MessageBoxButton button = MessageBoxButton.OKCancel;
            MessageBoxResult result = MessageBox.Show(message, "Bolničko lečenje", button, MessageBoxImage.Warning);

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

        private void buttonPotvdriLecenje_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxRazlogBolnickogLecenja.Text == "")
            {
                String message2 = "Morate uneti razlog za bolničko lečenje";
                MessageBoxButton button2 = MessageBoxButton.OK;
                MessageBox.Show(message2, "Bolničko lečenje", button2, MessageBoxImage.Error);
                return;
            }

            String message = "Zahtev za bolničko lečenje će biti sačuvan\n\n Da li ste sigurni da želite da potvrdite sve informacije o zahtevu za bolničko lečenje?";
            MessageBoxButton button = MessageBoxButton.OKCancel;
            MessageBoxResult result = MessageBox.Show(message, "Potvrda bolničkog lečenja", button, MessageBoxImage.Question);

            if (result == MessageBoxResult.Cancel)
            {
                return;
            }
            else
            {
                ReferralToHospitalTreatment.CauseForHospitalTreatment = textBoxRazlogBolnickogLecenja.Text;
                ReferralToHospitalTreatment.Drugs = new List<Drug>((IEnumerable<Drug>)PresrcibedDrugs);
                RehabilitationRoom rehabilitationRoom = dataGridSobe.SelectedItem as RehabilitationRoom;
                MedicalRecord medicalRecord = MedicalRecordController.Instance.GetMedicalRecordByPatient(Appointment.Patient);
                RehabilitationRoomController.Instance.AddPatient(medicalRecord, rehabilitationRoom);
                int thisCount = (this.Parent as Panel).Children.IndexOf(this);
                (this.Parent as Panel).Children.RemoveRange(5, thisCount);
                return;
            }
        }

        private void buttonDodajLek_Click(object sender, RoutedEventArgs e)
        {
            IList rows = dataGridSviLekovi.SelectedItems;
            foreach (var row in rows)
            {
                PresrcibedDrugs.Add((Drug)row);
                DoctorDrugController doctorDrugController = new DoctorDrugController(new DrugController());
                doctorDrugController.LowerQuantity((Drug)row);
            }
        }

        private void buttonObrisiLek_Click(object sender, RoutedEventArgs e)
        {
            var row = dataGridDodati.SelectedItem;
            PresrcibedDrugs.Remove((Drug)row);
            DoctorDrugController doctorDrugController = new DoctorDrugController(new DrugController());
            doctorDrugController.IncreaseQuantity((Drug)row);

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Sve informacije o bolničkom lečenju će biti obrisane!\n\nDa li ste sigurni da želite da prestanete sa pisanjem zahteva za bolničko lečenje?";
            MessageBoxButton button = MessageBoxButton.OKCancel;
            MessageBoxResult result = MessageBox.Show(message, "Potvrda recepta", button, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Cancel)
            {
                return;
            }
            else
            {
                (this.Parent as Panel).Children.Remove(this);
                return;
            }
        }

        private void textBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            List<Drug> drugs = new List<Drug>();
            foreach (Drug drug in AllDrugs)
            {
                if (drug.Name.ToLower().StartsWith(textBox.Text))
                {
                    drugs.Add(drug);
                }
            }
            dataGridSviLekovi.ItemsSource = drugs;
        }

        private void textBoxSobe_KeyUp(object sender, KeyEventArgs e)
        {
            List<RehabilitationRoom> rooms = new List<RehabilitationRoom>();
            foreach (RehabilitationRoom room in AllRooms)
            {
                if (room.Id.ToString().ToLower().StartsWith(textBoxSobe.Text))
                {
                    rooms.Add(room);
                }
            }
            dataGridSobe.ItemsSource = rooms;
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Klikom na dugme \"Dodaj\", dodajete jedan ili više izabranih lekova u prepisane lekove. Možete pretražiti sve lekove po imenu\n" +
                "\nKlikom na dugme \"Obriši\" brišete lek iz liste prepisanih lekova\n" +
                "\nPotrebno je izabrati datum, sobu i napisati razlog zahteva za bolničko lečenje. Sobe možete pretražiti po njihovom Id-u" +
                "\nKada unesete sve potrebne informacije, klikom na dugme \"Potvrdi lečenje\" završavate sa pisanjem zahteva za bolničko lečenje i zahtev je sačuvan\n";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
