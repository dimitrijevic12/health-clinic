using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for premestanje_iz_ove.xaml
    /// </summary>
    public partial class premestanje_iz_ove : Window
    {
        private int colNum = 0;

        //public static ObservableCollection<oprema_detaljno> DetaljnaOprema
        //{
        //    get;
        //    set;
        //}
        public premestanje_iz_ove()
        {
            InitializeComponent();
            this.DataContext = this;
            //DetaljnaOprema = new ObservableCollection<oprema_detaljno>();
            //DetaljnaOprema.Add(new oprema_detaljno() { VrstaOpreme = "Sto", Sifra = "1", Id = "100" });
            //DetaljnaOprema.Add(new oprema_detaljno() { VrstaOpreme = "Sto", Sifra = "1", Id = "204" });
            //DetaljnaOprema.Add(new oprema_detaljno() { VrstaOpreme = "Stolica", Sifra = "3", Id = "304" });

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

        

        private void dataGridNaruciOpremu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

      

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
