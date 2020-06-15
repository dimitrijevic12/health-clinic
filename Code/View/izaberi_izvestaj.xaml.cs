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

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for izaberi_izvestaj.xaml
    /// </summary>
    public partial class izaberi_izvestaj : Window
    {
        public izaberi_izvestaj()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
