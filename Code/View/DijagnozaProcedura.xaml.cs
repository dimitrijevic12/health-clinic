using Controller;
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
    /// Interaction logic for DijagnozaProcedura.xaml
    /// </summary>
    public partial class DijagnozaProcedura : UserControl
    {
        private Treatment treatment;
        private Patient patient;
        public DijagnozaProcedura(Treatment treatment, Patient patient)
        {
            Treatment = treatment;
            Patient = patient;
            InitializeComponent();
        }

        public Treatment Treatment { get => treatment; set => treatment = value; }
        public Patient Patient { get => patient; set => patient = value; }

        private void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            String diagnnosis = textBoxDijagnoza.Text;
            String review = textBoxProcedura.Text;
            Treatment.DiagnosisAndReview = new DiagnosisAndReview(diagnnosis, review);
            TreatmentRepository.Instance.Save(Treatment);
            MedicalRecordRepository.Instance.AddTreatmentToMedRec(Patient, Treatment);
            

            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }
    }
}
