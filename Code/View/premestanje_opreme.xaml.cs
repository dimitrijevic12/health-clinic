using Controller;
using health_clinicClassDiagram.Controller;
using Model.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.ModelBinding;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for premestanje_opreme.xaml
    /// </summary>
    public partial class premestanje_opreme : Window
    {
        private readonly IExamOperationRoomController _examOperationRoomController;
        private readonly IRehabilitationRoomController _rehabilitationRoomController;
        private readonly IRoomController _roomController;
        private readonly IEquipmentController _equipController;
        private Room room;
        private Equipment equTest;
        
        private int colNum = 0;

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
        //public static ObservableCollection<oprema_detaljno> DetaljnaOprema
        //{
        //    get;
        //    set;
        //}

        public List<ExamOperationRoom> rooms;
        public List<RehabilitationRoom> rooms2;
        public List<Room> finalRooms;
        public List<Equipment> equips;
        private ExamOperationRoom sobaZaDodavanje;
        private RehabilitationRoom sobaZaDodavanje2;
        public premestanje_opreme()
        {
            InitializeComponent();
            this.DataContext = this;
            var app = Application.Current as App;
            _equipController = EquipmentController.Instance;
            _examOperationRoomController = ExamOperationRoomController.Instance;
            _rehabilitationRoomController = RehabilitationRoomController.Instance;
            _roomController = RoomController.Instance;
            rooms = _examOperationRoomController.GetAll();
            rooms2 = _rehabilitationRoomController.GetAll();

            finalRooms = rooms2.Cast<Room>().ToList();

            finalRooms.AddRange(rooms);
            

            roomsCollection = new ObservableCollection<Room>(finalRooms);

            equips = _equipController.GetAll();
            equipCollection = new ObservableCollection<Equipment>(equips);
            dataGridIzMagacina.Items.Refresh();
            //DetaljnaOprema = new ObservableCollection<oprema_detaljno>();
            //DetaljnaOprema.Add(new oprema_detaljno() { VrstaOpreme = "Sto", Sifra = "1", Id = "100" });
            //DetaljnaOprema.Add(new oprema_detaljno() { VrstaOpreme = "Sto", Sifra = "1", Id = "204" });
            //DetaljnaOprema.Add(new oprema_detaljno() { VrstaOpreme = "Stolica", Sifra = "3", Id = "304" });
        }
        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void dataGridNaruciOpremu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            if ((quantity.Text == "") || (comboSala.SelectedIndex == -1) || (comboEquip.SelectedIndex == -1))
            {
                string message = "Sva polja moraju biti popunjena!";
                string title = "Greška";

                MessageBox.Show(message, title);
            }
            else
            {

                string naz = equTest.Name;
                long IdOpreme = _equipController.getIdOpreme(naz);// int.Parse(id.Text);
                int quan = int.Parse(quantity.Text);
                // string naz = _equipController.getNazivOpreme(IdOpreme);
                Equipment equ = new Equipment(IdOpreme, naz, quan);


                if(room.tip == TypeOfRoom.EXAMOPERATION)
                {
                    room = _examOperationRoomController.IncreaseQuantity(room, equ);
                }
                else
                {
                    room = _rehabilitationRoomController.IncreaseQuantity(room, equ);
                }
               
              /*  int flag = 0;
                if (room.Equipments != null)
                {
                    //Console.WriteLine(" broj" + room.Equipments.Count);
                    foreach (Equipment ek in room.Equipments)
                    {
                        if (ek.Id == IdOpreme)
                        {
                            ek.Quantity += quan;
                            flag += 1;

                        }

                    }

                    if (flag == 0)
                    {
                        room.Equipments.Add(equ);
                        foreach (Equipment ek in room.Equipments)
                        {
                            // Console.WriteLine(ek.Id);
                        }
                    }
                }
                else
                {

                    room.Equipments.Add(equ);


                }*/

                /*foreach (ExamOperationRoom r in rooms)
                {
                    if (r.Id.Equals(room.Id))
                    {
                        sobaZaDodavanje = r;
                        sobaZaDodavanje.Equipments = room.Equipments;
                        break;
                    }
                }

                foreach (RehabilitationRoom r in rooms2)
                {
                    if (r.Id.Equals(room.Id))
                    {
                        sobaZaDodavanje2 = r;
                        sobaZaDodavanje2.Equipments = room.Equipments;
                        break;
                    }
                }*/

                sobaZaDodavanje = _examOperationRoomController.GetRoomById(room.Id);

                sobaZaDodavanje2 = _rehabilitationRoomController.GetRoomById(room.Id);

                if (sobaZaDodavanje != null)
                {
                    sobaZaDodavanje.Equipments = room.Equipments;
                    _examOperationRoomController.Edit(sobaZaDodavanje);
                }
                else
                {
                    sobaZaDodavanje2.Equipments = room.Equipments;
                    _rehabilitationRoomController.Edit(sobaZaDodavanje2);
                }

                /* foreach (Equipment es in room.Equipments)
                 {
                     Console.WriteLine(es.Ispisi().ToString());
                 }
     */
                _equipController.deleteEquipment(IdOpreme, quan);


                this.Close();
            }
        }

        private void Button_otkazi(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tip_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            room = (Room)cb.SelectedItem;
        }

        private void comboEquip_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            equTest= (Equipment)cb.SelectedItem;
        }
    }
}
