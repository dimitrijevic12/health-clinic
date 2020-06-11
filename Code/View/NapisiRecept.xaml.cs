using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using Model.Treatment;
using Model.Rooms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections;
using System;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for NapisiRecept.xaml
    /// </summary>
    public partial class NapisiRecept : UserControl
    {
        private Prescription prescription;
        List<Drug> allDrugs = new List<Drug>();
        public ObservableCollection<Drug> PresrcibedDrugs
        {
            get;
            set;
        }

        public Prescription Prescription { get => prescription; set => prescription = value; }
        public List<Drug> AllDrugs { get => allDrugs; set => allDrugs = value; }

        public NapisiRecept(Prescription prescription)
        {
            InitializeComponent();
            DataContext = this;
            Prescription = prescription;
            PresrcibedDrugs = new ObservableCollection<Drug>(prescription.Drug);
 //           foreach(Drug drug in prescription.Drug)
 //           {
 //               PresrcibedDrugs.Add(drug);
 //           }
            Drug d1 = new Drug("Ime leka 1");
            Drug d2 = new Drug("Ime leka 2");
            AllDrugs.Add(d1);
            AllDrugs.Add(d2);
        }

/*        public String ImePrezime{
            get { return _imePrezime; }
            set
            {
                if( _imePrezime != value)
                {
                    _imePrezime = value;
                    OnPropertyChanged();
                }
            }
        }
*/
        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            //            this.Content = new Pregled(_imePrezime);
            (this.Parent as Panel).Children.Remove(this);
        }

        /*        public event PropertyChangedEventHandler PropertyChanged;
                private void OnPropertyChanged([CallerMemberName] string propertyName = null)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                }
        */
        private void buttonPotvrdiRecept_Click(object sender, RoutedEventArgs e)
        {
            //           _imePrezime = "Mika Mikic";
            //           imePrezime.Text = _imePrezime;
            //            this.Content = new Pregled(_imePrezime);
            String message = "Svi prepisani lekovi će biti sačuvani i moći ćete da ih ponovo promenite\n\n Da li ste sigurni da želite da potvrdite recept?";
            MessageBoxButton button = MessageBoxButton.OKCancel;
            MessageBoxResult result = MessageBox.Show(message, "Potvrda recepta", button, MessageBoxImage.Question);

            if(result == MessageBoxResult.Cancel)
            {
                return;
            }
            else
            {
                Prescription.Drug = new List<Drug>((IEnumerable<Drug>)PresrcibedDrugs);
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
            }
        }

        private void buttonObrisiLek_Click(object sender, RoutedEventArgs e)
        {
            var row = dataGridDodati.SelectedItem;
            PresrcibedDrugs.Remove((Drug)row);
        }
    }
}
