using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for plan_lekar.xaml
    /// </summary>
    public partial class plan_lekar : Window
    {
        private int colNum = 0;

        //static public ObservableCollection<lekari> Lekari
        //{
        //    get;
        //    set;
        //}
        public plan_lekar()
        {
            InitializeComponent();
            this.DataContext = this;
            //Lekari = new ObservableCollection<lekari>();
            //Lekari.Add(new lekari() { IdLekara = "1", Ime = "Marko", Prezime = "Markovic", Pol = "M", Jmbg = "213123213", DatumRodjenja = "11/11/1974", RadnoVreme = "08:00-16:00", Specijalista = "DA" });
            //Lekari.Add(new lekari() { IdLekara = "2", Ime = "Jovana", Prezime = "Jovanovic", Pol = "Z", Jmbg = "213123213", DatumRodjenja = "1/1/1964", RadnoVreme = "08:00-16:00", Specijalista = "NE" });
            //Lekari.Add(new lekari() { IdLekara = "4", Ime = "Lazar", Prezime = "Markovic", Pol = "M", Jmbg = "213123213", DatumRodjenja = "12/12/1974", RadnoVreme = "08:00-16:00", Specijalista = "NE" });
            //Lekari.Add(new lekari() { IdLekara = "4", Ime = "Sara", Prezime = "Simic", Pol = "Z", Jmbg = "2131123213", DatumRodjenja = "5/2/1984", RadnoVreme = "08:00-16:00", Specijalista = "DA" });


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

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            var s = new plan_detaljan();
            s.Show();
        }
    }
}
