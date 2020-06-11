﻿using Model.Appointment;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Model.SystemUsers;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for PregledTerminaUser.xaml
    /// </summary>
    public partial class PregledTerminaUser : UserControl
    {
        private Appointment appointment;
        public PregledTerminaUser(Appointment appointment)
        {
            InitializeComponent();
            DataContext = this;
            Appointment = appointment;
            Appointment.Doctor = new Doctor("Pera", "Peric");
            Appointment.Patient = new Patient("Marko", "Markovic", 1234);
        }

        public Appointment Appointment { get => appointment; set => appointment = value; }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new PocetnaUser();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}