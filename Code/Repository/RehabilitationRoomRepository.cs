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

namespace health_clinicClassDiagram.Repository
{
    public class RehabilitationRoomRepository : IRehabilitationRoomRepository
    {
        private readonly ICSVStream<RehabilitationRoom> _stream;
        private readonly iSequencer<long> _sequencer;

        private String _path;
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

        public RehabilitationRoomRepository GetInstance() { return null; }

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

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
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

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
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
    }
}
