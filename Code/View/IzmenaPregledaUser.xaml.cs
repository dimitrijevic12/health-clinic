using Controller;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Model.SystemUsers.health_clinicClassDiagram.Model.SystemUsers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for IzmenaPregledaUser.xaml
    /// </summary>
    public partial class IzmenaPregledaUser : UserControl, INotifyPropertyChanged
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
        private DateTime date;

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


        private readonly IAppointmentController _appointmentController;
        private readonly IController<Patient> _patientController;
        private readonly IController<Doctor> _doctorController;

        public ObservableCollection<Doctor> doctorsCollection
        {
            get;
            set;
        }

        private Appointment _appointment;

        private List<Doctor> doctors;

        private string _imePacijenta;
        private string _prezimePacijenta;
        private long _jmbgPacijenta;
        private Doctor _doctor;
        private ExamOperationRoom _room;
        private TypeOfAppointment _type;
        private int _trajanje;

        public IzmenaPregledaUser(DateTime date, ExamOperationRoom room, Appointment appointment)
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
            this.DataContext = this;
            this.date = date;

            var app = Application.Current as App;

            _appointmentController = app.AppointmentController;

            _doctorController = app.DoctorController;

            _appointment = appointment;
            _room = room;

            doctors = _doctorController.GetAll();

            doctorsCollection = new ObservableCollection<Doctor>(doctors);
        }

        private void Button_Pronadji(object sender, RoutedEventArgs e)
        {
            
            /*IzaberiNalogUser izaberi = new IzaberiNalogUser();
            (this.Parent as Panel).Children.Add(izaberi);*/
        }

        private void Button_Potvrda(object sender, RoutedEventArgs e)
        {
            _imePacijenta = textIme.Text;
            _prezimePacijenta = textPrezime.Text;
            _jmbgPacijenta = long.Parse(textJMBG.Text);

            Patient patient = new Patient(_imePacijenta, _prezimePacijenta, _jmbgPacijenta);

            DateTime startDate = _appointment.StartDate;
            DateTime endDate = startDate.AddHours(_trajanje);

            Appointment appointment = new Appointment(_doctor, patient, _room, _type, startDate, endDate);

            _appointmentController.Edit(appointment);

            DetaljanPrikazRasporedaUser raspored = new DetaljanPrikazRasporedaUser(date);
            (this.Parent as Panel).Children.Add(raspored);
        }

        private void Button_Odustanak(object sender, RoutedEventArgs e)
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

        private void DoktorCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            _doctor = (Doctor)cmb.SelectedItem;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            int index = cmb.SelectedIndex;

            if (index == 0)
            {
                _trajanje = 1;
            }
            else if (index == 1)
            {
                _trajanje = 2;
            }
            else
            {
                _trajanje = 3;
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            int index = cmb.SelectedIndex;

            if (index == 0)
            {
                _type = TypeOfAppointment.EXAM;
            }
            else
            {
                _type = TypeOfAppointment.SURGERY;
            }
        }
    }
}
