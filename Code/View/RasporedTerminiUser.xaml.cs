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
    /// Interaction logic for RasporedTerminiUser.xaml
    /// </summary>
    public partial class RasporedTerminiUser : UserControl
    {
        public RasporedTerminiUser()
        {
            InitializeComponent();
        }

        private void buttonPregledTermina_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new PregledTerminaUser();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new PocetnaUser();
        }
    }
}
