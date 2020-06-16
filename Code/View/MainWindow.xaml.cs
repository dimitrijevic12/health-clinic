using health_clinicClassDiagram.view;
using System;
using System.Windows;

namespace health_clinicClassDiagram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            labelTime.Content = DateTime.Now.ToShortTimeString();
            labelDate.Content = DateTime.Now.ToShortDateString();
        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {
            if (username.Text.Equals("ana") && password.Password.Equals("ana"))
            {
                var s = new pocetna();
                s.Show();
                this.Close();
            }
            else
            {
                string message = "Neispravan username/password";
                string title = "Greška";
                username.Text = "";
                password.Password = "";
                MessageBox.Show(message, title);
            }
        }
    }
}
