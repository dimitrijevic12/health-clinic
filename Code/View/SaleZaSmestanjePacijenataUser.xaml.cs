using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        //private SaleZaSmestanje sala = null;
        //public static ObservableCollection<SaleZaSmestanje> Sale
        //{
        //    get;
        //    set;
        //}

        public void inicijalizujSale()
        {
            //Sale = new ObservableCollection<SaleZaSmestanje>();
            //Sale.Add(new SaleZaSmestanje() { Ime = "Sala 7", ZauzetiKreveti = 6, UkupniKreveti = 10 });
            //Sale.Add(new SaleZaSmestanje() { Ime = "Sala 8", ZauzetiKreveti = 3, UkupniKreveti = 10});
            //Sale.Add(new SaleZaSmestanje() { Ime = "Sala 9", ZauzetiKreveti = 1, UkupniKreveti = 5});
            //Sale.Add(new SaleZaSmestanje() { Ime = "Sala 10", ZauzetiKreveti = 3, UkupniKreveti = 5});
        }
        public SaleZaSmestanjePacijenataUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
            this.DataContext = this;

            //if (Sale == null)
            //{
            //    inicijalizujSale();
            //}
            //dataGridSale.Items.Refresh();
        }

        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Smesti(object sender, RoutedEventArgs e)
        {
            GridSale.Children.Clear();
            //SmestiPacijentaUser smesti = new SmestiPacijentaUser(sala);
            //GridSale.Children.Add(smesti);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            GridSale.Children.Clear();
            HomeUser home = new HomeUser();
            GridSale.Children.Add(home);
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

        //private void dataGridNSale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    try
        //    {
        //        var row_list = GetDataGridRows(dataGridSale);
        //        foreach (DataGridRow single_row in row_list)
        //        {
        //            if (single_row != null)
        //            {
        //                if (single_row.IsSelected == true)
        //                {

        //                    sala = Sale[single_row.GetIndex()];
        //                }
        //            }
        //        }

        //    }
        //    catch { }
        //}

        private void btnPrikazi_Click(object sender, RoutedEventArgs e)
        {
            GridSale.Children.Clear();
            PrikazSaleZaSmestanjePacijenataUser prikaz = new PrikazSaleZaSmestanjePacijenataUser();
            GridSale.Children.Add(prikaz);
        }
    }
}
