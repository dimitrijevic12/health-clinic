using Controller;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for plan_detaljan.xaml
    /// </summary>
    public partial class plan_detaljan : Window
    {
        private int colNum = 0;

        private readonly IAppointmentController _appController;
        public static ObservableCollection<Appointment> appCollection
        {
            get;
            set;
        }
        public List<Appointment> apps;
        public List<Appointment> appsPrikaz = new List<Appointment>();
        public plan_detaljan(Doctor doctor, DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.DataContext = this;

            
            _appController = AppointmentController.Instance;

            apps = _appController.GetAll();

            foreach(Appointment a in apps)
            {
                if((a.Doctor.Id == doctor.Id) && (a.StartDate >= date1) && (a.EndDate <= date2.AddHours(24)))
                {
                    appsPrikaz.Add(a);
                }
            }

            appCollection = new ObservableCollection<Appointment>(appsPrikaz);


            string pdfFilename = "IzvestajPlanLekara.pdf";
            PdfDocument pdfDocument = new PdfDocument(pdfFilename);
            pdfDocument.Info.Title = "Plan rada lekara u odredjenom vremenu";
            PdfPage pdfPage = pdfDocument.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont fontTitle = new XFont("Helvetica", 24, XFontStyle.Bold);
            XFont font = new XFont("Helvetica", 14, XFontStyle.Regular);
            XTextFormatter tf = new XTextFormatter(graph);
            String write = "Zakazani termini za izabranog lekara:\n\n";
            foreach(Appointment a in appsPrikaz)
            {
                String st = "ID pregleda: " + a.Id + "Lekar: " + a.Doctor + "| Pacijent: " + a.Patient + "| Tip: " + a.TypeOfAppointment + "| Sala: " + a.RoomId + "| Početak: " + a.StartDate + "\n";
                write += st; 
            }

            tf.DrawString(write, font, XBrushes.Black, new XRect(0, 0, pdfPage.Width, pdfPage.Height), XStringFormats.TopLeft);
            pdfDocument.Close();
        }
        

        private void Button_izadji(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
