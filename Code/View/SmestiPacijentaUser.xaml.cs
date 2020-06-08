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


            
            SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
            (this.Parent as Panel).Children.Add(sale);
        }

        private void Button_Odustanak(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(2, thisCount);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
