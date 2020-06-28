
using Controller;
using health_clinicClassDiagram.Controller;
using Model.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for krecenje.xaml
    /// </summary>
    public partial class krecenje : Window
    {
        private int colNum = 0;
        private readonly IController<ExamOperationRoom> _examOperationRoomController;
        private readonly IController<RehabilitationRoom> _rehabilitationRoomController;
        private readonly IAppointmentController _appointmentController;
        private readonly IRenovationController _renovationController;

        public static ObservableCollection<Room> roomsCollection
        {
            get;
            set;
        }
        //public static ObservableCollection<SpisakSala> Spisak
        //{
        //    get;
        //    set;
        //}
        public List<ExamOperationRoom> rooms;
        public List<RehabilitationRoom> rooms2;
        public List<Room> finalRooms;
        private Room room;
        public krecenje()
        {
            InitializeComponent();
            this.DataContext = this;
            
           
            _examOperationRoomController = ExamOperationRoomController.Instance;
            _rehabilitationRoomController = RehabilitationRoomController.Instance;
            _appointmentController = AppointmentController.Instance;
            _renovationController = RenovationController.Instance;
            rooms = _examOperationRoomController.GetAll();
            rooms2 = _rehabilitationRoomController.GetAll();

            finalRooms = rooms2.Cast<Room>().ToList();

            finalRooms.AddRange(rooms);


            roomsCollection = new ObservableCollection<Room>(finalRooms);
            //Spisak = new ObservableCollection<SpisakSala>();
            //Spisak.Add(new SpisakSala { Sala = "101", TipSale = "Operaciona" });
        }
        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_otkazi(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            if ((dat1.ToString() == "") || (comboSala.SelectedIndex == -1) || (dat2.ToString() == ""))
            {
                string message = "Sva polja moraju biti popunjena!";
                string title = "Greška";

                MessageBox.Show(message, title);
            }
            else
            {
                DateTime dt1 = (DateTime)dat1.SelectedDate;
                DateTime dt2 = (DateTime)dat2.SelectedDate;
                int difference = (dt2.Date - dt1.Date).Days;
                DateTime lastDate = _appointmentController.GetLastDateOfAppointmentForRoom(room);
                List<Room> rooms = new List<Room>();
                rooms.Add(room);
                Renovation renovation = new Renovation(LongRandom(0, 1000000000, new Random()), TypeOfRenovation.PAINTING, dt1, dt2, rooms);
                _renovationController.Create(renovation);


                this.Close();
            }
           
        }
        private long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }

        private void comboSala_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            room = (Room)cb.SelectedItem;
        }
    }
}
