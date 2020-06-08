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
    /// Interaction logic for Kalendar.xaml
    /// </summary>
    public partial class Kalendar : UserControl
    {
        private DateTime date;
        public Kalendar()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
        }

        private void Button_Izaberi(object sender, RoutedEventArgs e)
        {
            
            DetaljanPrikazRasporedaUser detaljan = new DetaljanPrikazRasporedaUser(date);
            (this.Parent as Panel).Children.Add(detaljan);
        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(2, thisCount);
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get reference.
            var calendar = sender as Calendar;

            // ... See if a date is selected.
            if (calendar.SelectedDate.HasValue)
            {
                // ... Display SelectedDate in Title.
                date = calendar.SelectedDate.Value;
                
            }
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
