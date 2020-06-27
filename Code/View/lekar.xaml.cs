
using System;
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
using System.Windows.Shapes;
using System.Collections.ObjectModel;

using System.Collections;
using Controller;
using Model.SystemUsers;
using health_clinicClassDiagram.View;
using health_clinicClassDiagram.Model.SystemUsers;
using health_clinicClassDiagram.Controller;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for lekar.xaml
    /// </summary>

    public partial class lekar : Window
    {
        public static RoutedCommand Pocetnashortcut = new RoutedCommand();
        private int colNum = 0;
        private readonly IController<Doctor> _doctorController;
        private Doctor doctor;
        private int c1 = 0;
        private int c2 = 0;
        private int c3 = 0;
        private int c4 = 0;
        private Doctor doc;
        public static ObservableCollection<Doctor> doctorsCollection
        {
            get;
            set;
        }

        public List<Doctor> doctors;

        public lekar()
        {

            InitializeComponent();
            this.DataContext = this;
            Pocetnashortcut.InputGestures.Add(new KeyGesture(Key.P, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Pocetnashortcut, Button_pocetna));

            
            _doctorController = DoctorController.Instance;

            doctors = _doctorController.GetAll();

            doctorsCollection = new ObservableCollection<Doctor>(doctors);

            dataGridLekari.Items.Refresh();          

        }
        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_pocetna(object sender, RoutedEventArgs e)
        {

            var s = new pocetna();
            s.Show();
            this.Close();

        }

        private void Button_novi(object sender, RoutedEventArgs e)
        {
            var s = new novi_lekar();
            s.Show();
            this.Close();
            /* var s = new uredi_lekara(doctor);
             s.Show();
             this.Close();*/


        }

      

        

        public IEnumerable<DataGridRow> GetDataGridRows(DataGrid grid)
        {
            var itemsSource = grid.ItemsSource as IEnumerable;
            if (null == itemsSource) yield return null;
            foreach (var item in itemsSource)
            {
                var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (null != row) yield return row;
            }
        }

        private void dataGridLekari_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var row_list = GetDataGridRows(dataGridLekari);
                foreach (DataGridRow single_row in row_list)
                {
                    if (single_row.IsSelected == true)
                    {
                        doctor = doctors.ElementAt(single_row.GetIndex());
                        
                    }
                }

            }
            catch { }
        }

        private void Button_edit(object sender, RoutedEventArgs e)
        {
            //var s = new projekatUpravnikRA137_2017.view.uredi_lekara(JedanLekar);
            //s.Show();
            //pol
            if(doctor.Gender == Gender.MALE)
            {
                c1 = 0;
            }
            else
            {
                c1 = 1;
            }
            //smena
            if (doctor.Smena == TypeOfWorkingSchedule.PRVA)
            {
                c2 = 0;
            }
            else if (doctor.Smena == TypeOfWorkingSchedule.DRUGA)
            {
                c2 = 1;
            }
            else
            {
                c2 = 2;
            }
            //spec
            if (doctor.Spec == Specialization.CARDIOLOGY)
            {
                c3 = 0;
            }
            else if (doctor.Spec == Specialization.PULMOLOGY)
            {
                c3 = 1;
            }
            else if(doctor.Spec == Specialization.NEPHROLOGY)
            {
                c3 = 2;
            }
            else if (doctor.Spec == Specialization.ENDOCRINOLOGY)
            {
                c3 = 3;
            }
            else
            {
                c3 = 4;
            }
            //hirurg

            if (doctor.Sur == SurgicalSpecialty.CARDIOTHORACIC)
            {
                c4 = 0;
            }
            else if (doctor.Sur == SurgicalSpecialty.NEUROSURGERY)
            {
                c4 = 1;
            }
            else if (doctor.Sur == SurgicalSpecialty.PLASTICAL)
            {
                c4 = 2;
            }
            else if (doctor.Sur == SurgicalSpecialty.GENERAL)
            {
                c4 = 3;
            }
            else
            {
                c4 = 4;
            }


            var s = new uredi_lekara(doctor,c1,c2,c3,c4);
            s.Show();
            this.Close();
        }

        private void Button_delete(object sender, RoutedEventArgs e)
        {
            //Lekari.Remove(JedanLekar);
            _doctorController.Delete(doctor);
            var s = new lekar();
            s.Show();
            this.Close();


        }
        private void MenuItem_lekar(object sender, RoutedEventArgs e)
        {
            var s = new lekar();
            s.Show();
            this.Close();
        }



        private void MenuItem_izvestaj(object sender, RoutedEventArgs e)
        {
            var s = new izvestaj();
            s.Show();
            this.Close();
        }


        private void MenuItem_pocetna(object sender, RoutedEventArgs e)
        {
            var s = new pocetna();
            s.Show();
            this.Close();
        }

        private void MenuItem_magacin(object sender, RoutedEventArgs e)
        {
            var s = new magacin();
            s.Show();
            this.Close();
        }

        private void MenuItem_pomoc(object sender, RoutedEventArgs e)
        {

        }

        private void pretragaLekari_KeyUp(object sender, KeyEventArgs e)
        {
            var filter = doctors.Where(Doctor => Doctor.Name.Contains(pretragaLekari.Text) || Doctor.Surname.Contains(pretragaLekari.Text) || Doctor.IdDoctor.ToString().Contains(pretragaLekari.Text) || Doctor.Smena.ToString().Contains(pretragaLekari.Text) || Doctor.Gender.ToString().Contains(pretragaLekari.Text) || Doctor.Spec.ToString().Contains(pretragaLekari.Text) || Doctor.Sur.ToString().Contains(pretragaLekari.Text));
            dataGridLekari.ItemsSource = filter;
        }
    }
}
