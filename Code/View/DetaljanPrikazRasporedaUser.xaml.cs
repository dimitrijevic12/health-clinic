using health_clinicClassDiagram.View.Util;
using Model.Appointment;
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
    /// Interaction logic for DetaljanPrikazRasporedaUser.xaml
    /// </summary>
    public partial class DetaljanPrikazRasporedaUser : UserControl
    {
        private int colNum = 0;
        private DateTime date;
        private Appointment appointment;

        List<Appointment> blankAppointments = AppointmentGenerator.Instance.generateList(DateTime.Today);

        public List<Appointment> BlankAppointments { get => blankAppointments; set => blankAppointments = value; }

        public static ObservableCollection<Appointment> appointmentCollection
        {
            get;
            set;
        }

        public DetaljanPrikazRasporedaUser(DateTime date)
        {
            InitializeComponent();
            Datum.Content = date.ToShortDateString();
            this.DataContext = this;
            this.date = date;
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            appointmentCollection = new ObservableCollection<Appointment>(BlankAppointments);

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
                            appointment = appointmentCollection.ElementAt(single_row.GetIndex());

                        }
                    }
                }

            }
            catch { }
        }

        private void Button_Zakazivanje(object sender, RoutedEventArgs e)
        {
            
            ZakazivanjePregledaUser zakazivanje = new ZakazivanjePregledaUser(date);
            (this.Parent as Panel).Children.Add(zakazivanje);
        }

        private void Button_Otkazivanje(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Izmena(object sender, RoutedEventArgs e)
        {
            
            IzmenaPregledaUser izmena = new IzmenaPregledaUser(date);
            (this.Parent as Panel).Children.Add(izmena);
        }

        private void Button_Guest(object sender, RoutedEventArgs e)
        {
            
            ZakazivanjeGuestNalogaUser zakazivanje = new ZakazivanjeGuestNalogaUser(date);
            (this.Parent as Panel).Children.Add(zakazivanje);
        }

        private void Button_Prikaz(object sender, RoutedEventArgs e)
        {
            
            SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
            (this.Parent as Panel).Children.Add(sale);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {

            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(2, thisCount);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
