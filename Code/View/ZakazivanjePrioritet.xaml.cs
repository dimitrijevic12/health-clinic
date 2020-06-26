using Controller;
using health_clinicClassDiagram.Controller;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
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
    /// Interaction logic for ZakazivanjePrioritet.xaml
    /// </summary>
    public partial class ZakazivanjePrioritet : UserControl, INotifyPropertyChanged
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

        public ObservableCollection<Doctor> doctorsCollection
        {
            get;
            set;
        }

        private DateTime _startDate;
        private DateTime _endDate;

        private List<Doctor> doctors;
        private List<Doctor> doctorsToRemove = new List<Doctor>();
        private List<Appointment> appointments;

        private string _imePacijenta;
        private string _prezimePacijenta;
        private long _jmbgPacijenta;
        private Doctor _doctor;
        private ExamOperationRoom _room;
        private TypeOfAppointment _type;
        private String _priority;



        public ZakazivanjePrioritet(DateTime startDate, DateTime endDate, ExamOperationRoom room, Doctor doctor, String priority)
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
            this.DataContext = this;

            date = DateTime.Now;

            _startDate = startDate;
            _endDate = endDate;
            _doctor = doctor;
            _room = room;
            _priority = priority;

            labelSala.Content = "Sala broj: " + _room.Id.ToString() + ", termin: " + _startDate.ToShortDateString() + " " + _startDate.ToShortTimeString() + "-" + _endDate.ToShortTimeString();

            _appointmentController = AppointmentController.Instance;

            appointments = _appointmentController.GetAll();

            if (ZakazivanjePrioritetIzaberiNalogUser.StaticZakazivanjeRecord != null)
            {
                textImePacijenta.Text = ZakazivanjePrioritetIzaberiNalogUser.StaticZakazivanjeRecord.Name;
                textPrezimePacijenta.Text = ZakazivanjePrioritetIzaberiNalogUser.StaticZakazivanjeRecord.Surname;
                textJMBG.Text = ZakazivanjePrioritetIzaberiNalogUser.StaticZakazivanjeRecord.IDPatient.ToString();
            }
        }

        private void Button_Pronadji(object sender, RoutedEventArgs e)
        {

            ZakazivanjePrioritetIzaberiNalogUser izaberi = new ZakazivanjePrioritetIzaberiNalogUser(date, _startDate, _endDate, _room, _doctor, _priority);
            (this.Parent as Panel).Children.Add(izaberi);
        }

        private void Button_Potvrda(object sender, RoutedEventArgs e)
        {

            if ((textImePacijenta.Text == "") || (textPrezimePacijenta.Text == "") || (textJMBG.Text == "") || (vrstaCombo.SelectedIndex == -1))
            {
                string message = "Sva polja moraju biti popunjena";
                string title = "Greška";
                MessageBox.Show(message, title);
            }
            else
            {
                _imePacijenta = textImePacijenta.Text;
                _prezimePacijenta = textPrezimePacijenta.Text;
                _jmbgPacijenta = long.Parse(textJMBG.Text);

                Patient patient = new Patient(_imePacijenta, _prezimePacijenta, _jmbgPacijenta);


                Appointment appointment = new Appointment(LongRandom(0, 1000000000, new Random()), _doctor, patient, _room, _type, _startDate, _endDate);

                _appointmentController.Create(appointment);


                PrioritetLista prioritet = new PrioritetLista(_priority, _doctor, _startDate, _endDate);
                (this.Parent as Panel).Children.Add(prioritet);
            }
        }

        private void Button_Odustanak(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
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

        private long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }
    }
}
