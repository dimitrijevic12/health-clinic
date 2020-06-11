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
    /// Interaction logic for NapisiClanak.xaml
    /// </summary>
    public partial class NapisiClanak : UserControl
    {
        public NapisiClanak()
        {
            InitializeComponent();
        }

        private void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result  = MessageBox.Show("Da li ste sigurni da zelite da potvrdite clanak", "Potvrdjivanje clanka", button, MessageBoxImage.Question);

            switch (result)
            {
                case MessageBoxResult.Cancel:
                    {
                        return;
                    }
                case MessageBoxResult.No:
                    {
                       int thisCount = (this.Parent as Panel).Children.IndexOf(this);
                       (this.Parent as Panel).Children.RemoveRange(3, thisCount);
                        return;
                    }
                case MessageBoxResult.Yes:
                    {
                       int thisCount = (this.Parent as Panel).Children.IndexOf(this);
                       (this.Parent as Panel).Children.RemoveRange(3, thisCount);
                        return;
                    }
            }

//            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
//            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }
    }
}
