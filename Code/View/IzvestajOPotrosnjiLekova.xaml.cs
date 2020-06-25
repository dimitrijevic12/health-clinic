using Model.Rooms;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    /// Interaction logic for IzvestajOPotrosnjiLekova.xaml
    /// </summary>
    public partial class IzvestajOPotrosnjiLekova : UserControl
    {
        //        private List<Drug> drugsToShow;

        //        public List<Drug> DrugsToShow { get => drugsToShow; set => drugsToShow = value; }
       // private Dictionary<long, Drug> drugsToShowMap = TreatmentRepository.Instance.FindDrugsByDate(DateTime.Today, DateTime.Today);
//        public Dictionary<long, Drug> DrugsToShowMap { get => drugsToShowMap; set => drugsToShowMap = value; }
        public ObservableCollection<Drug> DrugsToShow { get; private set; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }

        private DateTime startDate;
        private DateTime endDate;

        public IzvestajOPotrosnjiLekova()
        {
            DrugsToShow = new ObservableCollection<Drug>();
/*            foreach (var drug in DrugsToShowMap)
            {
                Drug drugToAdd = new Drug(drug.Key.Name, drug.Value);
                DrugsToShow.Add(drugToAdd);
            }
*/            
/*            Drug d1 = new Drug("Ime leka 1", 3);
            Drug d2 = new Drug("Ime leka 2", 6);
            DrugsToShow.Add(d1);
            DrugsToShow.Add(d2);
            DrugsToShowMap.Add(d1.Name, d1.Quantity);
            DrugsToShowMap.Add(d2.Name, d2.Quantity);*/
//            grafikon.DataContext = DrugsToShow;
            InitializeComponent();
            DataContext = this;      
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            int thisCount = (this.Parent as Panel).Children.IndexOf(this);
            (this.Parent as Panel).Children.RemoveRange(3, thisCount);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void DatePickerOd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            StartDate = (DateTime)DatePickerOd.SelectedDate;
            if(DatePickerDo == null){
                EndDate = DateTime.Today;
            }
            else
            {
                EndDate = (DateTime)DatePickerDo.SelectedDate;
            }

         //   DrugsToShowMap = TreatmentRepository.Instance.FindDrugsByDate(StartDate, EndDate);
            DrugsToShow = new ObservableCollection<Drug>();
//            foreach (var drug in DrugsToShowMap)
            foreach (var drug in new List<Drug>())
            {
 //               Drug drugToAdd = new Drug(drug.Value.Quantity, drug.Value.Name);
//                DrugsToShow.Add(drugToAdd);
            }
//            if(!(dataGrid == null)) dataGrid.ItemsSource = DrugsToShow;
            if (!(graph == null)) graph.ItemsSource = DrugsToShow;

        }

        private void DatePickerDo_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DatePickerOd.SelectedDate == null)
            {
                StartDate = DateTime.Today;
            }
            else
            {
                StartDate = (DateTime)DatePickerOd.SelectedDate;
            }
            EndDate = (DateTime)DatePickerDo.SelectedDate;

           // DrugsToShowMap = TreatmentRepository.Instance.FindDrugsByDate(StartDate, EndDate);
            DrugsToShow = new ObservableCollection<Drug>();
 /*           foreach (var drug in DrugsToShowMap)
            {
                Drug drugToAdd = new Drug(drug.Value.Quantity, drug.Value.Name);
                DrugsToShow.Add(drugToAdd);
            }*/
//            if (!(dataGrid == null)) dataGrid.ItemsSource = DrugsToShow;
            if (!(graph == null)) graph.ItemsSource = DrugsToShow;
        }

        private void buttonGenerisiIzvestaj_Click(object sender, RoutedEventArgs e)
        {
            String pdfName = "Izvestaj.pdf";
            PdfDocument pdfIzvestaj = new PdfDocument(pdfName);
            PdfPage pdfPage = pdfIzvestaj.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(pdfPage);
            XFont fontTitle = new XFont("Helvetica", 32, XFontStyle.Bold);
            XFont fontText = new XFont("Helvetica", 20, XFontStyle.Regular);
            XTextFormatter tf = new XTextFormatter(gfx);
//            gfx.DrawString("Hello World!", fontTitle, XBrushes.Black, new XRect(0, 0, pdfPage.Width, pdfPage.Height), XStringFormats.TopCenter);
            String text = "Ime leka | Količina\n\n";
            foreach(Drug drug in DrugsToShow)
            {
 //               gfx.DrawString(drug.Name + " " + drug.Quantity, fontText, XBrushes.Black, new XRect(0, 0, pdfPage.Width, pdfPage.Height), XStringFormats.Center);
 //               gfx.DrawString("\n", fontText, XBrushes.Black, new XPoint(i++, j));
                text += drug.Name + " | " + drug.Quantity + "\n";
            }
//            gfx.DrawString(text, fontText, XBrushes.Black, new XRect(0, 0, pdfPage.Width, pdfPage.Height), XStringFormats.Center);
            tf.DrawString(text, fontText, XBrushes.Black, new XRect(0, 0, pdfPage.Width, pdfPage.Height), XStringFormats.TopLeft);
            pdfIzvestaj.Close();
            Process.Start(pdfName);
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "Promenom datuma \"Od\" i \"Do\" možete dobiti grafik koji prikazuje potrošnju lekova u tom vremenskom periodu. Na X osi je predstavljena količina potrošenih lekova, dok na Y osi pišu imena potrošenih lekova\n" +
                "\nKlikom na dugme \"Generiši izveštaj\", otvara se PDF fajl sa izgenerisanim izveštajem o potrošnji lekova u prethodno izabranom vremenskom periodu";
            MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
