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
    /// Interaction logic for HomeUser.xaml
    /// </summary>
    public partial class HomeUser : UserControl
    {
        public static RoutedCommand detaljanShorcut = new RoutedCommand();
        public static RoutedCommand smestanjeShorcut = new RoutedCommand();
        public static RoutedCommand kalendarShortcut = new RoutedCommand();
        public static RoutedCommand registrovaniShortcut = new RoutedCommand();
        public static RoutedCommand doktoriShorcut = new RoutedCommand();
        public static RoutedCommand helpShorcut = new RoutedCommand();
        public static RoutedCommand izvestajShorcut = new RoutedCommand();

        public static bool tooltipEnabled = true;
        public HomeUser()
        {
            InitializeComponent();
            labelDateTime.Content = DateTime.Now.ToShortDateString();

            detaljanShorcut.InputGestures.Add(new KeyGesture(Key.D, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(detaljanShorcut, Button_DanasnjiRaspored));

            smestanjeShorcut.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(smestanjeShorcut, Button_Smestaj));

            kalendarShortcut.InputGestures.Add(new KeyGesture(Key.K, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(kalendarShortcut, Button_Raspored));

            registrovaniShortcut.InputGestures.Add(new KeyGesture(Key.R, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(registrovaniShortcut, Button_Pacijenti));

            doktoriShorcut.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(doktoriShorcut, Button_Doktori));

            helpShorcut.InputGestures.Add(new KeyGesture(Key.H, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(helpShorcut, Button_Help));

            izvestajShorcut.InputGestures.Add(new KeyGesture(Key.I, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(izvestajShorcut, Button_Izvestaj));

            Style style = new Style(typeof(ToolTip));
            style.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));
            style.Seal();

            if ((bool)checkBox.IsChecked)
            {
                this.Resources.Remove(typeof(ToolTip)); //show

            }else
            {
                this.Resources.Add(typeof(ToolTip), style); //hide
            }


    }

        private void Button_DanasnjiRaspored(object sender, RoutedEventArgs e)
        {
            
            DateTime date = DateTime.Today;
            DetaljanPrikazRasporedaUser detaljan = new DetaljanPrikazRasporedaUser(date);
            (this.Parent as Panel).Children.Add(detaljan);
        }

        private void Button_Smestaj(object sender, RoutedEventArgs e)
        {
            
            SaleZaSmestanjePacijenataUser sale = new SaleZaSmestanjePacijenataUser();
            
            (this.Parent as Panel).Children.Add(sale);
        }

        private void Button_Raspored(object sender, RoutedEventArgs e)
        {
            
            Kalendar kalendar = new Kalendar();
            (this.Parent as Panel).Children.Add(kalendar);
        }

        private void Button_Pacijenti(object sender, RoutedEventArgs e)
        {
            
            RegistrovaniPacijentiUser pacijenti = new RegistrovaniPacijentiUser();
            (this.Parent as Panel).Children.Add(pacijenti);
        }

        private void Button_Doktori(object sender, RoutedEventArgs e)
        {
            
            Doktori doktori = new Doktori();
            (this.Parent as Panel).Children.Add(doktori);
        }

        private void Button_Help(object sender, RoutedEventArgs e)
        {
            HelpUser help = new HelpUser();
            (this.Parent as Panel).Children.Add(help);
        }

        private void Button_Odjava(object sender, RoutedEventArgs e)
        {
            LoginUser login = new LoginUser();
            (this.Parent as Panel).Children.Add(login);

        }

        private void Button_Izvestaj(object sender, RoutedEventArgs e)
        {
            
            GenerisiIzvestajUser generisi = new GenerisiIzvestajUser();
            (this.Parent as Panel).Children.Add(generisi);
        }

        private void Button_Prioritet(object sender, RoutedEventArgs e)
        {
            
            OdabirPrioritetaUser prioritet = new OdabirPrioritetaUser();
            (this.Parent as Panel).Children.Add(prioritet);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            tooltipEnabled = true;

            Style style = new Style(typeof(ToolTip));
            style.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));
            style.Seal();

            if ((bool)checkBox.IsChecked)
            {
                this.Resources.Remove(typeof(ToolTip)); //show

            }
            else
            {
                this.Resources.Add(typeof(ToolTip), style); //hide
            }
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            tooltipEnabled = false;

            Style style = new Style(typeof(ToolTip));
            style.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));
            style.Seal();

            if ((bool)checkBox.IsChecked)
            {
                this.Resources.Remove(typeof(ToolTip)); //show

            }
            else
            {
                this.Resources.Add(typeof(ToolTip), style); //hide
            }
        }
    }
}
