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
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for DetaljanPrikazRasporedaUser.xaml
    /// </summary>
    public partial class DetaljanPrikazRasporedaUser : UserControl, INotifyPropertyChanged
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

        public DetaljanPrikazRasporedaUser(DateTime date)
        {
            InitializeComponent();
            Datum.Content = date.ToShortDateString();
            this.DataContext = this;
            this.date = date;
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            comboSala.SelectedIndex = 0;

            _roomController = ExamOperationRoomController.Instance;
            _appointmentController = AppointmentController.Instance;

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

                startDate = selectedAppointments[0].StartDate;
                endDate = selectedAppointments[selectedAppointments.Count - 1].EndDate;
            }

        }

        private void Button_Zakazivanje(object sender, RoutedEventArgs e)
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
                ZakazivanjePregledaUser zakazivanje = new ZakazivanjePregledaUser(date, startDate, endDate, room);
                (this.Parent as Panel).Children.Add(zakazivanje);
            }
        }

        private void Button_Otkazivanje(object sender, RoutedEventArgs e)
        {
            int flag = 0;
            if (appointment == null)
            {
                string message = "Morate izabrati pregled za otkazivanje";
                string title = "Greška";
                MessageBox.Show(message, title);
                flag = 1;
            }

            if (flag == 0)
            {
                if (appointment.Id == 0)
                {
                    string message = "Ne možete izabrati prazan za otkazivanje";
                    string title = "Greška";
                    MessageBox.Show(message, title);
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                _appointmentController.Delete(appointment);
                DetaljanPrikazRasporedaUser detaljan = new DetaljanPrikazRasporedaUser(date);
                (this.Parent as Panel).Children.Add(detaljan);
            }
            
        }

        private void Button_Izmena(object sender, RoutedEventArgs e)
        {
            int flag = 0;
            
            if (appointment == null)
            {
                string message = "Morate izabrati pregled za izmenu";
                string title = "Greška";
                MessageBox.Show(message, title);
                flag = 1;
                
            }

            if (flag == 0)
            {
                if (appointment.Id == 0)
                {
                    string message = "Ne možete izabrati prazan za izmenu";
                    string title = "Greška";
                    MessageBox.Show(message, title);
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                IzmenaPregledaUser izmena = new IzmenaPregledaUser(date, appointment, room, startDate, endDate);
                (this.Parent as Panel).Children.Add(izmena);
            }
        }

        private void Button_Guest(object sender, RoutedEventArgs e)
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
                ZakazivanjeGuestNalogaUser zakazivanje = new ZakazivanjeGuestNalogaUser(date, startDate, endDate, room);
                (this.Parent as Panel).Children.Add(zakazivanje);
            }
        }

        private void Button_Prikaz(object sender, RoutedEventArgs e)
        {
            
            SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
            (this.Parent as Panel).Children.Add(sale);
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

        private void comboSala_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            room = (ExamOperationRoom)cmb.SelectedItem;

            DateTime startDate = date;
            DateTime endDate = startDate.AddHours(24);

            List<Appointment> trazeni = _appointmentController.GetAppointmentsByRoom(room);

            List<Appointment> trazeniAppointmenti = _appointmentController.GetAppointmentsByTimeAndRoom(room, startDate, endDate);

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
    }
}
