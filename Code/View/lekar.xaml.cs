
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

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for lekar.xaml
    /// </summary>

    public partial class lekar : Window
    {
        private int colNum = 0;
        //lekari JedanLekar = new lekari();

        //static public ObservableCollection<lekari> Lekari
        //{
        //    get;
        //    set;
        //}

        //public void inicializuj()
        //{
        //    Lekari = new ObservableCollection<lekari>();
            
        //    //Lekari.Add(new lekari() { IdLekara = "1", Ime = "Marko", Prezime = "Markovic", Pol = "M", Jmbg = "213123213", DatumRodjenja = "11/11/1974", RadnoVreme = "08:00-16:00", Specijalista = "DA"});
        //    //Lekari.Add(new lekari() { IdLekara = "2", Ime = "Jovana", Prezime = "Jovanovic", Pol = "Z", Jmbg = "213123213", DatumRodjenja = "1/1/1964", RadnoVreme = "08:00-16:00", Specijalista = "NE"});
        //    //Lekari.Add(new lekari() { IdLekara = "4", Ime = "Lazar", Prezime = "Markovic", Pol = "M", Jmbg = "213123213", DatumRodjenja = "12/12/1974", RadnoVreme = "08:00-16:00", Specijalista = "NE"});
        //    //Lekari.Add(new lekari() { IdLekara = "4", Ime = "Sara", Prezime = "Simic", Pol = "Z", Jmbg = "2131123213", DatumRodjenja = "5/2/1984", RadnoVreme = "08:00-16:00", Specijalista = "DA"});

        //}
        public lekar()
        {
            InitializeComponent();
            this.DataContext = this;

            //if(Lekari == null)
            //{
            //    inicializuj();
            //}
            //else
            //{
            //    dataGridLekari.Items.Refresh();
            //}
           

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
            
        }

        private void Button_uredi(object sender, RoutedEventArgs e)
        {
           // var s = new projekatUpravnikRA137_2017.view.uredi_lekara(JedanLekar);
           // s.Show();

           
        }

        private void Button_obrisi(object sender, RoutedEventArgs e)
        {
            //Lekari.Remove(JedanLekar);
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
        //    try
        //    {
        //        var row_list = GetDataGridRows(dataGridLekari);
        //        foreach (DataGridRow single_row in row_list)
        //        {
        //            if (single_row.IsSelected == true)
        //            {
        //                JedanLekar = Lekari[single_row.GetIndex()];
        //            }
        //        }

        //    }
        //    catch { }
        }

        private void Button_edit(object sender, RoutedEventArgs e)
        {
            //var s = new projekatUpravnikRA137_2017.view.uredi_lekara(JedanLekar);
            //s.Show();

        }

        private void Button_delete(object sender, RoutedEventArgs e)
        {
            //Lekari.Remove(JedanLekar);
        }
    }
}
