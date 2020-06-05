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
    /// Interaction logic for IzvestajOPotrosnjiLekova.xaml
    /// </summary>
    public partial class IzvestajOPotrosnjiLekova : UserControl
    {
        public IzvestajOPotrosnjiLekova()
        {
            InitializeComponent();
        }

        private void buttonIstorijaBolesti_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ZdravstveniKartoniPacijent();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new PocetnaUser();
        }

    }
}
