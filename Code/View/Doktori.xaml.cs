using Model.SystemUsers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for Doktori.xaml
    /// </summary>
    public partial class Doktori : UserControl
    {
        private int colNum = 0;
        private Doctor doktor;
        //public static ObservableCollection<Doktor> DoktoriCollection
        //{
        //    get;
        //    set;
        //}

        private void naloziInicijalizacija()
        {
            //DoktoriCollection = new ObservableCollection<Doktor>();
            //DoktoriCollection.Add(new Doktor() { IDDoktora = 1, Ime = "Ana", Prezime = "Peric", JMBG = 111111, Pol = EnumPol.Z, Specijalista = true, DatumRodjenja = "13/13/13", RadonVreme = "08:00/16:00" });
            //DoktoriCollection.Add(new Doktor() { IDDoktora = 2, Ime = "Lenka", Prezime = "Markovic", JMBG = 222222, Pol = EnumPol.Z, Specijalista = false, DatumRodjenja = "13/13/13", RadonVreme = "08:00/16:00" });
            //DoktoriCollection.Add(new Doktor() { IDDoktora = 3, Ime = "Nikola", Prezime = "Nikolic", JMBG = 333333, Pol = EnumPol.M, Specijalista = true, DatumRodjenja = "13/13/13", RadonVreme = "08:00/16:00" });

        }

        public Doktori()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            this.DataContext = this;

            //if (DoktoriCollection == null)
            //{
            //    naloziInicijalizacija();
            //}
            //dataGridDoktori.Items.Refresh();
        }

        //private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        //{
        //    colNum++;
        //    if (colNum == 3)
        //        e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        //}

        //public IEnumerable<DataGridRow> GetDataGridRows(DataGrid grid)
        //{
        //    var itemsSource = grid.ItemsSource as IEnumerable;
        //    if (null == itemsSource) yield return null;
        //    foreach (var item in itemsSource)
        //    {
        //        var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
        //        if (null != row) yield return row;
        //    }
        //}

        //private void dataGridDoktori_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    try
        //    {
        //        var row_list = GetDataGridRows(dataGridDoktori);
        //        foreach (DataGridRow single_row in row_list)
        //        {
        //            if (single_row != null)
        //            {
        //                if (single_row.IsSelected == true)
        //                {

        //                    doktor = DoktoriCollection[single_row.GetIndex()];
        //                }
        //            }
        //        }

        //    }
        //    catch { }
        //}

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            GridDoktori.Children.Clear();
            HomeUser home = new HomeUser();
            GridDoktori.Children.Add(home);
        }
    }
}
