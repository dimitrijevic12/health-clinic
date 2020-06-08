using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for naruci_lek.xaml
    /// </summary>
    public partial class naruci_lek : Window
    {
        private int colNum = 0;

        //public static ObservableCollection<lekovi> Lekovi
        //{
        //    get;
        //    set;
        //}
        public naruci_lek()
        {
            InitializeComponent();
            this.DataContext = this;
            //Lekovi = new ObservableCollection<lekovi>();
            //Lekovi.Add(new lekovi() { Lek = "Brufen", SifraLeka = "213", Kolicina = "10" });
            //Lekovi.Add(new lekovi() { Lek = "Paracetamol", SifraLeka = "442", Kolicina = "20" });

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
