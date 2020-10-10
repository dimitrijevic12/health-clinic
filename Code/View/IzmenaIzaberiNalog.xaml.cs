using Controller;
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
    /// Interaction logic for IzmenaIzaberiNalog.xaml
    /// </summary>
    public partial class IzmenaIzaberiNalog : UserControl
    {
        private static MedicalRecord staticIzmenaRecord;
        private int colNum = 0;
        private readonly IMedicalRecordController _recordController;
        private MedicalRecord record;

        private DateTime _startDate;
        private DateTime _endDate;

        public static MedicalRecord StaticIzmenaRecord
        {
            get { return staticIzmenaRecord; }
            set { staticIzmenaRecord = value; }
        }
        public ObservableCollection<MedicalRecord> recordsCollection
        {
            get;
            set;
        }

        private DateTime _date;
        private ExamOperationRoom _room;
        private List<MedicalRecord> records;

        public IzmenaIzaberiNalog(DateTime date, DateTime startDate, DateTime endDate, ExamOperationRoom room)
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
            this.DataContext = this;

            /*var app = Application.Current as App;
            _recordController = app.MedicalRecordController;*/

            _recordController = MedicalRecordController.Instance;

            _startDate = startDate;
            _endDate = endDate;
            _date = date;
            _room = room;

            records = _recordController.GetAll();

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
                            StaticIzmenaRecord = records.ElementAt(single_row.GetIndex());

                        }
                    }
                }

            }
            catch { }
        }

        private void Button_Izaberi(object sender, RoutedEventArgs e)
        {
            IzmenaPregledaUser izmena = new IzmenaPregledaUser(_date, null, _room, _startDate, _endDate);
            (this.Parent as Panel).Children.Add(izmena);

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
    }
}
