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

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for izvestaj.xaml
    /// </summary>
    public partial class izvestaj : Window
    {
        public izvestaj()
        {
            InitializeComponent();
        }

        private void Button_pocetna(object sender, RoutedEventArgs e)
        {
            var s = new pocetna();
            s.Show();
            this.Close();

        }

        private void Button_plan(object sender, RoutedEventArgs e)
        {
            var s = new plan_lekar();
            s.Show();
            
        }
    }
}
