using Controller;
using health_clinicClassDiagram.Controller;
using Model.Appointment;
using Model.SystemUsers;
using Model.SystemUsers.health_clinicClassDiagram.Model.SystemUsers;
using Model.Treatment;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms.VisualStyles;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for KreirajNalogUser.xaml
    /// </summary>
    public partial class KreirajNalogUser : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        private readonly IMedicalRecordController _recordController;
        private readonly IController<Patient> _patientController;
        private readonly IController<Doctor> _doctorController;

        public ObservableCollection<Doctor> doctorsCollection
        {
            get;
            set;
        }

        private List<Doctor> doctors;

        private long _idNaloga;
        private string _imePacijenta;
        private string _prezimePacijenta;
        private int _jmbgPacijenta;
        private Gender _gender;
        private DateTime _dateOfBirth;
        private Doctor choosenDoctor;

        public KreirajNalogUser()
        {
            InitializeComponent();
            this.DataContext = this;
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            _recordController = MedicalRecordController.Instance;
            _doctorController = DoctorController.Instance;

            doctors = _doctorController.GetAll();

            doctorsCollection = new ObservableCollection<Doctor>(doctors);


        }

        private void Button_Potvrdi(object sender, RoutedEventArgs e)
        {
            if ((IDTekst.Text == "") || (ImeTekst.Text == "") || (PrezimeTekst.Text == "") || (JMBGTekst.Text == "") || (DoktorCombo.SelectedIndex == -1) || (DatumPicker.SelectedDate == null))
            {
                string message = "Sva polja moraju biti popunjena";
                string title = "Greška";
                MessageBox.Show(message, title);
            }
            else
            {
                String idNalogaString = IDTekst.Text;
                String ime = ImeTekst.Text;
                String prezime = PrezimeTekst.Text;
                String jmbgString = JMBGTekst.Text;

                _dateOfBirth = (DateTime)DatumPicker.SelectedDate;

                _idNaloga = long.Parse(idNalogaString);
                _imePacijenta = ime;
                _prezimePacijenta = prezime;
                _jmbgPacijenta = int.Parse(jmbgString);

                String genderString = null;

                if (muski.IsChecked == true)
                {
                    genderString = "MALE";
                }
                else if (zenski.IsChecked == true)
                {
                    genderString = "FEMALE";
                }
                else
                {
                    Console.WriteLine("Niste uneli pol");
                }

                _gender = (Gender)Enum.Parse(typeof(Gender), genderString, true);

                int flag = 0;
                foreach (MedicalRecord mr in _recordController.GetAll())
                {
                    if ((mr.Id.Equals(_idNaloga)) || (mr.IDPatient.Equals(_jmbgPacijenta)))
                    {
                        string message = "Id naloga i jmbg moraju biti jedinstveni";
                        string title = "Greška";
                        MessageBox.Show(message, title);
                        flag = 1;
                    }
                }

                if (flag == 0)
                {
                    MedicalRecord record = CreateMedicalRecord();


                    RegistrovaniPacijentiUser pacijenti = new RegistrovaniPacijentiUser();
                    (this.Parent as Panel).Children.Add(pacijenti);
                }
            }


        }

       

        private MedicalRecord CreateMedicalRecord()
        {
                        
            Patient pacijent = new Patient(_imePacijenta, _prezimePacijenta, _jmbgPacijenta, _dateOfBirth, _gender);
            var record = new MedicalRecord(_idNaloga, pacijent, choosenDoctor, new List<Treatment>());

            return _recordController.Create(record);
            
        }

        private void Button_Odustani(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
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

        private void DoktorCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            
            choosenDoctor = (Doctor)cmb.SelectedItem;            
        }
    }
}
