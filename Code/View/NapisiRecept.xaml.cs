using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;

namespace health_clinicClassDiagram.View
{
    /// <summary>
    /// Interaction logic for NapisiRecept.xaml
    /// </summary>
    public partial class NapisiRecept : UserControl
    {
//        private String _imePrezime = "";

        public NapisiRecept()
        {
            InitializeComponent();
            DataContext = this;
//            _imePrezime = imePrezime;
        }

/*        public String ImePrezime{
            get { return _imePrezime; }
            set
            {
                if( _imePrezime != value)
                {
                    _imePrezime = value;
                    OnPropertyChanged();
                }
            }
        }
*/
        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new PocetnaUser();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            //            this.Content = new Pregled(_imePrezime);
            this.Content = new Pregled();
        }

        /*        public event PropertyChangedEventHandler PropertyChanged;
                private void OnPropertyChanged([CallerMemberName] string propertyName = null)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                }
        */
        private void buttonPotvrdiRecept_Click(object sender, RoutedEventArgs e)
        {
            //           _imePrezime = "Mika Mikic";
            //           imePrezime.Text = _imePrezime;
            //            this.Content = new Pregled(_imePrezime);
            this.Content = new Pregled();
        }
    }
}
