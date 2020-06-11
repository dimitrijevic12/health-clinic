using Model.Appointment;
using Model.Rooms;
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
    /// Interaction logic for Pregled.xaml
    /// </summary>
    public partial class Pregled : UserControl
    {
        private Treatment treatment;

        public Treatment Treatment { get => treatment; set => treatment = value; }

        // private String _imePrezime = "Jovan Jovanovic";
        public Pregled(Treatment treatment)
        {
            InitializeComponent();
            Treatment = treatment;
            Treatment.Prescription = new Prescription();
            Treatment.Prescription.Drug = new List<Drug>();
        }

        private void buttonNapisiRecept_Click(object sender, RoutedEventArgs e)
        {
            //            this.Content = new NapisiRecept(_imePrezime);
            //            this.Content = napisiRecept;
            dropDownButton.IsOpen = false;
            UserControl usc = new NapisiRecept(treatment.Prescription);
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
            UserControl usc = new ZakazivanjeOperacije();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonNapisiUputZaSpecijalistu_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            UserControl usc = new ZakazivanjeKodSpecijaliste();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonZahtevZaBolnickoLecenje_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            UserControl usc = new ZahtevZaBolnickoLecenje();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonNapisiIzvestaj_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            UserControl usc = new DijagnozaProcedura();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void buttonZakaziKontrolu_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            UserControl usc = new ZakaziKontrolu();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonIstorijaBolesti_Click(object sender, RoutedEventArgs e)
        {
            dropDownButton.IsOpen = false;
            UserControl usc = new ZdravstveniKartoniPacijent();
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

    }
}
