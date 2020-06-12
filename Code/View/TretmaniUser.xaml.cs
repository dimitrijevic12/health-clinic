﻿using Controller;
using Model.Appointment;
using Model.Treatment;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Panel = System.Windows.Controls.Panel;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for TretmaniUser.xaml
    /// </summary>
    public partial class TretmaniUser : UserControl
    {
        private int colNum = 0;
        private MedicalRecord _record;
        private readonly ITreatmentController _treatmentController;

        public  static ObservableCollection<Treatment> treatmentsCollection
        {
            get;
            set;
        }

        private List<Treatment> treatments;

        public TretmaniUser(MedicalRecord record)
        {
            InitializeComponent();
            
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            this.DataContext = this;
          

            treatmentsCollection = new ObservableCollection<Treatment>(record.Treatments);

            

            dataGridTretmani.Items.Refresh();

        }

        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
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