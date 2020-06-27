using health_clinicClassDiagram.Model.SystemUsers;
using Model.SystemUsers;
using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices.ComTypes;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for odabrana_oprema.xaml
    /// </summary>
    public partial class odabrana_oprema : Window
    {
        private int colNum = 0;
        private long _id;
        private string _ime;
        private string _prezime;
        private Gender _pol;
        private DateTime _datumRodjenja;
        private string _username;
        private string _password;
        private Specialization _specialization;
        private SurgicalSpecialty _surgicalSpecialty;

        //public static ObservableCollection<oprema_detaljno> DetaljnaOprema
        //{
        //    get;
        //    set;
        //}
        public odabrana_oprema(long id, string ime, string prezime, Gender pol, DateTime datumRodjenja, string username, string password, Specialization specialization, SurgicalSpecialty surgicalSpecialty)
        {
            InitializeComponent();
            this.DataContext = this;
            _id = id;
            _ime = ime;
            _prezime = prezime;
            _pol = pol;
            _datumRodjenja = datumRodjenja;
            _username = username;
            _password = password;
            _specialization = specialization;
            _surgicalSpecialty = surgicalSpecialty;
            //DetaljnaOprema = new ObservableCollection<oprema_detaljno>();
            //DetaljnaOprema.Add(new oprema_detaljno() { VrstaOpreme = "Sto", Sifra = "1", Id = "100"});
            //DetaljnaOprema.Add(new oprema_detaljno() { VrstaOpreme = "Sto", Sifra = "1", Id = "204"});

        }
        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_izadji(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void dataGridDetaljnaOprema_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DateTime _startDate = (DateTime)fromDate.SelectedDate;
            DateTime _endDate = (DateTime)toDate.SelectedDate;
            dani_rad days = new dani_rad(_startDate, _endDate, _id, _ime, _prezime, _pol, _datumRodjenja, _username, _password, _specialization, _surgicalSpecialty);
            days.Show();
            this.Close();
        }
    }
}
