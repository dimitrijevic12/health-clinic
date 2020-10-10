using Controller;
using health_clinicClassDiagram.Controller;
using health_clinicClassDiagram.View.Util;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Panel = System.Windows.Controls.Panel;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for PrioritetLista.xaml
    /// </summary>
    public partial class PrioritetLista : UserControl
    {
        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private int colNum = 0;
        private Appointment appointment;
        private List<ExamOperationRoom> rooms;
        public static long staticID = 0;

        private List<Appointment> selectedAppointments = new List<Appointment>();

        private readonly IExamOperationRoomController _roomController;
        private readonly IAppointmentController _appointmentController;
        private readonly IController<Doctor> _doctorController;

        public static List<Appointment> blankAppointments = new List<Appointment>();

        public List<Appointment> BlankAppointments { get => blankAppointments; set => blankAppointments = value; }

        public static ObservableCollection<Appointment> appointmentCollection
        {
            get;
            set;
        }

        public static ObservableCollection<ExamOperationRoom> roomsCollection
        {
            get;
            set;
        }

        private DateTime _startDate;
        private DateTime _endDate;
        private Doctor _doctor;
        private String _priority;

        private List<DateTime> dates = new List<DateTime>();
        private List<Doctor> doctors = new List<Doctor>();

        public PrioritetLista(String priority, Doctor doctor, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
            this.DataContext = this;
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            _startDate = startDate;
            _endDate = endDate;
            _doctor = doctor;
            _priority = priority;

            _roomController = ExamOperationRoomController.Instance;
            _appointmentController = AppointmentController.Instance;
            _doctorController = DoctorController.Instance;

            rooms = _roomController.GetAll();
            doctors = _doctorController.GetAll();

            roomsCollection = new ObservableCollection<ExamOperationRoom>(rooms);

            appointmentCollection = new ObservableCollection<Appointment>(BlankAppointments);

            dataGridNalozi.Items.Refresh();

            for (var dt = _startDate; dt <= _endDate; dt = dt.AddDays(1))
            {
                dates.Add(dt);
            }

            List<Appointment> appointmentsToShow = _appointmentController.GetPriorityAppointments(_doctor, _startDate, _endDate, _priority);       

            appointmentCollection = new ObservableCollection<Appointment>(appointmentsToShow);

            dataGridNalozi.ItemsSource = appointmentCollection;
            dataGridNalozi.Items.Refresh();

        }



        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void dataGridNalozi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedAppointments = new List<Appointment>();

            if (dataGridNalozi.SelectedItem != null)
            {

                IList rows = dataGridNalozi.SelectedItems;

                foreach (var row in rows)
                {
                    selectedAppointments.Add((Appointment)row);
                }

                if (selectedAppointments.Count == 1)
                {
                    appointment = selectedAppointments[0];
                }

                _startDate = selectedAppointments[0].StartDate;
                _endDate = selectedAppointments[selectedAppointments.Count - 1].EndDate;
            }

            /*try
            {
                var row_list = GetDataGridRows(dataGridNalozi);
                foreach (DataGridRow single_row in row_list)
                {
                    if (single_row != null)
                    {
                        if (single_row.IsSelected == true)
                        {
                            appointment = appointmentCollection.ElementAt(single_row.GetIndex());

                        }
                    }
                }

            }
            catch { }*/
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

        private void Button_Izaberi(object sender, RoutedEventArgs e)
        {
            ZakazivanjePrioritet zakazivanje = new ZakazivanjePrioritet(_startDate, _endDate, appointment.ExamOperationRoom, _doctor, _priority);
            (this.Parent as Panel).Children.Add(zakazivanje);
        }
    }
}
