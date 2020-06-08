using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for naruci_opremu.xaml
    /// </summary>
    public partial class naruci_opremu : Window
    {
        private int colNum = 0;

        //public static ObservableCollection<oprema> Oprema
        //{
        //    get;
        //    set;
        //}
        public naruci_opremu()
        {
            InitializeComponent();
            this.DataContext = this;
            //Oprema = new ObservableCollection<oprema>();
            //Oprema.Add(new oprema() { VrstaOpreme = "Sto", Sifra = "1", Kolicina = "10" });
            //Oprema.Add(new oprema() { VrstaOpreme = "Krevet", Sifra = "2", Kolicina = "20" });
            //Oprema.Add(new oprema() { VrstaOpreme = "Stolica", Sifra = "3", Kolicina = "14" });



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
    }
}
