using Controller;
using health_clinicClassDiagram.Controller;
using Model.SystemUsers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for Doktori.xaml
    /// </summary> 
    
    public partial class Doktori : UserControl
    {
        private int colNum = 0;
        private readonly IController<Doctor> _doctorController;
        public static ObservableCollection<Doctor> doctorsCollection
        {
            get;
            set;
        }

        private List<Doctor> doctors;

        public Doktori()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            this.DataContext = this;

            /*var app = Application.Current as App;
            _doctorController = app.DoctorController;*/

            _doctorController = DoctorController.Instance;

            doctors = _doctorController.GetAll();

            doctorsCollection = new ObservableCollection<Doctor>(doctors);

            dataGridDoktori.Items.Refresh();
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
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void textSearch_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            
            var filter = doctors.Where(Doctor => Doctor.NameDoctor.Contains(textSearch.Text));
            dataGridDoktori.ItemsSource = filter;
            
        }
    }
}
