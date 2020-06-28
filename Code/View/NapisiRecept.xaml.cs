using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using Model.Treatment;
using Model.Rooms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections;
using System;
using Model.Appointment;
using Controller;
using Repository;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for NapisiRecept.xaml
    /// </summary>
    public partial class NapisiRecept : UserControl
    {
        private Prescription prescription;
        Appointment appointment;
        public ObservableCollection<Drug> PresrcibedDrugs
        {
            get;
            set;
        }

        public Prescription Prescription { get => prescription; set => prescription = value; }
        public ObservableCollection<Drug> AllDrugs
        {
            get;
            set;
        }
        public Appointment Appointment { get => appointment; set => appointment = value; }

        public NapisiRecept(Appointment appointment, Prescription prescription)
        {
            InitializeComponent();
            DataContext = this;
            Prescription = prescription;
            PresrcibedDrugs = new ObservableCollection<Drug>(prescription.Drugs);
            //           foreach(Drug drug in prescription.Drug)
            //           {
            //               PresrcibedDrugs.Add(drug);
            //           }
            DoctorDrugController doctorDrugController = new DoctorDrugController(new DrugController());
            AllDrugs = new ObservableCollection<Drug>(doctorDrugController.GetValidatedDrugs());
            /*AllDrugs.Add(new Drug("Aerius 50mg", 2, 5));
            AllDrugs.Add(new Drug("Aspirin 100mg", 4, 15));
            AllDrugs.Add(new Drug("Strepsils pakovanje 10 tableta", 5, 30));
            AllDrugs.Add(new Drug("Xyzal 50mg", 6, 2));
            AllDrugs.Add(new Drug("Fervex pakovanje 5 komada", 7, 3));
            AllDrugs.Add(new Drug("Panklav 200mg", 2, 5));*/
            Appointment = appointment;
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Ako napustite pregled sve izmene koje ste napravili će biti poništene\n\nDa li ste sigurni da želite da napustite pregled?";
            MessageBoxButton button = MessageBoxButton.OKCancel;
            MessageBoxResult result = MessageBox.Show(message, "Potvrda recepta", button, MessageBoxImage.Warning);

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
            String message = "Svi prepisani lekovi neće biti sačuvani ako ne potvrdite recept!\n\nDa li ste sigurni da želite da prestanete sa pisanjem recepta?";
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

        private void buttonPotvrdiRecept_Click(object sender, RoutedEventArgs e)
        {
            String message = "Svi prepisani lekovi će biti sačuvani i moći ćete da ih ponovo promenite\n\n Da li ste sigurni da želite da potvrdite recept?";
            MessageBoxButton button = MessageBoxButton.OKCancel;
            MessageBoxResult result = MessageBox.Show(message, "Potvrda recepta", button, MessageBoxImage.Question);

            if(result == MessageBoxResult.Cancel)
            {
                return;
            }
            else
            { 
                Prescription.Drugs = new List<Drug>((IEnumerable<Drug>)PresrcibedDrugs);
                (this.Parent as Panel).Children.Remove(this);
                return;
            }
        }

        private void buttonDodaj_Click(object sender, RoutedEventArgs e)
        {
            IList rows = dataGrid.SelectedItems;
            foreach(var row in rows)
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

        private void textBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            List<Drug> drugs = new List<Drug>();
            foreach(Drug drug in AllDrugs)
            {
                if (drug.Name.ToLower().StartsWith(textBox.Text))
                {
                    drugs.Add(drug);
                }
            }
            dataGrid.ItemsSource = drugs;
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Klikom na dugme \"Dodaj\", dodajete jedan ili više izabranih lekova u prepisane lekove. Možete pretražiti sve lekove po imenu\n" +
                  "\nKlikom na dugme \"Obriši\" brišete lek iz liste prepisanih lekova\n" +
                  "\nKlikom na dugme \"Obriši\" brišete lek iz liste prepisanih lekova\n" +
                  "\nKlikom na dugme \"Potvrdi recept\" završavate sa pisanjem recepta\n";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
