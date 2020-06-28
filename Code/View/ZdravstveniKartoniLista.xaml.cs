using health_clinicClassDiagram.Controller;
using Model.SystemUsers;
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
    /// Interaction logic for ZdravstveniKartoniLista.xaml
    /// </summary>
    public partial class ZdravstveniKartoniLista : UserControl
    {
        private List<Patient> patients = PatientController.Instance.GetAll();
        public ZdravstveniKartoniLista()
        {
            InitializeComponent();
            DataContext = this;
        }

        public List<Patient> Patients { get => patients; set => patients = value; }

        private void buttonOtvori_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridPacijenti.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati jednog pacijenta!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Patient patient = dataGridPacijenti.SelectedItem as Patient; 
            UserControl usc = new ZdravstveniKartoniPacijent(patient);
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

        private void textBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            List<Patient> patients = new List<Patient>();
            foreach (Patient patient in Patients)
            {
                if (patient.Name.ToLower().StartsWith(textBox.Text) || (patient.Surname.ToLower().StartsWith(textBox.Text)) || (patient.Id.ToString().ToLower().StartsWith(textBox.Text)))
                {
                    patients.Add(patient);
                }
            }
            dataGridPacijenti.ItemsSource = patients;
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Kada izaberete pacijenta i kliknete na dugme \"Otvori\", prelazite na prozor koji sadrži listu prethodnih pregleda izabranog pacijenta. Pacijenta možete pretražiti po imenu ili prezimenu ili njegovom jmbg-u.";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
