using Controller;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for plan_detaljan.xaml
    /// </summary>
    public partial class plan_detaljan : Window
    {
        private int colNum = 0;

        private readonly IAppointmentController _appController;
        public static ObservableCollection<Appointment> appCollection
        {
            get;
            set;
        }
        public List<Appointment> apps;
        public List<Appointment> appsPrikaz = new List<Appointment>();
        public plan_detaljan(Doctor doctor, DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.DataContext = this;

            var app = Application.Current as App;
            _appController = app.appController;

            apps = _appController.GetAll();

            foreach(Appointment a in apps)
            {
                if((a.Doctor.Id == doctor.Id) && (a.StartDate >= date1) && (a.StartDate <= date2.AddHours(24)))
                {
                    appsPrikaz.Add(a);
                }
            }

            appCollection = new ObservableCollection<Appointment>(appsPrikaz);
        }
        

        private void Button_izadji(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
