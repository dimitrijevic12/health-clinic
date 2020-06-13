using Controller;
using Model.Rooms;
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

        private readonly IEquipmentController _equipController;

        //public static ObservableCollection<oprema> Oprema
        //{
        //    get;
        //    set;
        //}
        public naruci_opremu()
        {
            InitializeComponent();
            this.DataContext = this;
            var app = Application.Current as App;
            _equipController = app.equipController;
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

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            int idSalji = equipCombo.SelectedIndex;

            int quant = int.Parse(quantity.Text);

            _equipController.addEquipment(idSalji, quant);

            this.Close();


        }
    }
}
