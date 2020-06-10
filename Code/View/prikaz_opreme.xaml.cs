using Controller;
using Model.Rooms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for prikaz_opreme.xaml
    /// </summary>
    public partial class prikaz_opreme : Window
    {

        private int colNum = 0;
        private readonly IController<ExamOperationRoom> _examOperationRoomController;
        private ExamOperationRoom room;

        public static ObservableCollection<ExamOperationRoom> roomsCollection
        {
            get;
            set;
        }

        //public static ObservableCollection<SpisakSala> Spisak
        //{
        //    get;
        //    set;
        //}
        public List<ExamOperationRoom> rooms;
      
        public prikaz_opreme()
        {
            InitializeComponent();
            this.DataContext = this;

            var app = Application.Current as App;
            _examOperationRoomController = app.examOperationRoomController;

            rooms = _examOperationRoomController.GetAll();

            roomsCollection = new ObservableCollection<ExamOperationRoom>(rooms);

            dataGridSale.Items.Refresh();

            //if (Spisak == null)
            //{
            //    inicijalizuj();
            //}
            //else
            //{
            //    dataGridSale.Items.Refresh();
            //}


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

        private void Button_sala(object sender, RoutedEventArgs e)
        {
            var s = new odabrana_sala();
            s.Show();
        }

        private void dataGridSale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Detaljno(object sender, RoutedEventArgs e)
        {
            var s = new odabrana_sala();
            s.Show();
        }

        private void Button_Obrisi(object sender, RoutedEventArgs e)
        {
            var s = new odabrana_sala();
            s.Show();
        }
    }
}
