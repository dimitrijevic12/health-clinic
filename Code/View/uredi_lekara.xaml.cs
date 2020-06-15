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
        /*private DateTime _datum;*/
        private TypeOfWorkingSchedule smena;
        private string _datum;
        private Specialization _specijalnost;
        private SurgicalSpecialty _hirurg;
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

           // String JMBG = Jmbg.Text;
            String DATUMRODJ = DatumRodjenja.Text;
            //String RADNOVREME = RadnoVreme.Text;
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
                _specijalnost = Specialization.PULMOLOGY;
            }
            else if (combo2 == 2)
            {
                _specijalnost = Specialization.NEPHROLOGY;
            }
            else
            {
                _specijalnost = Specialization.ENDOCRINOLOGY;
            }

            int combo3 = HirurgCombo.SelectedIndex;

            if (combo3 == 0)
            {
                _hirurg = SurgicalSpecialty.CARDIOTHORACIC;
            }
            else if (combo3 == 1)
            {
                _hirurg = SurgicalSpecialty.NEUROSURGERY;
            }
            else if (combo3 == 2)
            {
                _hirurg = SurgicalSpecialty.PLASTICAL;
            }
            else if (combo3 == 3)
            {
                _hirurg = SurgicalSpecialty.GENERAL;
            }
            else
            {
                _hirurg = SurgicalSpecialty.NOT_SURGEON;
            }

            int combo4 = ComboRadnoVreme.SelectedIndex;
            if (combo4 == 0)
            {
                smena = TypeOfWorkingSchedule.PRVA;
            }
            else if (combo4 == 1)
            {
                smena = TypeOfWorkingSchedule.DRUGA;
            }
            else
            {
                smena = TypeOfWorkingSchedule.TRECA;
            }

            _id = long.Parse(ID);
            _ime = IME;
            _prezime = PREZIME;


            /*_datum = DateTime.Now;*/
            _datum = DatumRodjenja.Text;

            Doctor newDoctor = EditDoctor();

            var s = new lekar();
            s.Show();
            this.Close();

        }

        private Doctor EditDoctor()
        {
            Doctor doctor = new Doctor(_id, _ime, _prezime, _gender, _datum, smena, _specijalnost, _hirurg);

            return _doctorController.Edit(doctor);
        }
    }
}
