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
    /// Interaction logic for Wizard.xaml
    /// </summary>
    public partial class Wizard : UserControl
    {
        public Wizard()
        {
            InitializeComponent();
        }

        private void changeTabItem(int i)
        {
            int newIndex = tabControl.SelectedIndex + i;
            if(newIndex >= tabControl.Items.Count)
            {
                newIndex = 0;
            }else if (newIndex < 0)
            {
                newIndex = tabControl.Items.Count - 1;
            }
            tabControl.SelectedIndex = newIndex;

            if (tabControl.SelectedIndex == tabControl.Items.Count-1)
            {
                LoginUser login = new LoginUser();
                (this.Parent as Panel).Children.Add(login);
            }
        }

        private void previousButton_Click(object sender, RoutedEventArgs e)
        {
            changeTabItem(-1);
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            changeTabItem(1);
        }

        private void finishButton_Click(object sender, RoutedEventArgs e)
        {
            changeTabItem(-tabControl.Items.Count);
        }
    }
}
