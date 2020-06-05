﻿using System;
using System.Collections.Generic;
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
    /// Interaction logic for NapisiUputZaSpecijalistu.xaml
    /// </summary>
    public partial class ZakazivanjeKodSpecijaliste : UserControl
    {
        public ZakazivanjeKodSpecijaliste()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new PocetnaUser();
        }

        private void buttonOdaberiDatum_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new KalendarZaOperaciju();
        }
    }
}
