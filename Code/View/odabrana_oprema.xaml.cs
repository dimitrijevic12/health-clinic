using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for odabrana_oprema.xaml
    /// </summary>
    public partial class odabrana_oprema : Window
    {
        private int colNum = 0;

        //public static ObservableCollection<oprema_detaljno> DetaljnaOprema
        //{
        //    get;
        //    set;
        //}
        public odabrana_oprema()
        {
            InitializeComponent();
            this.DataContext = this;
            //DetaljnaOprema = new ObservableCollection<oprema_detaljno>();
            //DetaljnaOprema.Add(new oprema_detaljno() { VrstaOpreme = "Sto", Sifra = "1", Id = "100"});
            //DetaljnaOprema.Add(new oprema_detaljno() { VrstaOpreme = "Sto", Sifra = "1", Id = "204"});

        }
        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_izadji(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void dataGridDetaljnaOprema_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
