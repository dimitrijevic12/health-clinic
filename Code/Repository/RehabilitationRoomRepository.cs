using health_clinicClassDiagram.Repository.Csv.Converter;
using health_clinicClassDiagram.Repository.Sequencer;
using Model.Appointment;
using Model.Rooms;
using Model.Treatment;
using Repository;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Repository
{
    public class RehabilitationRoomRepository : IRehabilitationRoomRepository
    {
        private readonly ICSVStream<RehabilitationRoom> _stream = new CSVStream<RehabilitationRoom>("../../Resources/Data/rehabilitationrooms.csv", new RehabilitationRoomCSVConverter(",", "dd.MM.yyyy."));
        private readonly iSequencer<long> _sequencer = new LongSequencer();

        private String _path = "../../Resources/Data/rehabilitationrooms.csv";
        private static RehabilitationRoomRepository instance;

        public static RehabilitationRoomRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RehabilitationRoomRepository();
                }
                return instance;
            }
        }


        private RehabilitationRoomRepository()
        {
        }

        public RehabilitationRoomRepository(string path, CSVStream<RehabilitationRoom> stream, iSequencer<long> sequencer)
        {
            _path = path;
            _stream = stream;
            _sequencer = sequencer;
            _sequencer.Initialize(GetMaxId(_stream.ReadAll()));
        }

        private long GetMaxId(List<RehabilitationRoom> rooms)
        {
            return rooms.Count() == 0 ? 0 : rooms.Max(apt => apt.IdRoom);
        }


        public bool Delete(RehabilitationRoom obj)
        {
            var rooms = _stream.ReadAll().ToList();
            var roomToRemove = rooms.SingleOrDefault(acc => acc.IdRoom == obj.IdRoom);
            if (roomToRemove != null)
            {
                rooms.Remove(roomToRemove);
                _stream.SaveAll(rooms);
                return true;
            }
            else
            {
                return false;
            }
        }

        public RehabilitationRoom Edit(RehabilitationRoom obj)
        {
            var rooms = _stream.ReadAll().ToList();
            rooms[rooms.FindIndex(apt => apt.IdRoom == obj.IdRoom)] = obj;
            _stream.SaveAll(rooms);
            return obj;
        }

        public List<RehabilitationRoom> GetAll()
        {
            var rooms = (List<RehabilitationRoom>)_stream.ReadAll();
            return rooms;
        }

        public RehabilitationRoom Save(RehabilitationRoom obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public RehabilitationRoom GetRoom(RehabilitationRoom room)
        {
            var rooms = _stream.ReadAll().ToList();           
            return rooms[rooms.FindIndex(apt => apt.IdRoom == room.IdRoom)];
        }

        public List<RehabilitationRoom> GetFreeRoomsByDate(DateTime startDate, DateTime endDate)
        {
            List<RehabilitationRoom> rooms = GetAll();
            //TODO: Pronaci slobodne sobe
            /*foreach(Treatment treatment in TreatmentRepository.Instance.GetAll())
            {
                if(treatment.ReferralToHospitalTreatment.StartDate >= startDate && ((treatment.ReferralToHospitalTreatment.EndDate <= endDate)){
                    rooms. 
                }
            }
            */
            return rooms;
        }

        public RehabilitationRoom findRehabRoom(long id)
        {
            var rooms = GetAll();
            foreach (RehabilitationRoom er in rooms)
            {
                if (er.Id == id)
                {
                    return er;
                }
            }
            return null;
        }
    }
}
