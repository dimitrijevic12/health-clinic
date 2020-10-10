using health_clinicClassDiagram.Controller;
using Model.Rooms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for SaleZaSmestanjePacijenataUser.xaml
    /// </summary>
    public partial class SaleZaSmestanjePacijenataUser : UserControl
    {
        private int colNum = 0;

        private readonly IRehabilitationRoomController _rehabilitationRoomController;
        private RehabilitationRoom rehabilitationRoom;

        public static ObservableCollection<RehabilitationRoom> rehabilitationRoomsCollection
        {
            get;
            set;
        }

        public List<RehabilitationRoom> rehabilitationRooms;

        

        public SaleZaSmestanjePacijenataUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
            this.DataContext = this;

            _rehabilitationRoomController = RehabilitationRoomController.Instance;

            rehabilitationRooms = _rehabilitationRoomController.GetAll();

            rehabilitationRoomsCollection = new ObservableCollection<RehabilitationRoom>(rehabilitationRooms);

            dataGridSale.Items.Refresh();           

        }

        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Smesti(object sender, RoutedEventArgs e)
        {
            if (rehabilitationRoom == null)
            {
                string message = "Morate izabrati sobu";
                string title = "Greška";
                MessageBox.Show(message, title);
            }
            else
            {
                if (rehabilitationRoom.CurrentlyInUse >= rehabilitationRoom.MaxCapacity)
                {
                    string message = "Sala je vec puna";
                    string title = "Greška";
                    MessageBox.Show(message, title);
                }
                else
                {

                    SmestiPacijentaUser smesti = new SmestiPacijentaUser(rehabilitationRoom);
                    (this.Parent as Panel).Children.Add(smesti);
                }
            }
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
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

        private void dataGridNSale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var row_list = GetDataGridRows(dataGridSale);
                foreach (DataGridRow single_row in row_list)
                {
                    if (single_row != null)
                    {
                        if (single_row.IsSelected == true)
                        {
                            rehabilitationRoom = rehabilitationRooms.ElementAt(single_row.GetIndex());
                        }
                    }
                }

            }
            catch { }
        }

        private void btnPrikazi_Click(object sender, RoutedEventArgs e)
        {
            
            PrikazSaleZaSmestanjePacijenataUser prikaz = new PrikazSaleZaSmestanjePacijenataUser(rehabilitationRoom);
            (this.Parent as Panel).Children.Add(prikaz);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
