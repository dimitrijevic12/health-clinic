using Controller;
using Model.Rooms;
using System;
using System.Collections.Generic;
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
        public static ObservableCollection<Equipment> equipCollection
        {
            get;
            set;
        }

        public List<Equipment> equips;
        public naruci_opremu()
        {
            InitializeComponent();
            this.DataContext = this;
            
            _equipController = EquipmentController.Instance;
            //Oprema = new ObservableCollection<oprema>();
            //Oprema.Add(new oprema() { VrstaOpreme = "Sto", Sifra = "1", Kolicina = "10" });
            //Oprema.Add(new oprema() { VrstaOpreme = "Krevet", Sifra = "2", Kolicina = "20" });
            //Oprema.Add(new oprema() { VrstaOpreme = "Stolica", Sifra = "3", Kolicina = "14" });
            

            equips = _equipController.GetAll();
            equipCollection = new ObservableCollection<Equipment>(equips);
            dataGridNaruciOpremu.Items.Refresh();
            

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
            if ((quantity.Text == "") || (name.Text == ""))
            {
                string message = "Sva polja moraju biti popunjena!";
                string title = "Greška";

                MessageBox.Show(message, title);
            }
            else
            {
                string naz = name.Text;

                int quant = int.Parse(quantity.Text);

                _equipController.addEquipment(naz, quant);
               

                this.Close();
            }

        }
        private long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }

    }
}
