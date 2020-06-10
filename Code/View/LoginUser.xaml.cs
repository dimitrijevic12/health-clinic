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
    /// Interaction logic for LoginUser.xaml
    /// </summary>
    public partial class LoginUser : UserControl
    {
        public LoginUser()
        {
            InitializeComponent();
            DatumText.Text = DateTime.Now.ToShortDateString() + "       ";
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            
            HomeUser home = new HomeUser();
            (this.Parent as Panel).Children.Add(home);
        }
    }
}