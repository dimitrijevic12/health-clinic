using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for KreirajNalogUser.xaml
    /// </summary>
    public partial class KreirajNalogUser : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private double _test1;
        private double _test2;
        public double Test1
        {
            get
            {
                return _test1;
            }
            set
            {
                if (value != _test1)
                {
                    _test1 = value;
                    OnPropertyChanged("Test1");
                }
            }
        }

        public double Test2
        {
            get
            {
                return _test2;
            }
            set
            {
                if (value != _test2)
                {
                    _test2 = value;
                    OnPropertyChanged("Test2");
                }
            }
        }

        public KreirajNalogUser()
        {
            InitializeComponent();
            this.DataContext = this;
            labelDateTime.Content = DateTime.Now.ToShortDateString();
        }

        private void Button_Potvrdi(object sender, RoutedEventArgs e)
        {
            String idNalogaString = IDTekst.Text;
            String ime = ImeTekst.Text;
            String prezime = PrezimeTekst.Text;
            String jmbgString = JMBGTekst.Text;

            String dateString;
            DateTime? izabraniDatum = DatumPicker.SelectedDate;
            if (izabraniDatum.HasValue)
            {
                dateString = izabraniDatum.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }

            //EnumPol pol = EnumPol.Z;

            //if (muski.IsChecked == true)
            //{
            //    pol = EnumPol.M;
            //}
            //else if (zenski.IsChecked == true)
            //{
            //    pol = EnumPol.Z;
            //}
            //else
            //{
            //    Console.WriteLine("Niste uneli pol");
            //}

            //String odabraniDoktor = DoktorCombo.SelectedItem.ToString();

            //String istorijaLecenja = IstorijaTekst.Text;


            //int idNaloga;
            //int jmbg;

            //bool isParsable = Int32.TryParse(idNalogaString, out idNaloga);
            //isParsable = Int32.TryParse(jmbgString, out jmbg);

            //NalogPacijent np = new NalogPacijent { IDnaloga = idNaloga, Ime = ime, Prezime = prezime, JMBG = jmbg, Pol = pol, OdabraniDoktor = "Odabrani doktor", DatumRodjenja = "13/13/13", IstorijaLecenja = istorijaLecenja };

            //RegistrovaniPacijentiUser.Nalozi.Add(np);

            

            GridKreiraj.Children.Clear();
            RegistrovaniPacijentiUser pacijenti = new RegistrovaniPacijentiUser();
            GridKreiraj.Children.Add(pacijenti);


        }

        private void Button_Odustani(object sender, RoutedEventArgs e)
        {
            GridKreiraj.Children.Clear();
            RegistrovaniPacijentiUser pacijenti = new RegistrovaniPacijentiUser();
            GridKreiraj.Children.Add(pacijenti);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            GridKreiraj.Children.Clear();
            HomeUser home = new HomeUser();
            GridKreiraj.Children.Add(home);
        }
    }
}
