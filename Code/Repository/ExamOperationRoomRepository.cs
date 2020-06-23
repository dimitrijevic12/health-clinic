using health_clinicClassDiagram.Repository.Csv.Converter;
using health_clinicClassDiagram.Repository.Sequencer;
using Model.Rooms;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Repository
{
    public class ExamOperationRoomRepository : IExamOperationRoomRepository
    {
        private readonly CSVStream<ExamOperationRoom> stream = new CSVStream<ExamOperationRoom>("C:\\Users\\Nemanja\\Desktop\\HCI-Lekar\\Code\\resources\\data\\ExamOperationRoomRepo.csv", new ExamOperationRoomCSVConverter("|"));
        private readonly LongSequencer sequencer = new LongSequencer();

        private readonly ICSVStream<ExamOperationRoom> _stream;
        private readonly iSequencer<long> _sequencer;

        private String _path;
        private static ExamOperationRoomRepository instance = null;

        public static ExamOperationRoomRepository Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new ExamOperationRoomRepository();
                }
                return instance;
            }
        }

        private ExamOperationRoomRepository()
        { 
        }

        public ExamOperationRoomRepository GetInstance() { return null; }

        public ExamOperationRoomRepository(string path, CSVStream<ExamOperationRoom> stream, iSequencer<long> sequencer)
        {
            _path = path;
            _stream = stream;
            _sequencer = sequencer;
            _sequencer.Initialize(GetMaxId(_stream.ReadAll()));
        }

        private long GetMaxId(List<ExamOperationRoom> rooms)
        {
            return rooms.Count() == 0 ? 0 : rooms.Max(ro => ro.Id);
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ExamOperationRoom obj)
        {
            //            var rooms = _stream.ReadAll().ToList();
            var rooms = stream.ReadAll().ToList();
            var roomToRemove = rooms.SingleOrDefault(ro => ro.Id == obj.Id);
            if (roomToRemove != null)
            {
                rooms.Remove(roomToRemove);
//                _stream.SaveAll(rooms);
                stream.SaveAll(rooms);
                return true;
            }
            else
            {
                return false;
            }
        }

        public ExamOperationRoom Edit(ExamOperationRoom obj)
        {
//            var rooms = _stream.ReadAll().ToList();
            var rooms = stream.ReadAll().ToList();
            rooms[rooms.FindIndex(ro => ro.Id == obj.Id)] = obj;
//            _stream.SaveAll(rooms);
            stream.SaveAll(rooms);
            return obj;
        }

        public List<ExamOperationRoom> GetAll()
        {
//            var rooms = (List<ExamOperationRoom>)_stream.ReadAll();
            var rooms = (List<ExamOperationRoom>)stream.ReadAll();
            return rooms;
        }

        public Room GetRoom(int id)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public ExamOperationRoom Save(ExamOperationRoom obj)
        {
//            _stream.AppendToFile(obj);
            stream.AppendToFile(obj);
            return obj;
        }
    }
}