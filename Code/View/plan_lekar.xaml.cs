using Controller;
using Model.SystemUsers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for plan_lekar.xaml
    /// </summary>
    public partial class plan_lekar : Window
    {
        private int colNum = 0;
        private readonly IController<Doctor> _doctorController;
        private Doctor doctor;

        //static public ObservableCollection<lekari> Lekari
        //{
        //    get;
        //    set;
        //}
        public static ObservableCollection<Doctor> doctorsCollection
        {
            get;
            set;
        }

        public List<Doctor> doctors;

        public plan_lekar()
        {
            InitializeComponent();
            this.DataContext = this;
            //Lekari = new ObservableCollection<lekari>();
            //Lekari.Add(new lekari() { IdLekara = "1", Ime = "Marko", Prezime = "Markovic", Pol = "M", Jmbg = "213123213", DatumRodjenja = "11/11/1974", RadnoVreme = "08:00-16:00", Specijalista = "DA" });
            //Lekari.Add(new lekari() { IdLekara = "2", Ime = "Jovana", Prezime = "Jovanovic", Pol = "Z", Jmbg = "213123213", DatumRodjenja = "1/1/1964", RadnoVreme = "08:00-16:00", Specijalista = "NE" });
            //Lekari.Add(new lekari() { IdLekara = "4", Ime = "Lazar", Prezime = "Markovic", Pol = "M", Jmbg = "213123213", DatumRodjenja = "12/12/1974", RadnoVreme = "08:00-16:00", Specijalista = "NE" });
            //Lekari.Add(new lekari() { IdLekara = "4", Ime = "Sara", Prezime = "Simic", Pol = "Z", Jmbg = "2131123213", DatumRodjenja = "5/2/1984", RadnoVreme = "08:00-16:00", Specijalista = "DA" });
            var app = Application.Current as App;
            _doctorController = app.doctorController;

            doctors = _doctorController.GetAll();

            doctorsCollection = new ObservableCollection<Doctor>(doctors);

            dataGridLekari.Items.Refresh();

        }
        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_otkazi(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            DateTime date1 = (DateTime)dat1.SelectedDate;
            DateTime date2 = (DateTime)dat2.SelectedDate;
            var s = new plan_detaljan(doctor, date1, date2);
            s.Show();
        }

        private void comboLekar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            doctor = (Doctor)cb.SelectedItem;
        }
    }
}
