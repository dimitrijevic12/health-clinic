using Controller;
using health_clinicClassDiagram.Controller;
using Model.SystemUsers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for OdabirPrioritetaUser.xaml
    /// </summary>
    public partial class OdabirPrioritetaUser : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        } 
        public ObservableCollection<Doctor> doctorsCollection
        {
            get;
            set;
        }

        private readonly IController<Doctor> _doctorController;

        private List<Doctor> doctors;
        private DateTime _startDate;
        private DateTime _endDate;
        private Doctor _doctor;
        private String _priority;

        
        public OdabirPrioritetaUser()
        {
            InitializeComponent();
            this.DataContext = this;
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            _doctorController = DoctorController.Instance;

            doctors = _doctorController.GetAll();

            doctorsCollection = new ObservableCollection<Doctor>(doctors);

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

        private void Button_Potvrdi(object sender, RoutedEventArgs e)
        {
            if ((startDate.SelectedDate == null) || (endDate.SelectedDate == null))
            {
                string message = "Morate uneti datume";
                string title = "Greška";
                MessageBox.Show(message, title);
            }
            else if ((DateTime)startDate.SelectedDate > (DateTime)endDate.SelectedDate)
            {

                string message = "Neispravno uneseni datumi";
                string title = "Greška";
                MessageBox.Show(message, title);
            }
            else
            {
                _startDate = (DateTime)startDate.SelectedDate;
                _endDate = (DateTime)endDate.SelectedDate;
                PrioritetLista prioritet = new PrioritetLista(_priority, _doctor, _startDate, _endDate);
                (this.Parent as Panel).Children.Add(prioritet);
            }
        }

        private void DoktorCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            _doctor = (Doctor)cmb.SelectedItem;
        }

        private void prioritetCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            _priority = cmb.SelectedItem.ToString();
        }
    }
}
