using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for SmestiPacijentaUser.xaml
    /// </summary>
    public partial class SmestiPacijentaUser : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private double _test1;
        //private SaleZaSmestanje sala = null;

        public double Test1
        {
            get
            {
                return _test1;
            }
            set
            {
                if (value != _test1)
                {
                    _test1 = value;
                    OnPropertyChanged("Test1");
                }
            }
        }
        //public SmestiPacijentaUser(SaleZaSmestanje sala)
        //{
        //    InitializeComponent();
        //    labelDateTime.Content = DateTime.Now.ToShortDateString();
        //    this.DataContext = this;
        //    ImeSale.Content = sala.Ime;
        //    this.sala = sala;
        //}

        private void Button_Potvrda(object sender, RoutedEventArgs e)
        {
        //    foreach (NalogPacijent nalog in RegistrovaniPacijentiUser.Nalozi)
        //    {
        //        if (nalog.JMBG.ToString().Equals(JMBGTekst.Text))
        //        {
        //            sala.ZauzetiKreveti++;
        //            sala.Nal.Add(nalog);
                    
        //        }
        //    }          


        //    GridSmestanje.Children.Clear();
        //    SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
        //    GridSmestanje.Children.Add(sale);
        }

        private void Button_Odustanak(object sender, RoutedEventArgs e)
        {
            GridSmestanje.Children.Clear();
            SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
            GridSmestanje.Children.Add(sale);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            GridSmestanje.Children.Clear();
            HomeUser home = new HomeUser();
            GridSmestanje.Children.Add(home);
        }
    }
}
