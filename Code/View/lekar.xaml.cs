
using System;
using System.Collections.Generic;
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
using System.Collections.ObjectModel;

using System.Collections;
using Controller;
using Model.SystemUsers;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for lekar.xaml
    /// </summary>

    public partial class lekar : Window
    {
        private int colNum = 0;
        private readonly IController<Doctor> _doctorController;
        private Doctor doctor;
        

        public static ObservableCollection<Doctor> doctorsCollection
        {
            get;
            set;
        }

        public List<Doctor> doctors;

        public lekar()
        {
            InitializeComponent();
            this.DataContext = this;

            var app = Application.Current as App;
            _doctorController = app.doctorController;

            doctors = _doctorController.GetAll();

            doctorsCollection = new ObservableCollection<Doctor>(doctors);

            dataGridLekari.Items.Refresh();          

        }
        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_pocetna(object sender, RoutedEventArgs e)
        {
            var s = new pocetna();
            s.Show();
            this.Close();

        }

        private void Button_novi(object sender, RoutedEventArgs e)
        {
            var s = new novi_lekar();
            s.Show();
            this.Close();
            /* var s = new uredi_lekara(doctor);
             s.Show();
             this.Close();*/


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

        private void dataGridLekari_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var row_list = GetDataGridRows(dataGridLekari);
                foreach (DataGridRow single_row in row_list)
                {
                    if (single_row.IsSelected == true)
                    {
                        doctor = doctors.ElementAt(single_row.GetIndex());
                        
                    }
                }

            }
            catch { }
        }

        private void Button_edit(object sender, RoutedEventArgs e)
        {
            //var s = new projekatUpravnikRA137_2017.view.uredi_lekara(JedanLekar);
            //s.Show();
            var s = new uredi_lekara(doctor);
            s.Show();
            this.Close();
        }

        private void Button_delete(object sender, RoutedEventArgs e)
        {
            //Lekari.Remove(JedanLekar);
            _doctorController.Delete(doctor);
            var s = new lekar();
            s.Show();
            this.Close();

        }
    }
}
