using Controller;
using Model.SystemUsers;
using System;
using System.Collections.Generic;
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

        private readonly IMedicalRecordController _recordController;
        private readonly IController<Patient> _patientController;

        private readonly IList<Patient> _patients;

        public KreirajNalogUser()
        {
            InitializeComponent();
            this.DataContext = this;
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            var app = Application.Current as App;
            _recordController = app


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

            

            
            RegistrovaniPacijentiUser pacijenti = new RegistrovaniPacijentiUser();
            (this.Parent as Panel).Children.Add(pacijenti);


        }

        private void Button_Odustani(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(2, thisCount);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
