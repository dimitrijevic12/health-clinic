
using Controller;
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
    /// Interaction logic for namena_sale.xaml
    /// </summary>
    public partial class namena_sale : Window
    {
        private int colNum = 0;
        private readonly IController<ExamOperationRoom> _examOperationRoomController;
        private readonly IController<RehabilitationRoom> _rehabilitationRoomController;
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
            var app = Application.Current as App;
            _examOperationRoomController = app.examOperationRoomController;
            _rehabilitationRoomController = app.rehabilitationRoomController;



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

                DateTime dt1 = DateTime.Now;
                DateTime dt2 = (DateTime)DatumPicker.SelectedDate;
                int result = DateTime.Compare(dt1, dt2);
                if (DateTime.Now.Date == dt2)
                {
                    //Console.WriteLine("dosao ovde");
                    String tipSale;
                    if (tip.SelectedIndex == 0)
                    {
                        foreach (ExamOperationRoom r in rooms)
                        {
                            if (r.Id.Equals(room.Id))
                            {
                                sobaZaDodavanje = r;
                                sobaZaDodavanje.tip = TypeOfRoom.EXAMOPERATION;
                                break;
                            }
                        }
                        foreach (RehabilitationRoom r in rooms2)
                        {
                            if (r.Id.Equals(room.Id))
                            {
                                sobaZaDodavanje2 = r;
                                sobaZaDodavanje2.tip = TypeOfRoom.EXAMOPERATION;
                                break;
                            }
                        }
                        if (sobaZaDodavanje != null)
                        {
                            /* bool del = _examOperationRoomController.Delete(sobaZaDodavanje);
                             RehabilitationRoom roomZaDodati = new RehabilitationRoom(sobaZaDodavanje.Id, 0, 5, sobaZaDodavanje.Equipments);
                             RehabilitationRoom r = _rehabilitationRoomController.Create(roomZaDodati);*/
                            //Console.WriteLine("dosao ovde1");
                        }
                        else
                        {
                            // Console.WriteLine("dosao ovde2");
                            bool del = _rehabilitationRoomController.Delete(sobaZaDodavanje2);
                            ExamOperationRoom roomZaDodati = new ExamOperationRoom(sobaZaDodavanje2.Id, sobaZaDodavanje2.Equipments);
                            ExamOperationRoom r = _examOperationRoomController.Create(roomZaDodati);
                        }
                    }
                    else
                    {
                        foreach (ExamOperationRoom r in rooms)
                        {
                            if (r.Id.Equals(room.Id))
                            {
                                sobaZaDodavanje = r;
                                sobaZaDodavanje.tip = TypeOfRoom.REHABILITATION;
                                break;
                            }
                        }
                        foreach (RehabilitationRoom r in rooms2)
                        {
                            if (r.Id.Equals(room.Id))
                            {
                                sobaZaDodavanje2 = r;
                                sobaZaDodavanje2.tip = TypeOfRoom.REHABILITATION;
                                break;
                            }
                        }
                        if (sobaZaDodavanje != null)
                        {
                            bool del = _examOperationRoomController.Delete(sobaZaDodavanje);
                            RehabilitationRoom roomZaDodati = new RehabilitationRoom(sobaZaDodavanje.Id, 0, 5, sobaZaDodavanje.Equipments);
                            RehabilitationRoom r = _rehabilitationRoomController.Create(roomZaDodati);
                            // Console.WriteLine("dosao ovde3");
                            //_examOperationRoomController.Edit(sobaZaDodavanje);
                        }
                        else
                        {
                            /* bool del = _rehabilitationRoomController.Delete(sobaZaDodavanje2);
                             ExamOperationRoom roomZaDodati = new ExamOperationRoom(sobaZaDodavanje2.Id, sobaZaDodavanje2.Equipments);
                             ExamOperationRoom r = _examOperationRoomController.Create(roomZaDodati);*/
                            //Console.WriteLine("dosao ovde4");
                            //_rehabilitationRoomController.Edit(sobaZaDodavanje2);
                        }
                    }
                }

                this.Close();
            }
        }

        private void comboSala_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            room = (Room)cb.SelectedItem;
        }
    }
}
