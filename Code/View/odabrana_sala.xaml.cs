using Controller;
using health_clinicClassDiagram.Controller;
using health_clinicClassDiagram.Repository;
using Model.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for odabrana_sala.xaml
    /// </summary>
    public partial class odabrana_sala : Window

        
    {
        private Equipment equip;
        private readonly IController<Equipment> _equipController;
     
        private int colNum = 0;
        private Room roomSalji;
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
        public List<ExamOperationRoom> rooms;
        public List<RehabilitationRoom> rooms2;
        public List<Equipment> equips;
        public odabrana_sala(Room room)
        {
            InitializeComponent();
            this.DataContext = this;
            roomSalji = room;
            //Oprema = new ObservableCollection<oprema>();
            //Oprema.Add(new oprema() { VrstaOpreme = "Sto", Sifra = "1", Kolicina = "2" });
            //Oprema.Add(new oprema() { VrstaOpreme = "Krevet", Sifra = "2", Kolicina = "3" });
            //Oprema.Add(new oprema() { VrstaOpreme = "Stolica", Sifra = "3", Kolicina = "5" });
            var app = Application.Current as App;
          
            _equipController = app.equipController;
            equips = room.Equipments;
            equipCollection = new ObservableCollection<Equipment>(equips);
            dataGridOdabranaSala.ItemsSource = equipCollection;
            dataGridOdabranaSala.Items.Refresh();
            //Console.WriteLine(room.Equipments.Count());

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
            var s = new premestanje_iz_ove(roomSalji);
            s.Show();
            this.Close();
        }

      
        private void Button_uOvu(object sender, RoutedEventArgs e)
        {
            var s = new premestanje_u_ovu(roomSalji);
            s.Show();
            this.Close();
        }
    }
}
