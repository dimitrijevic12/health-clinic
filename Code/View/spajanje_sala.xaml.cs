using Controller;
using health_clinicClassDiagram.Controller;
using Model.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Configuration;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for spajanje_sala.xaml
    /// </summary>
    public partial class spajanje_sala : Window
    {
        private int colNum = 0;
        private readonly IController<ExamOperationRoom> _examOperationRoomController;
        private readonly IController<RehabilitationRoom> _rehabilitationRoomController;
        private readonly IAppointmentController _appointmentController;
        private readonly IRenovationController _renovationController;
        private Room room1;
        private Room room2;
        private Equipment equ;
      

        //public static ObservableCollection<SpisakSala> Spisak
        //{
        //    get;
        //    set;
        //}
        public static ObservableCollection<Room> roomsCollection
        {
            get;
            set;
        }
        public List<ExamOperationRoom> rooms;
        public List<RehabilitationRoom> rooms2;
        public List<Room> finalRooms;
        public List<Equipment> equips;
        private ExamOperationRoom sobaZaBrisanje;
        private RehabilitationRoom sobaZaBrisanje2;
        private ExamOperationRoom sobaZaEdit;
        private RehabilitationRoom sobaZaEdit2;
        public spajanje_sala()
        {
            InitializeComponent();
            this.DataContext = this;
            //Spisak = new ObservableCollection<SpisakSala>();
            //Spisak.Add(new SpisakSala { Sala = "101", TipSale = "Operaciona" });
            //Spisak.Add(new SpisakSala { Sala = "103", TipSale = "Operaciona" });
            
            //_equipController = app.equipController;
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

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            if ((datep1.ToString() == "") || (datep2.ToString() == "") || (comboSala1.SelectedIndex == -1) || (comboSala2.SelectedIndex == -1))
            {
                string message = "Sva polja moraju biti popunjena!";
                string title = "Greška";

                MessageBox.Show(message, title);
            }
            else
            {
                DateTime dt1 = (DateTime)datep1.SelectedDate;
                DateTime dt2 = (DateTime)datep2.SelectedDate;
                
                int difference = (dt2.Date - dt1.Date).Days;
                DateTime lastDate1 = _appointmentController.GetLastDateOfAppointmentForRoom(room1);
                DateTime lastDate2 = _appointmentController.GetLastDateOfAppointmentForRoom(room2);
                DateTime lastDate = lastDate1;
                if (lastDate1 < lastDate2) { lastDate = lastDate2; }
                
                


                //int result = DateTime.Compare(dt1, dt2);
                if (lastDate < dt1 && DateTime.Now.Date == dt1)
                {
                    List<Room> roomsReturn = new List<Room>();
                    roomsReturn.Add(room1);
                    roomsReturn.Add(room2);
                    Renovation renovation = new Renovation(LongRandom(0, 1000000000, new Random()), TypeOfRenovation.MERGING, dt1, dt2, roomsReturn);
                    _renovationController.Create(renovation);
                    foreach (Equipment ek2 in room2.Equipments)
                    {
                        int flag = 0;

                        foreach (Equipment ek1 in room1.Equipments)
                        {
                            if (ek2.Id == ek1.Id)
                            {
                                ek1.Quantity += ek2.Quantity;
                                flag += 1;

                            }
                           

                        }
                        if (flag == 0)
                        {
                            room1.Equipments.Add(ek2);
                        }
                    }

                    sobaZaEdit = ExamOperationRoomController.Instance.GetRoomById(room1.Id);

                    
                   

                    if (sobaZaEdit != null)
                    {
                        _examOperationRoomController.Edit(sobaZaEdit);
                    }
                    else
                    {
                        sobaZaEdit2 = RehabilitationRoomController.Instance.GetRoomById(room1.Id);
                        _rehabilitationRoomController.Edit(sobaZaEdit2);
                    }


                    sobaZaBrisanje = ExamOperationRoomController.Instance.GetRoomById(room2.Id);

                    
                   

                    if (sobaZaBrisanje != null)
                    {
                        _examOperationRoomController.Delete(sobaZaBrisanje);
                    }
                    else
                    {
                        sobaZaBrisanje2 = RehabilitationRoomController.Instance.GetRoomById(room2.Id);
                        _rehabilitationRoomController.Delete(sobaZaBrisanje2);
                    }
                    
                }
                else
                {
                    if(lastDate > dt1) 
                    { 
                    dt1 = lastDate.AddDays(1);
                    dt2 = dt1.AddDays(difference);
                    }
                    List<Room> roomsReturn = new List<Room>();
                    roomsReturn.Add(room1);
                    roomsReturn.Add(room2);
                    Renovation renovation = new Renovation(LongRandom(0, 1000000000, new Random()), TypeOfRenovation.MERGING, dt1, dt2, roomsReturn);
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

        private void comboSala1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            room1 = (Room)cb.SelectedItem;
        }

        private void comboSala2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            room2 = (Room)cb.SelectedItem;
        }
    }
}
