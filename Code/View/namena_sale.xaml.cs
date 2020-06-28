
using Controller;
using health_clinicClassDiagram.Controller;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
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
    /// Interaction logic for namena_sale.xaml
    /// </summary>
    public partial class namena_sale : Window
    {
        private int colNum = 0;
        private readonly IController<ExamOperationRoom> _examOperationRoomController;
        private readonly IController<RehabilitationRoom> _rehabilitationRoomController;
        private readonly IAppointmentController _appointmentController;
        private readonly IController<Renovation> _renovationController;
        private Room room;

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
        private ExamOperationRoom sobaZaDodavanje;
        private RehabilitationRoom sobaZaDodavanje2;
        public namena_sale()
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

            dataGridOdabranaSala.Items.Refresh();
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
            if ((DatumPicker.ToString() == "") || (comboSala.SelectedIndex == -1) || (tip.SelectedIndex == -1))
            {
                string message = "Sva polja moraju biti popunjena!";
                string title = "Greška";

                MessageBox.Show(message, title);
            }
            else
            {

                DateTime dt1 = (DateTime)DatumPicker.SelectedDate;
                DateTime lastDate = _appointmentController.GetLastDateOfAppointmentForRoom(room);

                if (lastDate < dt1 && DateTime.Now.Date == dt1.Date)
                {
                   
                   

                    List<Room> roomsReturn = new List<Room>();
                    roomsReturn.Add(room);
                    Renovation renovation = new Renovation(LongRandom(0, 1000000000, new Random()), TypeOfRenovation.CHANGINGTYPEOFROOM, dt1, dt1, roomsReturn);
                    _renovationController.Create(renovation);
                    String tipSale;
                    if (tip.SelectedIndex == 0)
                    {

                        sobaZaDodavanje2 = RehabilitationRoomController.Instance.GetRoomById(room.Id);
                        sobaZaDodavanje2.tip = TypeOfRoom.EXAMOPERATION;
                        if (sobaZaDodavanje2 != null)
                        {
                            bool del = _rehabilitationRoomController.Delete(sobaZaDodavanje2);
                            ExamOperationRoom roomZaDodati = new ExamOperationRoom(sobaZaDodavanje2.Id, sobaZaDodavanje2.Equipments);
                            ExamOperationRoom r = _examOperationRoomController.Create(roomZaDodati);
                        }
                      
                    }
                    else
                    {
                        sobaZaDodavanje = ExamOperationRoomController.Instance.GetRoomById(room.Id);
                        sobaZaDodavanje.tip = TypeOfRoom.REHABILITATION;
                        if (sobaZaDodavanje != null)
                        {
                            bool del = _examOperationRoomController.Delete(sobaZaDodavanje);
                            List<MedicalRecord> medicalRecords = new List<MedicalRecord>();
                            RehabilitationRoom roomZaDodati = new RehabilitationRoom(sobaZaDodavanje.Id, 0, 5, medicalRecords, sobaZaDodavanje.Equipments);
                            RehabilitationRoom r = _rehabilitationRoomController.Create(roomZaDodati);
                        }

                       
                    }
                }
                else
                {
                    if (lastDate > dt1)
                    {
                        dt1 = lastDate.AddDays(1);
                    }
                    
                    List<Room> roomsReturn = new List<Room>();
                    roomsReturn.Add(room);
                    Renovation renovation = new Renovation(LongRandom(0, 1000000000, new Random()), TypeOfRenovation.CHANGINGTYPEOFROOM, dt1, dt1, roomsReturn);
                    _renovationController.Create(renovation);
                }

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
