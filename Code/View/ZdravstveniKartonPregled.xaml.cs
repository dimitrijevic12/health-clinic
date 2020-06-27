using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
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

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for ZdravstveniKartonPregled.xaml
    /// </summary>
    public partial class ZdravstveniKartonPregled : UserControl
    {
        private Treatment treatment;
        private Patient patient;
        private String surgicalSpecialty;
        private String specialization;
        private List<Drug> prescription;
        private List<Drug> hospTreatmentDrugs;
        private String diagnosis;
        private String review;
        public ZdravstveniKartonPregled(Treatment treatment, Patient patient)
        {
            Treatment = treatment;
            Patient = patient;
            SurgicalSpecialty = treatment.ScheduledSurgery.Surgeon.SurgicalSpecialty.ToString().ToLower();
            Prescription = Treatment.Prescription.Drugs;
            HospTreatmentDrugs = Treatment.ReferralToHospitalTreatment.Drugs;
            Diagnosis = treatment.DiagnosisAndReview.Diagnosis;
            Review = treatment.DiagnosisAndReview.Review;
//            Specialization = treatment.SpecialistAppointment.Doctor.Spec.ToString().ToLower();
            InitializeComponent();
            DataContext = this;
        }

        public Treatment Treatment { get => treatment; set => treatment = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public string SurgicalSpecialty { get => surgicalSpecialty; set => surgicalSpecialty = value; }
        public string Specialization { get => specialization; set => specialization = value; }
        public List<Drug> Prescription { get => prescription; set => prescription = value; }
        public List<Drug> HospTreatmentDrugs { get => hospTreatmentDrugs; set => hospTreatmentDrugs = value; }
        public string Diagnosis { get => diagnosis; set => diagnosis = value; }
        public string Review { get => review; set => review = value; }

        private void homeButton_Click(object sender, RoutedEventArgs e)
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
            String message = "Klikom na strelicu na dole, otvarate detaljan prikaz tog dela pregleda\n" +
                "\nMožete se vratiti na početnu stranu klikom na dugme koje izgleda kao strelica koja pokazuje levo, ili se možete vratiti na početnu stranu klikom na dugme koje izgleda kao kuća";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
