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
    /// Interaction logic for GenerisiIzvestajUser.xaml
    /// </summary>
    public partial class GenerisiIzvestajUser : UserControl
    {
        private DateTime _startDate;
        private DateTime _endDate;

        public GenerisiIzvestajUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            if ((startDate.SelectedDate==null) || (endDate.SelectedDate == null))
            {
                string message = "Morate uneti datume";
                string title = "Greška";
                MessageBox.Show(message, title);
            } else if (_startDate >= _endDate)
            {
                _startDate = (DateTime)startDate.SelectedDate;
                _endDate = (DateTime)endDate.SelectedDate;
                _endDate = _endDate.AddHours(24);

                string message = "Neispravno uneseni datumi";
                string title = "Greška";
                MessageBox.Show(message, title);
            }
            else
            {

                ZauzetostProstorijaUser zauzetost = new ZauzetostProstorijaUser(_startDate, _endDate);
                (this.Parent as Panel).Children.Add(zauzetost);
            }
        }
    }
}
