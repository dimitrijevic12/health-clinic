﻿using System;
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
    /// Interaction logic for HelpUser.xaml
    /// </summary>
    public partial class HelpUser : UserControl
    {
        public HelpUser()
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

        private bool _isToolTipVisible = true;

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            Style style = new Style(typeof(ToolTip));
            style.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));
            style.Seal();

           
                if (_isToolTipVisible)
                {
                    this.Resources.Add(typeof(ToolTip), style); //hide
                    _isToolTipVisible = false;
                }
                else
                {
                    this.Resources.Remove(typeof(ToolTip)); //show
                    _isToolTipVisible = true;
                }
            
        }
    }
}
