using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for odabrana_sala.xaml
    /// </summary>
    public partial class odabrana_sala : Window

        
    {
        private int colNum = 0;

        //public static ObservableCollection<oprema> Oprema
        //{
        //    get;
        //    set;
        //}

        public odabrana_sala()
        {
            InitializeComponent();
            this.DataContext = this;
            //Oprema = new ObservableCollection<oprema>();
            //Oprema.Add(new oprema() { VrstaOpreme = "Sto", Sifra = "1", Kolicina = "2" });
            //Oprema.Add(new oprema() { VrstaOpreme = "Krevet", Sifra = "2", Kolicina = "3" });
            //Oprema.Add(new oprema() { VrstaOpreme = "Stolica", Sifra = "3", Kolicina = "5" });

        }
        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }


        private void dataGridMagacinLekovi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_izadji(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void Button_izOve(object sender, RoutedEventArgs e)
        {
            var s = new premestanje_iz_ove();
            s.Show();
        }

      
        private void Button_uOvu(object sender, RoutedEventArgs e)
        {
            var s = new premestanje_u_ovu();
            s.Show();
        }
    }
}
