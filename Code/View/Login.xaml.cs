using health_clinicClassDiagram.Model.Treatment;
using health_clinicClassDiagram.Repository;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        private List<Doctor> doktori = new List<Doctor>();
        public Login()
        {/*
            Doctor doctor = new Doctor(123456, "Marko", "Markovic");
            Patient patient = new Patient("Mika", "Mikic", 1234);
            ExamOperationRoom room = new ExamOperationRoom(222);
            Appointment app1 = new Appointment(doctor, patient, room, TypeOfAppointment.EXAM, DateTime.Today, DateTime.Today.AddHours(3));
            Appointment app2 = new Appointment(doctor, patient, room, TypeOfAppointment.EXAM, DateTime.Today.AddHours(7), DateTime.Today.AddHours(8));
            AppointmentRepository.Instance.Save(app1);
            AppointmentRepository.Instance.Save(app2);

            Surgeon surgeon1 = new Surgeon(123, "Pera", "Peric", Model.SystemUsers.Gender.MALE, DateTime.Today, SurgicalSpecialty.CARDIOTHORACIC);
            Surgeon surgeon2 = new Surgeon(333, "Ana", "Jovanovic", Model.SystemUsers.Gender.FEMALE, DateTime.Today, SurgicalSpecialty.NEUROSURGERY);
            SurgeonRepository.Instance.Save(surgeon1);
            SurgeonRepository.Instance.Save(surgeon2);

            ExamOperationRoom room1 = new ExamOperationRoom(1);
            ExamOperationRoom room2 = new ExamOperationRoom(2);
            List<ExamOperationRoom> examOperationRooms = new List<ExamOperationRoom>();
            examOperationRooms.Add(room1);
            examOperationRooms.Add(room2);
            ExamOperationRoomRepository.Instance.Save(room1);
            ExamOperationRoomRepository.Instance.Save(room2);
            ExamOperationRoomRepository.Instance.Save(room);
            Appointment surgery = new Appointment(surgeon1, patient, room, TypeOfAppointment.SURGERY, DateTime.Today.AddHours(5), DateTime.Today.AddHours(6));
            AppointmentRepository.Instance.Save(surgery);

            Specialist specialist1 = new Specialist(111, "Milos", "Milosevic", Model.SystemUsers.Gender.MALE, DateTime.Today, Specialization.CARDIOLOGY);
            Specialist specialist2 = new Specialist(212, "Dragan", "Jovanovic", Model.SystemUsers.Gender.FEMALE, DateTime.Today, Specialization.NEPHROLOGY);
            SpecialistRepository.Instance.Save(specialist1);
            SpecialistRepository.Instance.Save(specialist2);

            Appointment specAppointment = new Appointment(specialist1, patient, room, TypeOfAppointment.EXAM, DateTime.Today.AddHours(15), DateTime.Today.AddHours(17));
            AppointmentRepository.Instance.Save(specAppointment);

            RehabilitationRoom rehRoom1 = new RehabilitationRoom(1, 2, 5, new List<MedicalRecord>());
            RehabilitationRoom rehRoom2 = new RehabilitationRoom(2, 3, 15, new List<MedicalRecord>());
            RehabilitationRoomRepository.Instance.Save(rehRoom1);
            RehabilitationRoomRepository.Instance.Save(rehRoom2);

            Drug d1 = new Drug(1, "Paracematol 100mg", 15);
            Drug d2 = new Drug(2, "Aerius 50mg", 5);
            List<Drug> drugs = new List<Drug>();
            drugs.Add(d1);
            drugs.Add(d2);
            Prescription prescription = new Prescription(drugs);
            ScheduledSurgery scheduledSurgery = new ScheduledSurgery(DateTime.Today, DateTime.Today.AddHours(2), "Razlog operacije", surgeon1);
            DiagnosisAndReview diagnosisAndReview1 = new DiagnosisAndReview("Dijagnoza", "Procedura");
            ReferralToHospitalTreatment referralToHospitalTreatment = new ReferralToHospitalTreatment(DateTime.Today, DateTime.Today.AddHours(2), "Razlog bolnickog lecenja", drugs);
            SpecialistAppointment specialistAppointment = new SpecialistAppointment("Razlog za spec. termin", specialist2);
            Treatment treatment1 = new Treatment(prescription, scheduledSurgery, diagnosisAndReview1, referralToHospitalTreatment, DateTime.Today.AddHours(17), DateTime.Today.AddHours(19), 1, doctor, specialistAppointment);
            Treatment treatment2 = new Treatment(prescription, scheduledSurgery, diagnosisAndReview1, referralToHospitalTreatment, DateTime.Today.AddHours(15), DateTime.Today.AddHours(16), 2, doctor, specialistAppointment);
            List<Treatment> treatments = new List<Treatment>();
            treatments.Add(treatment1);
            treatments.Add(treatment2);
            MedicalRecord medicalRecord = new MedicalRecord(patient, treatments, doctor); //zameni sa ovim dole
//            MedicalRecord medicalRecord = new MedicalRecord(patient, new List<Treatment>(), doctor);
            MedicalRecordRepository.Instance.Save(medicalRecord);

            TreatmentRepository.Instance.Save(treatment1);
            TreatmentRepository.Instance.Save(treatment2);

            Treatment treatmentMedRec = MedicalRecordRepository.Instance.GetTreatmentByTreatmentId(treatment1.Id);
            MedicalRecord medRecByTreatment = MedicalRecordRepository.Instance.GetMedRecByPatient(patient);
//            List<Treatment> medTreatments = medRecByTreatment.Treatments;
 //           Console.WriteLine(treatmentMedRec.Id + " " + treatmentMedRec.FromDate);

            //            Doctor doctor = new Doctor(123456, "Marko", "Markovic");
            Drug d3 = new Drug(4, "Aspirin 100mg", 15);
            Drug d4 = new Drug(6, "Xyzal 50mg", 2);
            List <Drug> drugs2 = new List<Drug>();
            drugs2.Add(d3);
            drugs2.Add(d3);
            drugs2.Add(d3);
            drugs2.Add(d4);
            drugs2.Add(d4);
            drugs2.Add(d4);
            drugs2.Add(d4);
            drugs2.Add(d1);
            drugs2.Add(d2);
            Prescription prescription2 = new Prescription(drugs2);
            Treatment treatment3 = new Treatment(prescription2, scheduledSurgery, diagnosisAndReview1, referralToHospitalTreatment, DateTime.Today.AddDays(2), DateTime.Today.AddDays(2).AddHours(2), 3, doctor, specialistAppointment);
            TreatmentRepository.Instance.Save(treatment3);

            Doctor doctor2 = new Doctor(2233, "Pera", "Perić");
            doktori.Add(doctor);
            doktori.Add(doctor2);*/
            InitializeComponent();
            DataContext = this;
        }

        public List<Doctor> Doktori { get => doktori; set => doktori = value; }

        private void buttonPrijaviSe_Click(object sender, RoutedEventArgs e)
        {
            Boolean postoji = false;            

            foreach(Doctor oneDoctor in doktori)
            {
                if(oneDoctor.Username.Equals(textBoxUsername.Text) || oneDoctor.Password.Equals(passwordBox.Password))
                {
                    PocetnaUser pocetnaUser = new PocetnaUser(oneDoctor);
                    (this.Parent as Panel).Children.Add(pocetnaUser);
                    return;
                }
            }
            String message = "Pogrešan Username ili Password, molim vas pokušajte ponovo";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBox.Show(message, "Pogrešni podaci!", button, MessageBoxImage.Error);
            return;


        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Unesti Username i Password i pritisnite na dugme \"Prijavi se\" kako bi se prijavili na svoj nalog.";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
