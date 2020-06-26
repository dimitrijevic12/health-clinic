using Controller;
using Model.Surveys;
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
            if(textBoxNaslov.Text.Equals(""))
            {
                MessageBox.Show("Niste uneli naslov teksta", "Potvrdjivanje clanka", MessageBoxButton.OK, MessageBoxImage.Question);
                return;
            }

            if (textBoxTekst.Text.Equals(""))
            {
                MessageBox.Show("Niste uneli tekst", "Potvrdjivanje clanka", MessageBoxButton.OK, MessageBoxImage.Question);
                return;
            }

            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result  = MessageBox.Show("Da li ste sigurni da želite da potvrdite članak", "Potvrdjivanje clanka", button, MessageBoxImage.Question);

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
                        Blog blog = new Blog(textBoxNaslov.Text, textBoxTekst.Text, DateTime.Now);
                        BlogController.Instance.Create(blog);
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

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
            return;
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Kada unesete naslov i tekst i kliknete na dugme \"Potvrdi\" članak će se sačuvati.";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
