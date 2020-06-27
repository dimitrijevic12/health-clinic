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
        private readonly IExamOperationRoomRepository _examOperationRoomRepository = ExamOperationRoomRepository.Instance;
        private static ExamOperationRoomService instance;

        public static ExamOperationRoomService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ExamOperationRoomService();
                }
                return instance;
            }
        }

        private ExamOperationRoomService() { }

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
        public ExamOperationRoom findExamRoom(long id)
        {
            var rooms = _examOperationRoomRepository.GetAll();
            foreach (ExamOperationRoom er in rooms)
            {
                if (er.Id == id)
                {
                    return er;
                }
            }
            return null;
        }

        public Room IncreaseQuantity(Room r, Equipment eq)
        {
            foreach (Equipment equip in r.Equipments)
            {
                if (equip.Id == eq.Id)
                {
                    equip.Quantity += eq.Quantity;
                    return r;
                }
            }
            r.Equipments.Add(eq);
            return r;


        }

        public Room DecreaseQuantity(Room r, Equipment eq)
        {
            foreach (Equipment equip in r.Equipments)
            {
                if (equip.Id == eq.Id)
                {
                    if ((equip.Quantity - eq.Quantity) < 0)
                    {
                        return r;
                    }
                    equip.Quantity -= eq.Quantity;
                    if (equip.Quantity == 0)
                    {
                        r.Equipments.Remove(eq);
                    }
                    return r;
                }
            }
            return r;
        }
    }
}