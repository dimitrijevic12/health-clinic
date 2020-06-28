using Controller;
using health_clinicClassDiagram.Controller;
using Model.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for podela_sale.xaml
    /// </summary>
    public partial class podela_sale : Window
    {
        private int colNum = 0;
        private readonly IController<ExamOperationRoom> _examOperationRoomController;
        private readonly IController<RehabilitationRoom> _rehabilitationRoomController;
        private readonly IAppointmentController _appointmentController;
        private readonly IRenovationController _renovationController;
        private readonly IController<Equipment> _equipController;
        
        private Room room;
        private ExamOperationRoom sobaZaEdit;
        private ExamOperationRoom sobaZaAdd;

        private RehabilitationRoom sobaZaEdit2;
        private RehabilitationRoom sobaZaAdd2;
        public static ObservableCollection<Room> roomsCollection
        {
            get;
            set;
        }
        public static ObservableCollection<Equipment> equipCollection
        {
            get;
            set;
        }

        public List<Equipment> equips;
        public List<ExamOperationRoom> rooms;
        public List<RehabilitationRoom> rooms2;
        public List<Room> finalRooms;
        //public static ObservableCollection<SpisakSala> Spisak
        //{
        //    get;
        //    set;
        //}
        public podela_sale()
        {
            InitializeComponent();
            this.DataContext = this;
            //Spisak = new ObservableCollection<SpisakSala>();
            //Spisak.Add(new SpisakSala { Sala = "101", TipSale = "Operaciona" });
            InitializeComponent();
            this.DataContext = this;
            //Spisak = new ObservableCollection<SpisakSala>();
            //Spisak.Add(new SpisakSala { Sala = "101", TipSale = "Operaciona" });
            //Spisak.Add(new SpisakSala { Sala = "103", TipSale = "Operaciona" });
            
            _equipController = EquipmentController.Instance;
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

        private void comboSala1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            room = (Room)cb.SelectedItem;
            equips = room.Equipments;
            equipCollection = new ObservableCollection<Equipment>(equips);
            dataGridOdabranaSala.ItemsSource = equipCollection;
            dataGridOdabranaSala.Items.Refresh();
        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            if ((date1.ToString() == "") || (date2.ToString() == "") || (comboSala1.SelectedIndex == -1))
            {
                string message = "Sva polja moraju biti popunjena!";
                string title = "Greška";

                MessageBox.Show(message, title);
            }
            else
            {


                // string nazivDruge = ime.Text;
                DateTime dt1 = (DateTime)date1.SelectedDate;
                DateTime dt2 = (DateTime)date2.SelectedDate;
                int difference = (dt2.Date - dt1.Date).Days;
                DateTime lastDate = _appointmentController.GetLastDateOfAppointmentForRoom(room);
                //int result = DateTime.Compare(dt1, dt2);
                if (lastDate < dt1/* && DateTime.Now.Date == dt1*/)
                {
                    List<Room> rooms = new List<Room>();
                    rooms.Add(room);
                    Renovation renovation = new Renovation(LongRandom(0, 1000000000, new Random()), TypeOfRenovation.SPLITTING, dt1, dt2, rooms);
                    _renovationController.Create(renovation);
                    int idDruge = (int)room.Id + 100;
                    if (room.tip == TypeOfRoom.EXAMOPERATION)
                    {
                       
                        ExamOperationRoom soba1 = new ExamOperationRoom(idDruge);
                        foreach (ExamOperationRoom s1 in rooms)
                        {
                            if (s1.Id == room.Id)
                            {
                                sobaZaAdd = soba1;
                                sobaZaEdit = s1;
                                foreach (Equipment ek in sobaZaEdit.Equipments)
                                {
                                    int pola = ek.Quantity / 2;
                                    ek.Quantity -= pola;
                                    Equipment noviEk = new Equipment(ek.Id, ek.Naziv, pola);
                                    sobaZaAdd.Equipments.Add(noviEk);
                                }
                            }
                        }

                        _examOperationRoomController.Edit(sobaZaEdit);
                        _examOperationRoomController.Create(sobaZaAdd);
                        //Console.WriteLine(idDruge);
                    }
                    else
                    {
                        
                        RehabilitationRoom soba2 = new RehabilitationRoom(idDruge, 0, 5);
                        foreach (RehabilitationRoom s2 in rooms2)
                        {
                            if (s2.Id == room.Id)
                            {
                                sobaZaAdd2 = soba2;
                                sobaZaEdit2 = s2;
                                foreach (Equipment ek in sobaZaEdit2.Equipments)
                                {
                                    int pola = ek.Quantity / 2;
                                    ek.Quantity -= pola;
                                    Equipment noviEk = new Equipment(ek.Id, ek.Naziv, pola);
                                    sobaZaAdd2.Equipments.Add(noviEk);
                                }
                            }
                        }
                        _rehabilitationRoomController.Edit(sobaZaEdit2);
                        _rehabilitationRoomController.Create(sobaZaAdd2);
                        //Console.WriteLine("ovde2");
                    }
                }
                else
                {
                    dt1 = lastDate.AddDays(1);
                    dt2 = dt1.AddDays(difference);
                    List<Room> rooms = new List<Room>();
                    rooms.Add(room);
                    Renovation renovation = new Renovation(LongRandom(0, 1000000000, new Random()),TypeOfRenovation.SPLITTING, dt1, dt2, rooms);
                    _renovationController.Create(renovation);

                }
                //foreach (ek)
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
    }
}
