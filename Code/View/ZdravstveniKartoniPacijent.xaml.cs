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
    /// Interaction logic for ZdravstveniKartoniPacijent.xaml
    /// </summary>
    public partial class ZdravstveniKartoniPacijent : UserControl
    {
        public ZdravstveniKartoniPacijent()
        {
            InitializeComponent();
        }

        private void buttonOtvori_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new ZdravstveniKartonPregled();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }
    }
}
