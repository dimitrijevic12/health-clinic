using Controller;
using health_clinicClassDiagram.Controller;
using Model.Appointment;
using Model.Rooms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for prikaz_opreme.xaml
    /// </summary>
    public partial class prikaz_opreme : Window
    {

        private int colNum = 0;

        private readonly IController<ExamOperationRoom> _examOperationRoomController;
        private readonly IController<RehabilitationRoom> _rehabilitationRoomController;
        private Room roomD;
                //examOperationRoom

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

        public prikaz_opreme()
        {
            InitializeComponent();
            this.DataContext = this;

            
            _examOperationRoomController = ExamOperationRoomController.Instance;
            _rehabilitationRoomController = RehabilitationRoomController.Instance;



            rooms = _examOperationRoomController.GetAll();
            rooms2 = _rehabilitationRoomController.GetAll();

            finalRooms = rooms2.Cast<Room>().ToList();

            finalRooms.AddRange(rooms);
            //finalRooms.AddRange(rooms2);

            roomsCollection = new ObservableCollection<Room>(finalRooms);

            dataGridSale.Items.Refresh();

            //if (Spisak == null)
            //{
            //    inicijalizuj();
            //}
            //else
            //{
            //    dataGridSale.Items.Refresh();
            //}


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

        private void dataGridSale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var row_list = GetDataGridRows(dataGridSale);
                foreach (DataGridRow single_row in row_list)
                {
                    if (single_row.IsSelected == true)
                    {
                        roomD = finalRooms.ElementAt(single_row.GetIndex());

                    }
                }

            }
            catch { }
        }
        private void Button_otkazi(object sender, RoutedEventArgs e)
        {

            this.Close();

        }

      /*  private void Button_sala(object sender, RoutedEventArgs e)
        {
            var s = new odabrana_sala();
            s.Show();
        }*/

      

        private void Button_Detaljno(object sender, RoutedEventArgs e)
        {
            var s = new odabrana_sala(roomD);
            s.Show();
        }

        private void Button_Obrisi(object sender, RoutedEventArgs e)
        {
           
          if (roomD.tip.Equals(TypeOfRoom.REHABILITATION))
            {
               
                RehabilitationRoom deleteRoom = new RehabilitationRoom(roomD.Id, 0 , 0, new List<MedicalRecord>());
                _rehabilitationRoomController.Delete(deleteRoom);
            }
            else
            {
                ExamOperationRoom deleteRoom2 = new ExamOperationRoom(roomD.Id);
                _examOperationRoomController.Delete(deleteRoom2);
            }
            var s = new prikaz_opreme();
            s.Show();
            this.Close();
            
        }

        private void pretragaSale_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var filter = finalRooms.Where(Room => Room.Id.ToString().Contains(pretragaSale.Text) || Room.tip.ToString().Contains(pretragaSale.Text));
            dataGridSale.ItemsSource = filter;
        }
    }
}
