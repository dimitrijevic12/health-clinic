using System.Windows;
using System.Windows.Controls;

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
            (this.GridMain as Panel).Children.Add(new LoginUser());
        }

        
    }
}
