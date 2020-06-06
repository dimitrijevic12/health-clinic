﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for IzmenaPregledaUser.xaml
    /// </summary>
    public partial class IzmenaPregledaUser : UserControl, INotifyPropertyChanged
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
        private DateTime date;

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

        public IzmenaPregledaUser(DateTime date)
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
            this.DataContext = this;
            this.date = date;
        }

        private void Button_Pronadji(object sender, RoutedEventArgs e)
        {
            GridIzmeni.Children.Clear();
            IzaberiNalogUser izaberi = new IzaberiNalogUser();
            GridIzmeni.Children.Add(izaberi);
        }

        private void Button_Potvrda(object sender, RoutedEventArgs e)
        {
            GridIzmeni.Children.Clear();
            DetaljanPrikazRasporedaUser raspored = new DetaljanPrikazRasporedaUser(date);
            GridIzmeni.Children.Add(raspored);
        }

        private void Button_Odustanak(object sender, RoutedEventArgs e)
        {
            GridIzmeni.Children.Clear();
            DetaljanPrikazRasporedaUser raspored = new DetaljanPrikazRasporedaUser(date);
            GridIzmeni.Children.Add(raspored);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            GridIzmeni.Children.Clear();
            HomeUser home = new HomeUser();
            GridIzmeni.Children.Add(home);
        }
    }
}
