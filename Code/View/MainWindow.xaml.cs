using System.Windows;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Clear();
            HomeUser home = new HomeUser();
            GridMain.Children.Add(home);
        }
    }
}
