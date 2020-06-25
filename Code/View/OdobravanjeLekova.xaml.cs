using Model.Rooms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for OdobravanjeLekova.xaml
    /// </summary>
    public partial class OdobravanjeLekova : UserControl
    {
        public ObservableCollection<Drug> AllDrugs
        {
            get;
            set;
        }
        public OdobravanjeLekova()
        {
            AllDrugs = new ObservableCollection<Drug>();
            AllDrugs.Add(new Drug(1, "Paracematol 100mg", 15));
           /* AllDrugs.Add(new Drug("Aerius 50mg", 2, 5));
            AllDrugs.Add(new Drug("Aspirin 100mg", 4, 15));
            AllDrugs.Add(new Drug("Strepsils pakovanje 10 tableta", 5, 30));
            AllDrugs.Add(new Drug("Xyzal 50mg", 6, 2));
            AllDrugs.Add(new Drug("Fervex pakovanje 5 komada", 7, 3));
            AllDrugs.Add(new Drug("Panklav 200mg", 2, 5));*/
            
            InitializeComponent();
            DataContext = this;
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void buttonOdobriLek_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void buttonOdobriLek_Click_1(object sender, RoutedEventArgs e)
        {
            IList rows = dataGridLekovi.SelectedItems;
            List<Drug> drugsToRemove = new List<Drug>();
            foreach (var row in rows)
            {
                drugsToRemove.Add((Drug)row);
            }
            foreach(Drug drug in drugsToRemove)
            {
                AllDrugs.Remove(drug);
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
            return;
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Klikom na dugme \"Odobri lek\", odobravate lek i on se briše iz liste lekova koji još nisu odobreni.";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
