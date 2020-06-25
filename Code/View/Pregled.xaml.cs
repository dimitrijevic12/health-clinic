using Model.Appointment;
using Model.Rooms;
using Model.Treatment;
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

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for Pregled.xaml
    /// </summary>
    public partial class Pregled : UserControl
    {
        private Treatment treatment;
        private Appointment appointment;
        private MedicalRecord medicalRecord;
        private String lastDiagnosisAndReview;
        public Treatment Treatment { get => treatment; set => treatment = value; }
        public Appointment Appointment { get => appointment; set => appointment = value; }
        public MedicalRecord MedicalRecord { get => medicalRecord; set => medicalRecord = value; }
        public String LastDiagnosisAndReview { get => lastDiagnosisAndReview; set => lastDiagnosisAndReview = value; }

        // private String _imePrezime = "Jovan Jovanovic";
        public Pregled(Appointment appointment, Treatment treatment)
        {
            //            MedicalRecord = MedicalRecordRepository.Instance.GetMedRecByPatient(appointment.Patient);
 //           DiagnosisAndReview lastDiagnosis = TreatmentRepository.Instance.FindLastDiagnosisAndReview(appointment.Patient);
 //           LastDiagnosisAndReview = lastDiagnosis.Diagnosis;
            InitializeComponent();
            Appointment = appointment;
            Treatment = treatment;
            Treatment.Prescription = new Prescription();
            Treatment.Prescription.Drug = new List<Drug>();
            Treatment.ScheduledSurgery = new ScheduledSurgery();
            Treatment.SpecialistAppointment = new Model.Treatment.SpecialistAppointment();
            Treatment.ReferralToHospitalTreatment = new ReferralToHospitalTreatment();
            Treatment.ReferralToHospitalTreatment.Drugs = new List<Drug>();
            Treatment.Doctor = Appointment.Doctor;
            DataContext = this;
        }

        private void buttonNapisiRecept_Click(object sender, RoutedEventArgs e)
        {
            //            this.Content = new NapisiRecept(_imePrezime);
            //            this.Content = napisiRecept;
            dropDownButton.IsOpen = false;
            UserControl usc = new NapisiRecept(appointment, treatment.Prescription);
            (this.Parent as Panel).Children.Add(usc);
            //            this.mainPanel.Children.Remove();
            //            this.mainPanel.Children.Add(napisiRecept);
            //            (this.Parent as Panel).Children.Add(napisiRecept);
            //            this.Content = this.;
            //            this.Content = new NapisiRecept();
        }

        private void buttonNapisiUputZaOperaciju_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            UserControl usc = new ZakazivanjeOperacije(appointment, treatment.ScheduledSurgery);
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonNapisiUputZaSpecijalistu_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            UserControl usc = new ZakazivanjeKodSpecijaliste(appointment, treatment.SpecialistAppointment);
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonZahtevZaBolnickoLecenje_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            UserControl usc = new ZahtevZaBolnickoLecenje(Appointment, Treatment.ReferralToHospitalTreatment);
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonNapisiIzvestaj_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            UserControl usc = new DijagnozaProcedura(Treatment, Appointment.Patient);
            (this.Parent as Panel).Children.Add(usc);
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            MessageBoxButton button = MessageBoxButton.YesNo;
            String message = "Ako napustite pregled sve izmene koje ste napravili će biti poništene\n\nDa li ste sigurni da želite da napustite pregled?";
            MessageBoxResult result = MessageBox.Show(message, "Napuštate pregled!", button, MessageBoxImage.Information);
            if (result == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                int thisCount = (this.Parent as Panel).Children.IndexOf(this);
                (this.Parent as Panel).Children.RemoveRange(3, thisCount);
            }
        }

        private void buttonZakaziKontrolu_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            UserControl usc = new ZakaziKontrolu(Appointment);
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonIstorijaBolesti_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            UserControl usc = new PregledZdravstveniKartoniPacijent(Appointment.Patient);
            (this.Parent as Panel).Children.Add(usc);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxButton button = MessageBoxButton.YesNo;
            String message = "Ako napustite pregled sve izmene koje ste napravili će biti poništene\n\nDa li ste sigurni da želite da napustite pregled?";
            MessageBoxResult result = MessageBox.Show(message, "Napuštate pregled!", button, MessageBoxImage.Information);
            if(result == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                (this.Parent as Panel).Children.Remove(this);
            }
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Klikom na dugme koje se nalazi desno od dugmeta za help, dobićete listu komandi:\n\n" +
                "\nKlikom na dugme \"Napiši recept\" prelazite na prozor koji koji služi za pisanje recepta\n" +
                "\nKlikom na dugme \"Zakaži operaciju\" prelazite na prozor koji služi za zakazivanje operacije\n" +
                "\nKlikom na dugme \"Zakaži kod specijaliste\" prelazite na prozor koji služi za zakazivanje pregleda kod specijaliste\n" +
                "\nKlikom na dugme \"Zakaži kontrolu\" prelazite na prozor koji služi za zakazivanje kontrolnog pregleda\n" +
                "\nKlikom na dugme \"Zahtev za bolničko lečenje\" prelazite na prozor koji služi za pisanje zahteva za bolničko lečenje\n" +
                "\nKlikom na dugme \"Istorija bolesti\" prelazite na prozor koji sadrži listu prethodnih pregleda pacijenta kojeg trenutno pregledate\n" +
                "\nKlikom na dugme \"Napiši izveštaj\" prelazite na prozor koji služi za pisanje izveštaja i procedure koja je obavljena u toku pregleda, kada unesete dijagnozu i proceduru možete završiti sa pregledom";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
