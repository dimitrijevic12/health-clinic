using health_clinicClassDiagram.Controller;
using health_clinicClassDiagram.Repository;
using Model.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Service
{
    public class ExamOperationRoomService : IExamOperationRoomService
    {
        private readonly IExamOperationRoomRepository _examOperationRoomRepository;
        private static ExamOperationRoomService Instance;

        public ExamOperationRoomService GetInstance() { return null; }

        public ExamOperationRoomService(IExamOperationRoomRepository repository)
        {
            _examOperationRoomRepository = repository;
        }

        public ExamOperationRoom Create(ExamOperationRoom obj)
        {

            var newExamOperRoom = _examOperationRoomRepository.Save(obj);

            return newExamOperRoom;
        }

        public bool Delete(ExamOperationRoom obj)
        {
            _examOperationRoomRepository.Delete(obj);
            return true;
        }

        public ExamOperationRoom Edit(ExamOperationRoom obj)
        {
            _examOperationRoomRepository.Edit(obj);
            return obj;


        }

        public List<ExamOperationRoom> GetAll()
        {
            var rooms = _examOperationRoomRepository.GetAll();
            return rooms;
        }

        public bool IsRoomFree(DateTime from, DateTime to, Room room)
        {
            throw new NotImplementedException();
        }
    }
}