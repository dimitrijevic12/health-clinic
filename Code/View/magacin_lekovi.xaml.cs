using Controller;
using Model.Rooms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for magacin_lekovi.xaml
    /// </summary>
    public partial class magacin_lekovi : Window
    {
        private int colNum = 0;
        private Drug drug;
        private readonly IController<Drug> _drugController;
        //public static ObservableCollection<lekovi> Lekovi
        //{
        //    get;
        //    set;
        //}

        public static ObservableCollection<Drug> drugCollection
        {
            get;
            set;
        }

        public List<Drug> drugs;
        public magacin_lekovi()
        {
            InitializeComponent();
            this.DataContext = this;
            //Lekovi = new ObservableCollection<lekovi>();
            //Lekovi.Add(new lekovi() { Lek = "Brufen" , SifraLeka = "213", Kolicina = "10"});
            //Lekovi.Add(new lekovi() { Lek = "Paracetamol", SifraLeka = "442", Kolicina = "20" });
            var app = Application.Current as App;
            _drugController = app.drugController;

            drugs = _drugController.GetAll();
            drugCollection = new ObservableCollection<Drug>(drugs);
            dataGridMagacinLekovi.Items.Refresh();


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
    }
}
