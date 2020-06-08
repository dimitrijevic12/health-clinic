using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for IzmeniNalogUser.xaml
    /// </summary>
    public partial class IzmeniNalogUser : UserControl, INotifyPropertyChanged
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
        private double _test2;
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

        public double Test2
        {
            get
            {
                return _test2;
            }
            set
            {
                if (value != _test2)
                {
                    _test2 = value;
                    OnPropertyChanged("Test2");
                }
            }
        }

        public IzmeniNalogUser(/*NalogPacijent nalog*/)
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
            this.DataContext = this;
            //IDTekst.Text = nalog.IDnaloga.ToString();
            //ImeTekst.Text = nalog.Ime;
            //PrezimeTekst.Text = nalog.Prezime;
            //JMBGTekst.Text = nalog.JMBG.ToString();
            DoktorCombo.SelectedIndex = 1;
            

        }

        private void Button_Potvrdi(object sender, RoutedEventArgs e)
        {
            
            RegistrovaniPacijentiUser pacijenti = new RegistrovaniPacijentiUser();
            (this.Parent as Panel).Children.Add(pacijenti);


        }

        private void Button_Odustani(object sender, RoutedEventArgs e)
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
