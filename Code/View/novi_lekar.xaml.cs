﻿using Controller;
using health_clinicClassDiagram.Model.SystemUsers;
using Model.SystemUsers;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for novi_lekar.xaml
    /// </summary>
    public partial class novi_lekar : Window
    {
        private readonly IController<Doctor> _doctorController;

        private long _id;
        private string _ime;
        private string _prezime;
        private Gender _gender;
        private DateTime _datum;
        private Specialization _specijalnost;

        public novi_lekar()
        {
            InitializeComponent();
            this.DataContext = this;

            var app = Application.Current as App;
            _doctorController = app.doctorController;
        }

        private void Button_otkazi(object sender, RoutedEventArgs e)
        {
           
         
            var s = new lekar();
            s.Show();
            this.Close();
        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            String ID = IdLekara.Text;
            String IME = Ime.Text;
            String PREZIME = Prezime.Text;

            String JMBG = Jmbg.Text;
            String DATUMRODJ = DatumRodjenja.Text;
            String RADNOVREME = RadnoVreme.Text;
            String SPECIJALISTA = "DA";

            int combo1 = PolCombo.SelectedIndex;

            if (combo1 == 0)
            {
                _gender = Gender.MALE;
            } else
            {
                _gender = Gender.FEMALE;
            }

            int combo2 = SpecijalistaCombo.SelectedIndex;

            if (combo2 == 0)
            {
                _specijalnost = Specialization.CARDIOLOGY;
            }
            else if (combo2 == 1)
            {
                _specijalnost = Specialization.ENDOCRINOLOGY;
            }
            else if (combo2 == 2)
            {
                _specijalnost = Specialization.NEPHROLOGY;
            }
            else
            {
                _specijalnost = Specialization.PULMOLOGY;
            }


            _id = long.Parse(ID);
            _ime = IME;
            _prezime = PREZIME;
            
            
            _datum = DateTime.Now;

            Doctor doctor = CreateDoctor();


            //lekari L = new lekari { IdLekara = ID, Ime = IME, Prezime = PREZIME, Pol = POL, Jmbg = JMBG, DatumRodjenja = DATUMRODJ, RadnoVreme = RADNOVREM, Specijalista = SPECIJALISTA};
            //Console.WriteLine(L);

            //lekar.Lekari.Add(new lekari() { IdLekara = ID, Ime = IME, Prezime = PREZIME, Pol = POL, Jmbg = JMBG, DatumRodjenja = DATUMRODJ, RadnoVreme = RADNOVREM, Specijalista = SPECIJALISTA } );

           
           
            var s = new lekar();
            s.Show();
            this.Close();

        }

        private Doctor CreateDoctor()
        {
            Doctor doctor = new Doctor(_id, _ime, _prezime, _gender, _datum, _specijalnost);

            return _doctorController.Create(doctor);
        }

        private void IdLekara_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Jmbg_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
