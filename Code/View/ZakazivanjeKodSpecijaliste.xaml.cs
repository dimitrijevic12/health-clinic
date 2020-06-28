using health_clinicClassDiagram.Model.Treatment;
using health_clinicClassDiagram.Repository;
using Model.Appointment;
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
    public partial class ZakazivanjeKodSpecijaliste : UserControl
    {
        private List<Specialist> specialists = SpecialistRepository.Instance.GetAll();
        private DateTime startDate;
        private DateTime endDate;
        private Appointment appointment;
        private SpecialistAppointment specialistAppointment;
        public ZakazivanjeKodSpecijaliste(Appointment appointment, SpecialistAppointment specialistAppointment)
        {
            Appointment = appointment;
            SpecialistAppointment = specialistAppointment;
            InitializeComponent();
            DataContext = this;
        }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public Appointment Appointment { get => appointment; set => appointment = value; }
        public SpecialistAppointment SpecialistAppointment { get => specialistAppointment; set => specialistAppointment = value; }
        public List<Specialist> Specialists { get => specialists; set => specialists = value; }

        private void buttonOdaberiDatum_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati bar jednog specijalistu!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (textBoxRazlog.Text.Equals(""))
            {
                MessageBox.Show("Morate napisati razlog zakazivanja kod specijaliste!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            String cause = textBoxRazlog.Text;
            Specialist specialist = (Specialist)dataGrid.SelectedItem;
            UserControl usc = new KalendarZaSpecijalistu(specialist, cause, appointment.Patient, specialistAppointment);
            (this.Parent as Panel).Children.Add(usc);
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

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Informacije o specijalističkom pregledu neće biti zapamćene!\n\nDa li ste sigurni da želite da prestanete sa zakazivanjem pregleda";
            MessageBoxButton button = MessageBoxButton.OKCancel;
            MessageBoxResult result = MessageBox.Show(message, "Zakazivanje operacije", button, MessageBoxImage.Warning);

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

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Kada izaberete specijalistu i napišete razlog za zakazivanje pregleda kod specijaliste, možete kliknuti na dugme \"Odaberi datum\" koje će vas poslati na prozor za biranje datuma pregleda";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
