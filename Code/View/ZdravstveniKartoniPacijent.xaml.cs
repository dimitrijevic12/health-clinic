using Controller;
using Model.Appointment;
using Model.SystemUsers;
using Model.Treatment;
using Repository;
using System;
using System.Collections;
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
    /// Interaction logic for ZdravstveniKartoniPacijent.xaml
    /// </summary>
    public partial class ZdravstveniKartoniPacijent : UserControl
    {
        private Patient patient;
        private List<Treatment> treatments;
        private MedicalRecord medicalRecord;
        public ZdravstveniKartoniPacijent(Patient patient)
        {
            //            MedicalRecord medicalRecord = MedicalRecordRepository.Instance.GetMedRecByPatient(patient);
            MedicalRecord  = MedicalRecordController.Instance.GetMedicalRecordByPatient(patient);
            Treatments = medicalRecord.Treatments;
            Patient = patient;
            InitializeComponent();
            DataContext = this;
        }

        public Patient Patient { get => patient; set => patient = value; }
        public List<Treatment> Treatments { get => treatments; set => treatments = value; }
        public MedicalRecord MedicalRecord { get => medicalRecord; set => medicalRecord = value; }

        private void buttonOtvori_Click(object sender, RoutedEventArgs e)
        {
            if(dataGridTermini.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati jedan pregled", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Treatment treatment= (Treatment)dataGridTermini.SelectedItem;

            UserControl usc = new ZdravstveniKartonPregled(treatment, patient);
            (this.Parent as Panel).Children.Add(usc);
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
            return;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
            return;
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Potrebno je izabrati jedan od prethodnih pregleda pacijenta i klikom na dugme\"Otvori\" prelazite na detaljan prikaz pregleda";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
