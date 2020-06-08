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
    /// Interaction logic for IzvestajPacijentaUser.xaml
    /// </summary>
    public partial class IzvestajPacijentaUser : UserControl
    {
        public IzvestajPacijentaUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
        }

        private void Button_Kontrola(object sender, RoutedEventArgs e)
        {
            
            PregledKontroleUser pregled = new PregledKontroleUser();
            (this.Parent as Panel).Children.Add(pregled);
        }

        private void Button_Lekovi(object sender, RoutedEventArgs e)
        {
            IzvestajLekoviUser izvestaj = new IzvestajLekoviUser();
            (this.Parent as Panel).Children.Add(izvestaj);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(2, thisCount);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
