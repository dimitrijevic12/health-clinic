using System.Windows;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for uredi_lekara.xaml
    /// </summary>
    public partial class uredi_lekara : Window
    {
        public uredi_lekara(/*lekari Lekar*/)
        {
            InitializeComponent();

            //IdLekara.Text = Lekar.IdLekara;
            //Ime.Text = Lekar.Ime;
            //Prezime.Text = Lekar.Prezime;
            //Jmbg.Text = Lekar.Jmbg;
            //DatumRodjenja.Text = Lekar.DatumRodjenja;
            //RadnoVreme.Text = Lekar.RadnoVreme;
            //Specijalista.Text = Lekar.Specijalista;

        }

        private void Button_otkazi(object sender, RoutedEventArgs e)
        {
          
            this.Close();
        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {

            this.Close();

        }

       

       
    }
}
