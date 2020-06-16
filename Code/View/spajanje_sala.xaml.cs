using Controller;
using Model.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
            var app = Application.Current as App;
            //_equipController = app.equipController;
            _examOperationRoomController = app.examOperationRoomController;
            _rehabilitationRoomController = app.rehabilitationRoomController;
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
                //int result = DateTime.Compare(dt1, dt2);
                if (DateTime.Now.Date == dt1)
                {

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
                            //equ = ek2;

                        }
                        if (flag == 0)
                        {
                            room1.Equipments.Add(ek2);
                        }
                    }


                    foreach (ExamOperationRoom r in rooms)
                    {
                        if (r.Id.Equals(room1.Id))
                        {
                            sobaZaEdit = r;

                            break;
                        }
                    }

                    foreach (RehabilitationRoom r in rooms2)
                    {
                        if (r.Id.Equals(room1.Id))
                        {
                            sobaZaEdit2 = r;

                            break;
                        }
                    }

                    if (sobaZaEdit != null)
                    {
                        _examOperationRoomController.Edit(sobaZaEdit);
                    }
                    else
                    {
                        _rehabilitationRoomController.Edit(sobaZaEdit2);
                    }



                    foreach (ExamOperationRoom r in rooms)
                    {
                        if (r.Id.Equals(room2.Id))
                        {
                            sobaZaBrisanje = r;

                            break;
                        }
                    }

                    foreach (RehabilitationRoom r in rooms2)
                    {
                        if (r.Id.Equals(room2.Id))
                        {
                            sobaZaBrisanje2 = r;

                            break;
                        }
                    }

                    if (sobaZaBrisanje != null)
                    {
                        _examOperationRoomController.Delete(sobaZaBrisanje);
                    }
                    else
                    {
                        _rehabilitationRoomController.Delete(sobaZaBrisanje2);
                    }
                }
                this.Close();
            }
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
