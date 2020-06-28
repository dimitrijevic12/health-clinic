﻿using Controller;
using Model.Rooms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for naruci_lek.xaml
    /// </summary>
    public partial class naruci_lek : Window
    {
        private int colNum = 0;
        private readonly IDrugController _drugController;
        //public static ObservableCollection<lekovi> Lekovi
        //{
        //    get;
        //    set;
        //}
        public static ObservableCollection<Drug> drugCollection
        {
            get;
            set;
        }

        public List<Drug> drugs;
        public naruci_lek()
        {
            InitializeComponent();
            this.DataContext = this;

            // _drugController = DrugController.Instance;
            //Lekovi = new ObservableCollection<lekovi>();
            //Lekovi.Add(new lekovi() { Lek = "Brufen", SifraLeka = "213", Kolicina = "10" });
            //Lekovi.Add(new lekovi() { Lek = "Paracetamol", SifraLeka = "442", Kolicina = "20" });
            DrugController drugController = new DrugController();
            drugs = drugController.GetAllDrugs();
            drugCollection = new ObservableCollection<Drug>(drugs);
            dataGridNaruciLek.Items.Refresh();
        }

        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_otkazi(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            if ((quant.Text == "") || (name.Text == ""))
            {
                string message = "Sva polja moraju biti popunjena!";
                string title = "Greška";

                MessageBox.Show(message, title);
            }
            else
            {
                string naziv = name.Text;
                int qu = int.Parse(quant.Text);
                ManagerDrugController managerDrugController = new ManagerDrugController(new DrugController());
                managerDrugController.AddDrug(naziv, qu);

                this.Close();
            }
        }
    }
}
