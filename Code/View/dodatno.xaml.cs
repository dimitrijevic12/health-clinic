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
    /// Interaction logic for dodatno.xaml
    /// </summary>
    public partial class dodatno : Window
    {
        public dodatno()
        {
            InitializeComponent();
            labelDate.Content = DateTime.Now.ToShortDateString();
            labelTime.Content = DateTime.Now.ToShortTimeString();

        }

        private void Button_pocetna(object sender, RoutedEventArgs e)
        {
            var s = new pocetna();
            s.Show();

            this.Close();

        }

       
        private void Button_jezik(object sender, RoutedEventArgs e)
        {
            
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        //    if(comboBox.SelectedIndex == 0)
        //    {
        //        Properties.Settings.Default.languageCode = "se-SE";
        //    }
        //    else
        //    {
        //        Properties.Settings.Default.languageCode = "en-US";
        //    }
        //    Properties.Settings.Default.Save();
        }

      
    }
}
