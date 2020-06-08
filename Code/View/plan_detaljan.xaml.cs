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
    /// Interaction logic for plan_detaljan.xaml
    /// </summary>
    public partial class plan_detaljan : Window
    {
        public plan_detaljan()
        {
            InitializeComponent();
        }

        private void Button_izadji(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
