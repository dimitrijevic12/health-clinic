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
    /// Interaction logic for PocetnaUser.xaml
    /// </summary>
    public partial class PocetnaUser : UserControl
    {
        private Doctor doctor;

        public Doctor Doctor { get => doctor; set => doctor = value; }

        public PocetnaUser(Doctor doctor)
        {
            Doctor = doctor;
            InitializeComponent();
            DataContext = this;
        }

        private void buttonRaspored_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new RasporedUser(doctor);
            (this.Parent as Panel).Children.Add(usc);
//            this.Content = new RasporedUser();
        }

        private void buttonZapocniPregled_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new ZapocniPregled(Doctor);
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonNapisiClanak_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new NapisiClanak();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonZdravstveniKartoni_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new ZdravstveniKartoniLista();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonOdobravanjeLekova_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new OdobravanjeLekova();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonPregledStatistike_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new IzvestajOPotrosnjiLekova();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void buttonOdobravanjeOdjaviSe_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Klikom na dugme desno od dugmeta help dobijate komandu za odjavu\n\nKlikom na dugme \"Raspored\" dobićete kalendar za vaš raspored\n\nKlikom na dugme \"Započni pregled\" otvara se raspored vaših zakazanih pregleda\n" +
                "\nKlikom na dugme \"Napiši članak\" prelazi se na prozor za pisanje članka\n\nKlikom na dugme \"Zdravstveni kartoni\" otvara se lista pacijenata čije kartone možete da pogledate\n\nKlikom na dugme \"Izveštaj o potrošnji lekova\" prelazite na prozor koji sadrži informacije o potrošnji lekova u nekom određenom periodu\n" +
                "\nKlikom na dugme \"Odobravanje lekova\" otvara se lista sa neodobrenim lekovima";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void buttonOtpustanjePacijenata_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new OtpustanjePacijenata();
            (this.Parent as Panel).Children.Add(usc);
        }
    }
}
