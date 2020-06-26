using Controller;
using health_clinicClassDiagram.Controller;
using Model.Rooms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for premestanje_u_ovu.xaml
    /// </summary>
    public partial class premestanje_u_ovu : Window
    {
        private int colNum = 0;
        private readonly IExamOperationRoomController _examOperationRoomController;
        private readonly IRehabilitationRoomController _rehabilitationRoomController;
        private readonly IRoomController _roomController;
        private readonly IEquipmentController _equipController;
        private Room roomd;
        private Room roomd2;
        private Equipment equTest;

        //public static ObservableCollection<oprema_detaljno> DetaljnaOprema
        //{
        //    get;
        //    set;
        //}
        public static ObservableCollection<Equipment> equipCollection
        {
            get;
            set;
        }
        public List<ExamOperationRoom> rooms;
        public List<RehabilitationRoom> rooms2;
        public List<Room> finalRooms;
        public List<Equipment> equips;
        private ExamOperationRoom sobaZaDodavanje;
        private RehabilitationRoom sobaZaDodavanje2;
        public premestanje_u_ovu(Room room)
        {
            InitializeComponent();
            this.DataContext = this;
            var app = Application.Current as App;
            roomd = room;
            _equipController = app.equipController;
            _examOperationRoomController = app.examOperationRoomController;
            _rehabilitationRoomController = app.rehabilitationRoomController;
            _roomController = app.roomController;
            rooms = _examOperationRoomController.GetAll();
            rooms2 = _rehabilitationRoomController.GetAll();
            equips = _equipController.GetAll();
            equipCollection = new ObservableCollection<Equipment>(equips);
            dataGridIzSale2.Items.Refresh();
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


        private void Button_otkazi(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {

            if ((quantity.Text == "") || (comboEquip.SelectedIndex == -1))
            {
                string message = "Sva polja moraju biti popunjena!";
                string title = "Greška";

                MessageBox.Show(message, title);
            }
            else
            {

                string naz = equTest.Naziv;
                int IdOpreme = _equipController.getIdOpreme(naz);// int.Parse(id.Text);
                int quan = int.Parse(quantity.Text);
                // string naz = _equipController.getNazivOpreme(IdOpreme);
                Equipment equ = new Equipment(IdOpreme, naz, quan);

                int flag = 0;

                if (roomd.tip == TypeOfRoom.EXAMOPERATION)
                {
                    roomd = _examOperationRoomController.IncreaseQuantity(roomd, equ);
                }
                else
                {
                    roomd = _rehabilitationRoomController.IncreaseQuantity(roomd, equ);
                }
                /* if (roomd.Equipments != null)
                 {
                     //Console.WriteLine(" broj" + room.Equipments.Count);
                     foreach (Equipment ek in roomd.Equipments)
                     {
                         if (ek.Id == IdOpreme)
                         {
                             ek.Quantity += quan;
                             flag += 1;

                         }

                     }


                     if (flag == 0)
                     {
                         roomd.Equipments.Add(equ);
                         foreach (Equipment ek in roomd.Equipments)
                         {
                             // Console.WriteLine(ek.Id);
                         }
                     }
                 }
                 else
                 {

                     roomd.Equipments.Add(equ);


                 }*/

                sobaZaDodavanje = _examOperationRoomController.findExamRoom(roomd.Id);
               
                /* foreach (ExamOperationRoom r in rooms)
                 {
                     if (r.Id.Equals(roomd.Id))
                     {
                         sobaZaDodavanje = r;
                         sobaZaDodavanje.Equipments = roomd.Equipments;
                         break;
                     }
                 }*/
                sobaZaDodavanje2 = _rehabilitationRoomController.findRehabRoom(roomd.Id);
                
                /* foreach (RehabilitationRoom r in rooms2)
                 {
                     if (r.Id.Equals(roomd.Id))
                     {
                         sobaZaDodavanje2 = r;
                         sobaZaDodavanje2.Equipments = roomd.Equipments;
                         break;
                     }
                 }*/

                if (sobaZaDodavanje != null)
                {
                    sobaZaDodavanje.Equipments = roomd.Equipments;
                    _examOperationRoomController.Edit(sobaZaDodavanje);
                }
                else
                {
                    sobaZaDodavanje2.Equipments = roomd.Equipments;
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

        private void comboEquip_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            equTest = (Equipment)cb.SelectedItem;
        }
    }
}
