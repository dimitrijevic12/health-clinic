using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Collections;
using Model.Appointment;
using Controller;
using System.Linq;
using health_clinicClassDiagram.Service;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for RegistrovaniPacijentiUser.xaml
    /// </summary>
    public partial class RegistrovaniPacijentiUser : UserControl
    {
        private int colNum = 0;
        private readonly IMedicalRecordController _recordController;
        private MedicalRecord record;

        public static ObservableCollection<MedicalRecord> recordsCollection
        {
            get;
            set;
        }

        public List<MedicalRecord> records;
        
        public RegistrovaniPacijentiUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            this.DataContext = this;

            var app = Application.Current as App;
            _recordController = app.MedicalRecordController;

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

        private void Button_Kreiraj(object sender, RoutedEventArgs e)
        {
            
            KreirajNalogUser kreiraj = new KreirajNalogUser();
            (this.Parent as Panel).Children.Add(kreiraj);
        }

        private void Button_Obrisi(object sender, RoutedEventArgs e)
        {
            if (record == null)
            {               
                
                string message = "Niste izabrali nalog za brisanje";
                string title = "Greška";
                MessageBox.Show(message, title);
                                                          
            }
            else
            {
                _recordController.Delete(record);

                RegistrovaniPacijentiUser reg = new RegistrovaniPacijentiUser();
                (this.Parent as Panel).Children.Add(reg);
            }
        }

        private void Button_Izmeni(object sender, RoutedEventArgs e)
        {
            if (record == null)
            {

                string message = "Niste izabrali nalog za izmenu";
                string title = "Greška";
                MessageBox.Show(message, title);

            }
            else
            {
                IzmeniNalogUser izmeni = new IzmeniNalogUser(record);
                (this.Parent as Panel).Children.Add(izmeni);
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

        private void btnPrikazi_Click(object sender, RoutedEventArgs e)
        {
            TretmaniUser tretmani = new TretmaniUser(record);
            (this.Parent as Panel).Children.Add(tretmani);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void textSearch_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var filter = records.Where(MedicalRecord => MedicalRecord.Name.Contains(textSearch.Text));
            dataGridNalozi.ItemsSource = filter;
        }
    }
}
