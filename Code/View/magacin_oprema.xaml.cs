using Controller;
using Model.Rooms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for lista_lekova.xaml
    /// </summary>
    public partial class magacin_oprema : Window
    {
        private int colNum = 0;
        private Equipment equip;
        private readonly IController<Equipment> _equipController;

        //public static ObservableCollection<oprema> Oprema
        //{
        //    get;
        //    set;
        //}
        public static ObservableCollection<Equipment> equipCollection
        {
            get;
            set;
        }

        public List<Equipment> equips;

        public magacin_oprema()
        {
            InitializeComponent();
            this.DataContext = this;
            //Oprema = new ObservableCollection<oprema>();
            //Oprema.Add(new oprema() { VrstaOpreme = "Sto",  Sifra="1", Kolicina = "10" });
            //Oprema.Add(new oprema() { VrstaOpreme = "Krevet", Sifra = "2", Kolicina = "20" });
           
            _equipController = EquipmentController.Instance;

            equips = _equipController.GetAll();
            equipCollection = new ObservableCollection<Equipment>(equips);
            dataGridMagacinOprema.Items.Refresh();

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

        private void Button_detaljno(object sender, RoutedEventArgs e)
        {
            /*var s = new odabrana_oprema();
            s.Show();*/
           
        }

        private void dataGridMagacinOprema_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void pretragaOprema_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var filter = equips.Where(Equipment => Equipment.Id.ToString().Contains(pretragaOprema.Text) || Equipment.Name.Contains(pretragaOprema.Text) || Equipment.Quantity.ToString().Contains(pretragaOprema.Text));
            dataGridMagacinOprema.ItemsSource = filter;
        }
    }
}
