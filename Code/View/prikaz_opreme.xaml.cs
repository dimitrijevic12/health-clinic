using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for prikaz_opreme.xaml
    /// </summary>
    public partial class prikaz_opreme : Window
    {

        private int colNum = 0;

        //public static ObservableCollection<SpisakSala> Spisak
        //{
        //    get;
        //    set;
        //}

        public void inicijalizuj()
        {
            
            //Spisak = new ObservableCollection<SpisakSala>();
            //Spisak.Add(new SpisakSala { Sala = "101", TipSale = "Operaciona" });
            //Spisak.Add(new SpisakSala { Sala = "102", TipSale = "Kontrolna " });
            //Spisak.Add(new SpisakSala { Sala = "103", TipSale = "Operaciona" });
            //Spisak.Add(new SpisakSala { Sala = "104", TipSale = "Rehabilitaciona" });
        }
        public prikaz_opreme()
        {
            InitializeComponent();
            this.DataContext = this;


            //if (Spisak == null)
            //{
            //    inicijalizuj();
            //}
            //else
            //{
            //    dataGridSale.Items.Refresh();
            //}


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

        private void Button_sala(object sender, RoutedEventArgs e)
        {
            var s = new odabrana_sala();
            s.Show();
        }

        private void dataGridSale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Detaljno(object sender, RoutedEventArgs e)
        {
            var s = new odabrana_sala();
            s.Show();
        }

        private void Button_Obrisi(object sender, RoutedEventArgs e)
        {
            var s = new odabrana_sala();
            s.Show();
        }
    }
}
