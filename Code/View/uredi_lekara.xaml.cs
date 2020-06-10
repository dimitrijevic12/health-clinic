using Controller;
using health_clinicClassDiagram.Model.SystemUsers;
using Model.SystemUsers;
using System;
using System.Windows;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for uredi_lekara.xaml
    /// </summary>
    public partial class uredi_lekara : Window
    {
        private readonly IController<Doctor> _doctorController;
        private long _id;
        private string _ime;
        private string _prezime;
        private Gender _gender;
        private DateTime _datum;
        private Specialization _specijalnost;
        public uredi_lekara(Doctor doctor)
        {
            InitializeComponent();
            this.DataContext = this;

            var app = Application.Current as App;
            _doctorController = app.doctorController;

            IdLekara.Text = doctor.IdDoctor.ToString();
            Ime.Text = doctor.NameDoctor;
            Prezime.Text = doctor.SurnameDoctor;
            //Jmbg.Text = doctor.Jmbg;
            DatumRodjenja.Text = doctor.DateOfBirth.ToString();
            //RadnoVreme.Text = doctor.;
            

        }

        private void Button_otkazi(object sender, RoutedEventArgs e)
        {
            var s = new lekar();
            s.Show();
            this.Close();

        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {

            String ID = IdLekara.Text;
            String IME = Ime.Text;
            String PREZIME = Prezime.Text;

            String JMBG = Jmbg.Text;
            String DATUMRODJ = DatumRodjenja.Text;
            String RADNOVREME = RadnoVreme.Text;
            String SPECIJALISTA = "DA";

            int combo1 = PolCombo.SelectedIndex;

            if (combo1 == 0)
            {
                _gender = Gender.MALE;
            }
            else
            {
                _gender = Gender.FEMALE;
            }

            int combo2 = SpecijalistaCombo.SelectedIndex;

            if (combo2 == 0)
            {
                _specijalnost = Specialization.CARDIOLOGY;
            }
            else if (combo2 == 1)
            {
                _specijalnost = Specialization.ENDOCRINOLOGY;
            }
            else if (combo2 == 2)
            {
                _specijalnost = Specialization.NEPHROLOGY;
            }
            else
            {
                _specijalnost = Specialization.PULMOLOGY;
            }

            _id = long.Parse(ID);
            _ime = IME;
            _prezime = PREZIME;


            _datum = DateTime.Now;


            Doctor newDoctor = EditDoctor();

            var s = new lekar();
            s.Show();
            this.Close();

        }

        private Doctor EditDoctor()
        {
            Doctor doctor = new Doctor(_id, _ime, _prezime, _gender, _datum, _specijalnost);

            return _doctorController.Create(doctor);
        }
    }
}
