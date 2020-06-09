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
    /// Interaction logic for NapisiUputZaOperaciju.xaml
    /// </summary>
    public partial class ZakazivanjeOperacije : UserControl
    {
        public ZakazivanjeOperacije()
        {
            InitializeComponent();
        }

        private void buttonOdaberiDatum_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new KalendarZaOperaciju();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }
    }
}