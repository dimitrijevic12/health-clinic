using Controller;
using health_clinicClassDiagram.Controller;
using health_clinicClassDiagram.View.Util;
using Model.Appointment;
using Model.Rooms;
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
using DataGrid = System.Windows.Controls.DataGrid;
using Panel = System.Windows.Controls.Panel;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for ZauzetostProstorijaUser.xaml
    /// </summary>
    public partial class ZauzetostProstorijaUser : UserControl
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
        private DateTime date;
        private Appointment appointment;
        private ExamOperationRoom room;
        private List<ExamOperationRoom> rooms;
        public static long staticID = 0;

        private DateTime startDate;
        private DateTime endDate;

        private List<Appointment> selectedAppointments = new List<Appointment>();

        private readonly IExamOperationRoomController _roomController;
        private readonly IAppointmentController _appointmentController;

        public static List<Appointment> blankAppointments = new List<Appointment>();

        public List<Appointment> BlankAppointments { get => blankAppointments; set => blankAppointments = value; }

        public static ObservableCollection<Appointment> AppointmentCollection
        {
            get;
            set;
        }

        public static ObservableCollection<ExamOperationRoom> roomsCollection
        {
            get;
            set;
        }

        public static ObservableCollection<DateTime> datesCollection
        {
            get;
            set;
        }

        private DateTime _startDate;
        private DateTime _endDate;
        private List<DateTime> dates = new List<DateTime>();

        public ZauzetostProstorijaUser(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            Datum.SelectedIndex = 0;
            this.DataContext = this;
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            comboSala.SelectedIndex = 0;

            _startDate = startDate;
            _endDate = endDate;

            for (var dt = _startDate; dt <= _endDate; dt = dt.AddDays(1))
            {
                dates.Add(dt);
            }


            var app = Application.Current as App;
            _roomController = app.ExamOperationRoomController;
            _appointmentController = app.AppointmentController;

            rooms = _roomController.GetAll();

            roomsCollection = new ObservableCollection<ExamOperationRoom>(rooms);

            datesCollection = new ObservableCollection<DateTime>(dates);

            AppointmentCollection = new ObservableCollection<Appointment>(BlankAppointments);

            dataGridNalozi.Items.Refresh();


        }

        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        public IEnumerable<DataGridRow> GetDataGridRows(DataGrid grid)
        {
            var itemsSource = grid.ItemsSource as IEnumerable;
            if (null == itemsSource) yield return null;
            foreach (var item in itemsSource)
            {
                var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (null != row) yield return row;
            }
        }

        private void dataGridNalozi_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

            startDate = selectedAppointments[0].StartDate;
            endDate = selectedAppointments[selectedAppointments.Count - 1].EndDate;

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
            (this.Parent as Panel).Children.RemoveRange(2, thisCount);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void comboSala_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            room = (ExamOperationRoom)cmb.SelectedItem;

            DateTime startDate = date;
            DateTime endDate = startDate.AddHours(24);

            List<Appointment> trazeni = _appointmentController.GetAppointmentsByRoom(room);

            List<Appointment> trazeniAppointmenti = _appointmentController.GetAppointmentsByTimeAndRoom(room, startDate, endDate);

            //blankAppointments = AppointmentGenerator.Instance.generateList(DateTime.Today);

            blankAppointments = AppointmentGenerator.Instance.generateList(startDate);

            AppointmentCollection = new ObservableCollection<Appointment>(BlankAppointments);



            foreach (Appointment a in trazeniAppointmenti)
            {
                foreach (Appointment a2 in BlankAppointments)
                {
                    if (a.StartDate.Equals(a2.StartDate))
                    {
                        int index = AppointmentCollection.IndexOf(a2);
                        AppointmentCollection[index] = a;
                    }
                    else if (a2.StartDate >= a.StartDate && a2.EndDate <= a.EndDate)
                    {
                        int index = AppointmentCollection.IndexOf(a2);
                        AppointmentCollection.RemoveAt(index);
                    }

                }
            }

            dataGridNalozi.ItemsSource = AppointmentCollection;
            dataGridNalozi.Items.Refresh();

        }

        private void Datum_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            date = (DateTime)cmb.SelectedItem;
        }
    }
}
