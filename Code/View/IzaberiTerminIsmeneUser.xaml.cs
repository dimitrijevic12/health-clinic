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
    /// Interaction logic for IzaberiTerminIsmeneUser.xaml
    /// </summary>
    public partial class IzaberiTerminIsmeneUser : UserControl
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

        public IzaberiTerminIsmeneUser(DateTime date)
        {
            InitializeComponent();
            Datum.Content = date.ToShortDateString();
            this.DataContext = this;
            this.date = date;
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            comboSala.SelectedIndex = 0;

            var app = Application.Current as App;
            _roomController = app.ExamOperationRoomController;
            _appointmentController = app.AppointmentController;

            rooms = _roomController.GetAll();

            roomsCollection = new ObservableCollection<ExamOperationRoom>(rooms);

            appointmentCollection = new ObservableCollection<Appointment>(BlankAppointments);

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
            selectedAppointments = new List<Appointment>();

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

            appointmentCollection = new ObservableCollection<Appointment>(BlankAppointments);



            foreach (Appointment a in trazeniAppointmenti)
            {
                foreach (Appointment a2 in BlankAppointments)
                {
                    if (a.StartDate.Equals(a2.StartDate))
                    {
                        int index = appointmentCollection.IndexOf(a2);
                        appointmentCollection[index] = a;
                    }
                    else if (a2.StartDate >= a.StartDate && a2.EndDate <= a.EndDate)
                    {
                        int index = appointmentCollection.IndexOf(a2);
                        appointmentCollection.RemoveAt(index);
                    }

                }
            }

            dataGridNalozi.ItemsSource = appointmentCollection;
            dataGridNalozi.Items.Refresh();

        }

        private void Button_Potvrdi(object sender, RoutedEventArgs e)
        {
            int flag = 0;

            if (selectedAppointments == null)
            {
                string message = "Morate izabrati datum za izmenu";
                string title = "Greška";
                MessageBox.Show(message, title);
                flag = 1;
            }

            if (flag == 0)
            {
                foreach (Appointment a in selectedAppointments)
                {
                    if (a.Id != 0)
                    {
                        string message = "Termin je već zauzet";
                        string title = "Greška";
                        MessageBox.Show(message, title);
                        flag = 1;
                        break;
                    }
                }
            }

            if (flag == 0)
            {
                IzmenaPregledaUser izmena = new IzmenaPregledaUser(date, null, room, startDate, endDate);
                (this.Parent as Panel).Children.Add(izmena);
            }
        }
    }
}
