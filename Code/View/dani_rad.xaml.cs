using Controller;
using health_clinicClassDiagram.Controller;
using health_clinicClassDiagram.Model.SystemUsers;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for dodaj_salu.xaml
    /// </summary>
    public partial class dani_rad : Window
    {

        private DateTime _startDate;
        private DateTime _endDate;

        private long _id;
        private string _ime;
        private string _prezime;
        private Gender _pol;
        private DateTime _datumRodjenja;
        private string _username;
        private string _password;
        private Specialization _specialization;
        private SurgicalSpecialty _surgicalSpecialty;

        private readonly IController<Doctor> _doctorController;
        private readonly IController<WorkingDays> _workingDaysController;
        private readonly IController<WorkingSchedule> _workingScheduleController;
        private readonly IController<Specialist> _specijalistaController;
        private readonly IController<Surgeon> _hirurgController;



        public dani_rad(DateTime startDate, DateTime endDate, long id, string ime, string prezime, Gender pol, DateTime datumRodjenja, string username, string password, Specialization specialization, SurgicalSpecialty surgicalSpecialty)
        {
            InitializeComponent();
            this.DataContext = this;

            _startDate = startDate;
            _endDate = endDate;

            _id = id;
            _ime = ime;
            _prezime = prezime;
            _pol = pol;
            _datumRodjenja = datumRodjenja;
            _username = username;
            _password = password;
            _specialization = specialization;
            _surgicalSpecialty = surgicalSpecialty;

            _doctorController = DoctorController.Instance;
            _workingDaysController = WorkingDaysController.Instance;
            _workingScheduleController = WorkingScheduleController.Instance;
            _specijalistaController = SpecialistController.Instance;
            _hirurgController = SurgeonController.Instance;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DateTime fromTimePom = DateTime.ParseExact(pon1.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime toTimePon = DateTime.ParseExact(pon2.Text, "HH:mm:ss", CultureInfo.InvariantCulture);

            DateTime fromTimeUto = DateTime.ParseExact(uto1.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime toTimeUto= DateTime.ParseExact(uto2.Text, "HH:mm:ss", CultureInfo.InvariantCulture);

            DateTime fromTimeSre = DateTime.ParseExact(sre1.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime toTimeSre = DateTime.ParseExact(sre2.Text, "HH:mm:ss", CultureInfo.InvariantCulture);

            DateTime fromTimeCet = DateTime.ParseExact(cet1.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime toTimeCet = DateTime.ParseExact(cet2.Text, "HH:mm:ss", CultureInfo.InvariantCulture);

            DateTime fromTimePet = DateTime.ParseExact(pet1.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime toTimePet = DateTime.ParseExact(pet2.Text, "HH:mm:ss", CultureInfo.InvariantCulture);

            DateTime fromTimeSub = DateTime.ParseExact(sub1.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime toTimePonSub = DateTime.ParseExact(sub2.Text, "HH:mm:ss", CultureInfo.InvariantCulture);

            DateTime fromTimeNed = DateTime.ParseExact(ned1.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime toTimePonNed = DateTime.ParseExact(ned2.Text, "HH:mm:ss", CultureInfo.InvariantCulture);


            WorkingDays workingDays1 = new WorkingDays(LongRandom(0, 1000000000, new Random())+1, fromTimePom, toTimePon, Days.MONDAY);
            WorkingDays workingDays2 = new WorkingDays(LongRandom(0, 1000000000, new Random())+2, fromTimeUto, toTimeUto, Days.TUESDAY);
            WorkingDays workingDays3 = new WorkingDays(LongRandom(0, 1000000000, new Random())+3, fromTimeSre, toTimeSre, Days.WEDNESDAY);
            WorkingDays workingDays4 = new WorkingDays(LongRandom(0, 1000000000, new Random())+4, fromTimeCet, toTimeCet, Days.THURSDAY);
            WorkingDays workingDays5 = new WorkingDays(LongRandom(0, 1000000000, new Random())+5, fromTimePet, toTimePet, Days.FRIDAY);
            WorkingDays workingDays6 = new WorkingDays(LongRandom(0, 1000000000, new Random())+6, fromTimeSub, toTimePonSub, Days.SATURDAY);
            WorkingDays workingDays7 = new WorkingDays(LongRandom(0, 1000000000, new Random())+7, fromTimeNed, toTimePonNed, Days.SUNDAY);

            _workingDaysController.Create(workingDays1);
            _workingDaysController.Create(workingDays2);
            _workingDaysController.Create(workingDays3);
            _workingDaysController.Create(workingDays4);
            _workingDaysController.Create(workingDays5);
            _workingDaysController.Create(workingDays6);
            _workingDaysController.Create(workingDays7);


            List<WorkingDays> listWokringDays = new List<WorkingDays>();
            listWokringDays.Add(workingDays1);
            listWokringDays.Add(workingDays2);
            listWokringDays.Add(workingDays3);
            listWokringDays.Add(workingDays4);
            listWokringDays.Add(workingDays5);
            listWokringDays.Add(workingDays6);
            listWokringDays.Add(workingDays7);

            WorkingSchedule workingSchedule = new WorkingSchedule(LongRandom(0, 1000000000, new Random()), _startDate, _endDate, listWokringDays);

            _workingScheduleController.Create(workingSchedule);

            Doctor doctor = new Doctor(_id, _ime, _prezime, _pol, _datumRodjenja, workingSchedule, _username, _password/*, _specijalnost, _hirurg*/);

            _doctorController.Create(doctor);

            if (!(_specialization.Equals(Specialization.NOT_SPECIALIST)))
            {
                Specialist spec = new Specialist(_id, _ime, _prezime, _pol, _datumRodjenja, _specialization);
                _specijalistaController.Create(spec);
            }

            if (!(_surgicalSpecialty.Equals(SurgicalSpecialty.NOT_SURGEON)))
            {

                Surgeon hirurg = new Surgeon(_id, _ime, _prezime, _pol, _datumRodjenja, _surgicalSpecialty);
                _hirurgController.Create(hirurg);
            }

            var s = new lekar();
            s.Show();
            this.Close();

        }

        private long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }
    }
}
