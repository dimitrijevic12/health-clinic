using Controller;
using health_clinicClassDiagram.Controller;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;
using System.Windows;

namespace health_clinicClassDiagram.view
{
    /// <summary>
    /// Interaction logic for dodaj_salu.xaml
    /// </summary>
    public partial class dodaj_salu : Window
    {
        private readonly IController<ExamOperationRoom> _examOperationRoomController;
        private readonly IController<RehabilitationRoom> _rehabilitationRoomController;

        private long _idSobe;
        private string _ime;
        private int _trenutno=0;
        private int _max = 0;


        public dodaj_salu()
        {
            InitializeComponent();
            this.DataContext = this;

            
            _examOperationRoomController = ExamOperationRoomController.Instance;
            _rehabilitationRoomController = RehabilitationRoomController.Instance;
        }

       

        private void Button_otkazi(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_potvrdi(object sender, RoutedEventArgs e)
        {

            if ((maxi.Text == "") || (Id_sale.Text == "") || (tip.SelectedIndex == -1))
            {
                string message = "Sva polja moraju biti popunjena!";
                string title = "Greška";

                MessageBox.Show(message, title);
            }
            else
            {

                String TIP = null;


                if (tip.SelectedIndex == 0)
                {
                    String ID = Id_sale.Text;
                    _idSobe = long.Parse(ID);

                    ExamOperationRoom newERoom = createExamOperationRoom();

                }
                else
                {
                    String ID = Id_sale.Text;
                    _idSobe = long.Parse(ID);
                    String maximum = maxi.Text;
                    _max = int.Parse(maximum);

                    RehabilitationRoom newRRoom = createRehabilitationRoom();

                }






                //prikaz_opreme.Spisak.Add(new SpisakSala() {Sala = ID, TipSale = IME});

                this.Close();
            }
        }

        private RehabilitationRoom createRehabilitationRoom()
        {
            List<MedicalRecord> lista = new List<MedicalRecord>();


            RehabilitationRoom neRoom = new RehabilitationRoom(_idSobe,_trenutno, _max, lista);

            return _rehabilitationRoomController.Create(neRoom);
        }

        private ExamOperationRoom createExamOperationRoom()
        {
            ExamOperationRoom nRoom = new ExamOperationRoom(_idSobe);

            return _examOperationRoomController.Create(nRoom);
        }
    }
}
