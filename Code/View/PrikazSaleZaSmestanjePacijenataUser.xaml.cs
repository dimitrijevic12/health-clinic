using health_clinicClassDiagram.Controller;
using Model.Appointment;
using Model.Rooms;
using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for PrikazSaleZaSmestanjePacijenataUser.xaml
    /// </summary>
    public partial class PrikazSaleZaSmestanjePacijenataUser : UserControl
    {
        private int colNum = 0;
        
        private MedicalRecord record;
        public static ObservableCollection<MedicalRecord> recordsCollection
        {
            get;
            set;
        }

        public List<MedicalRecord> records;
        private RehabilitationRoom rehabilitationRoom;

        private readonly IRehabilitationRoomController _rehabilitationRoomController;

        public PrikazSaleZaSmestanjePacijenataUser(RehabilitationRoom rehabilitationRoom)
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
            labelSala.Content = "Sala broj " + rehabilitationRoom.IdRoom.ToString();

            this.DataContext = this;
            this.rehabilitationRoom = rehabilitationRoom;

            var app = Application.Current as App;
            _rehabilitationRoomController = app.RehabilitationRoomController;

            records = rehabilitationRoom.Patients;

            recordsCollection = new ObservableCollection<MedicalRecord>(records);

            dataGridNalozi.Items.Refresh();
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

        private void dataGridNalozi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var row_list = GetDataGridRows(dataGridNalozi);
                foreach (DataGridRow single_row in row_list)
                {
                    if (single_row != null)
                    {
                        if (single_row.IsSelected == true)
                        {
                            record = records.ElementAt(single_row.GetIndex());

                        }
                    }
                }

            }
            catch { }
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void Button_Izadji(object sender, RoutedEventArgs e)
        {
            SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
            (this.Parent as Panel).Children.Add(sale);
        }

        private void Button_Otpusti(object sender, RoutedEventArgs e)
        {
            if (record == null)
            {
                string message = "Morate izabrati nalog za brisanje";
                string title = "Greška";
                MessageBox.Show(message, title);
            } else
            {
                _rehabilitationRoomController.releasePatient(record, rehabilitationRoom);

                SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
                (this.Parent as Panel).Children.Add(sale);
            }
            
        }
    }
}
