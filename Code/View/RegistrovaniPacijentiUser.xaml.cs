using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Collections;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for RegistrovaniPacijentiUser.xaml
    /// </summary>
    public partial class RegistrovaniPacijentiUser : UserControl
    {
        private int colNum = 0;
        //private NalogPacijent nalog = null;
        //public static ObservableCollection<NalogPacijent> Nalozi
        //{
        //    get;
        //    set;
        //}

        //private void naloziInicijalizacija()
        //{
        //    Nalozi = new ObservableCollection<NalogPacijent>();
        //    Nalozi.Add(new NalogPacijent() { IDnaloga = 1, Ime = "Petar", Prezime = "Peric", JMBG = 111111, Pol = EnumPol.M, OdabraniDoktor = "Doktor Savo", DatumRodjenja = "13/13/13", IstorijaLecenja = "Neki tekst" });
        //    Nalozi.Add(new NalogPacijent() { IDnaloga = 2, Ime = "Marko", Prezime = "Markovic", JMBG = 222222, Pol = EnumPol.M, OdabraniDoktor = "Doktor Savo", DatumRodjenja = "13/13/13", IstorijaLecenja = "Neki tekst" });
        //    Nalozi.Add(new NalogPacijent() { IDnaloga = 3, Ime = "Nikola", Prezime = "Nikolic", JMBG = 333333, Pol = EnumPol.M, OdabraniDoktor = "Doktor Savo", DatumRodjenja = "13/13/13", IstorijaLecenja = "Neki tekst" });

        //}
        public RegistrovaniPacijentiUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            this.DataContext = this;

            //if (Nalozi == null)
            //{
            //    naloziInicijalizacija();
            //}
            dataGridNalozi.Items.Refresh();
        }

        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Kreiraj(object sender, RoutedEventArgs e)
        {
            
            KreirajNalogUser kreiraj = new KreirajNalogUser();
            (this.Parent as Panel).Children.Add(kreiraj);
        }

        private void Button_Obrisi(object sender, RoutedEventArgs e)
        {
            //Nalozi.Remove(nalog);
            
            RegistrovaniPacijentiUser reg = new RegistrovaniPacijentiUser();
            (this.Parent as Panel).Children.Add(reg);
        }

        private void Button_Izmeni(object sender, RoutedEventArgs e)
        {
            IzmeniNalogUser izmeni = new IzmeniNalogUser();
            (this.Parent as Panel).Children.Add(izmeni);

            //IzmeniNalogUser izmeni = new IzmeniNalogUser(nalog);
            //GridPacijenti.Children.Add(izmeni);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(2, thisCount);
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

        private void dataGridNalozi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var row_list = GetDataGridRows(dataGridNalozi);
                foreach (DataGridRow single_row in row_list)
                {
                    if (single_row != null)
                    {
                        if (single_row.IsSelected == true)
                        {
                           
                            //nalog = Nalozi[single_row.GetIndex()];
                        }
                    }
                }

            }
            catch { }
        }

        private void btnPrikazi_Click(object sender, RoutedEventArgs e)
        {
            GridPacijenti.Children.Clear();

            PregledNalogaUser pregled = new PregledNalogaUser();
            GridPacijenti.Children.Add(pregled);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
