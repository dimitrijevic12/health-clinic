using health_clinicClassDiagram.Controller;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for SmestiPacijentaUser.xaml
    /// </summary>
    public partial class SmestiPacijentaUser : UserControl, INotifyPropertyChanged
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

        private readonly IRehabilitationRoomController _rehabilitationRoomController;


        private long _idNaloga;
        private string _imePacijenta;
        private string _prezimePacijenta;
        private int _jmbgPacijenta;
        private RehabilitationRoom _rehabilitationRoom;

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
        public SmestiPacijentaUser(RehabilitationRoom rehabilitationRoom)
        {
            InitializeComponent();
            this.DataContext = this;
            labelSala.Content = rehabilitationRoom.IdRoom.ToString();
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            _rehabilitationRoom = rehabilitationRoom;

            var app = Application.Current as App;
            _rehabilitationRoomController = app.RehabilitationRoomController;


        }

        private void Button_Potvrda(object sender, RoutedEventArgs e)
        {
            _idNaloga = 1;
            _imePacijenta = textIme.Text;
            _prezimePacijenta = textPrezime.Text;
            _jmbgPacijenta = int.Parse(textJMBG.Text);

            Patient patient = new Patient(_imePacijenta, _prezimePacijenta, _jmbgPacijenta);
            MedicalRecord record = new MedicalRecord(_idNaloga, patient, new Doctor());

            var result = _rehabilitationRoomController.AddPatient(record, _rehabilitationRoom);


            
            SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
            (this.Parent as Panel).Children.Add(sale);
        }

        private void Button_Odustanak(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
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
