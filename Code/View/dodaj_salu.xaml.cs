using System;
using System.Windows;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for dodaj_salu.xaml
    /// </summary>
    public partial class dodaj_salu : Window
    {
        public dodaj_salu()
        {
            InitializeComponent();
        }

       

        private void Button_otkazi(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            String ID = Id_sale.Text;
            String IME = "Operaciona";


            //prikaz_opreme.Spisak.Add(new SpisakSala() {Sala = ID, TipSale = IME});

            this.Close();

        }
    }
}
