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

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for IzmeniNalogUser.xaml
    /// </summary>
    public partial class IzmeniNalogUser : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly IMedicalRecordController _recordController;
        private long _idNaloga;
        private string _imePacijenta;
        private string _prezimePacijenta;
        private int _jmbgPacijenta;
        private Gender _gender;
        private Doctor _choosenDoctor;
        private DateTime _dateOfBirth;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private readonly IController<Doctor> _doctorController;

        public ObservableCollection<Doctor> doctorsCollection
        {
            get;
            set;
        }

        private MedicalRecord _stariRecord;

        private List<Doctor> doctors;

        public IzmeniNalogUser(MedicalRecord record)
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
            this.DataContext = this;

            /*var app = Application.Current as App;
            _recordController = app.MedicalRecordController;
            _doctorController = app.DoctorController;*/

            _recordController = MedicalRecordController.Instance;
            _doctorController = DoctorController.Instance;

            doctors = _doctorController.GetAll();

            _stariRecord = record;

            doctorsCollection = new ObservableCollection<Doctor>(doctors);

            IDTekst.Text = record.id.ToString();
            ImeTekst.Text = record.Patient.Name;
            PrezimeTekst.Text = record.Patient.Surname;
            JMBGTekst.Text = record.Patient.Id.ToString();
            DoktorCombo.SelectedIndex = 1;
            DatumPicker.SelectedDate = record.DateOfBirth;
            

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

                MedicalRecord newRecord = EditMedicalRecord();


                RegistrovaniPacijentiUser pacijenti = new RegistrovaniPacijentiUser();
                (this.Parent as Panel).Children.Add(pacijenti);
            }


        }

        private MedicalRecord EditMedicalRecord()
        {
            Patient pacijent = new Patient(_imePacijenta, _prezimePacijenta, _jmbgPacijenta, _dateOfBirth, _gender);
            var record = new MedicalRecord(_idNaloga, pacijent, _choosenDoctor, _stariRecord.Treatments);

            return _recordController.Edit(record);
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

            _choosenDoctor = (Doctor)cmb.SelectedItem;
        }
    }
}
