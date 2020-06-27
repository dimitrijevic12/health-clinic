using Controller;
using health_clinicClassDiagram.Controller;
using health_clinicClassDiagram.Model.SystemUsers;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for dodaj_salu.xaml
    /// </summary>
    public partial class promeni_vreme : Window
    {
        public static ObservableCollection<WorkingSchedule> workingSchedulesCollection
        {
            get;
            set;
        }

        private long _id;
        private string _ime;
        private string _prezime;
        private Gender _pol;
        private DateTime _datumRodjenja;
        private List<WorkingSchedule> _workingSchedules;
        private string _username;
        private string _password;

        private DateTime _startDate;
        private DateTime _endDate;

        private WorkingSchedule ws;

        private readonly IController<Doctor> _doctorController;
        private readonly IController<WorkingDays> _workingDaysController;
        private readonly IWorkingSchedule _workingScheduleController;

        public promeni_vreme(long id, string ime, string prezime, Gender pol, DateTime datumRodjenja, List<WorkingSchedule> workingSchedules, string username, string password)
        {
            InitializeComponent();
            this.DataContext = this;
            _id = id;
            _ime = ime;
            _prezime = prezime;
            _pol = pol;
            _datumRodjenja = datumRodjenja;
            _workingSchedules = workingSchedules;
            _username = username;
            _password = password;

            _doctorController = DoctorController.Instance;
            _workingDaysController = WorkingDaysController.Instance;
            _workingScheduleController = WorkingScheduleController.Instance;

            workingSchedulesCollection = new ObservableCollection<WorkingSchedule>(workingSchedules);

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DateTime fromTimePom = DateTime.ParseExact(pon1.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime toTimePon = DateTime.ParseExact(pon2.Text, "HH:mm:ss", CultureInfo.InvariantCulture);

            DateTime fromTimeUto = DateTime.ParseExact(uto1.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime toTimeUto = DateTime.ParseExact(uto2.Text, "HH:mm:ss", CultureInfo.InvariantCulture);

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

            List<WorkingDays> listWokringDays = new List<WorkingDays>();


            if (ws.WorkingDays[0] != null)
            {
                WorkingDays workingDays1 = new WorkingDays(ws.WorkingDays[0].Id, fromTimePom, toTimePon, Days.MONDAY);
                _workingDaysController.Edit(workingDays1);
                listWokringDays.Add(workingDays1);
            }

            if (ws.WorkingDays[1] != null)
            {
                WorkingDays workingDays2 = new WorkingDays(ws.WorkingDays[1].Id, fromTimeUto, toTimeUto, Days.TUESDAY);
                _workingDaysController.Edit(workingDays2);
                listWokringDays.Add(workingDays2);
            }

            if (ws.WorkingDays[2] != null)
            {
                WorkingDays workingDays3 = new WorkingDays(ws.WorkingDays[2].Id, fromTimeSre, toTimeSre, Days.WEDNESDAY);
                _workingDaysController.Edit(workingDays3);
                listWokringDays.Add(workingDays3);
            }

            if (ws.WorkingDays[3] != null)
            {
                WorkingDays workingDays4 = new WorkingDays(ws.WorkingDays[3].Id, fromTimeCet, toTimeCet, Days.THURSDAY);
                _workingDaysController.Edit(workingDays4);
                listWokringDays.Add(workingDays4);
            }

            if (ws.WorkingDays[4] != null)
            {
                WorkingDays workingDays5 = new WorkingDays(ws.WorkingDays[4].Id, fromTimePet, toTimePet, Days.FRIDAY);
                _workingDaysController.Edit(workingDays5);
                listWokringDays.Add(workingDays5);
            }

            if (ws.WorkingDays[5] != null)
            {
                WorkingDays workingDays6 = new WorkingDays(ws.WorkingDays[5].Id, fromTimeSub, toTimePonSub, Days.SATURDAY);
                _workingDaysController.Edit(workingDays6);
                listWokringDays.Add(workingDays6);
            }

            if (ws.WorkingDays[6] != null)
            {
                WorkingDays workingDays7 = new WorkingDays(ws.WorkingDays[6].Id, fromTimeNed, toTimePonNed, Days.SUNDAY);
                _workingDaysController.Edit(workingDays7);
                listWokringDays.Add(workingDays7);
            }


            _startDate = (DateTime)fromDate.SelectedDate;
            _endDate = (DateTime)toDate.SelectedDate;

            WorkingSchedule workingSchedule = new WorkingSchedule(ws.Id, _startDate, _endDate, listWokringDays);

            _workingScheduleController.Edit(workingSchedule);

            List<WorkingSchedule> wsList = new List<WorkingSchedule>();
            wsList = _workingSchedules;
            wsList.Add(workingSchedule);

            Doctor doctor = new Doctor(_id, _ime, _prezime, _pol, _datumRodjenja, wsList, _username, _password/*, _specijalnost, _hirurg*/);
            _doctorController.Edit(doctor);
            var s = new lekar();
            s.Show();
            this.Close();
        }

        private void comboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            ws = (WorkingSchedule)cb.SelectedItem;
        }
    }
}
