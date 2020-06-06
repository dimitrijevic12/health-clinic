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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for PrikazSaleZaSmestanjePacijenataUser.xaml
    /// </summary>
    public partial class PrikazSaleZaSmestanjePacijenataUser : UserControl
    {
        public PrikazSaleZaSmestanjePacijenataUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            GridPrikaz.Children.Clear();
            HomeUser home = new HomeUser();
            GridPrikaz.Children.Add(home);
        }
    }
}
