using health_clinicClassDiagram.Repository;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinicClassDiagram.Service
{
    public class RehabilitationRoomService : IRehabilitationRoomService
    {
        private readonly IRehabilitationRoomRepository _roomRepository = RehabilitationRoomRepository.Instance;

       // private readonly IUserService _patientService = PatientService.Instance;

        private static RehabilitationRoomService instance = null;

        public static RehabilitationRoomService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RehabilitationRoomService();
                }
                return instance;
            }
        }

        private RehabilitationRoomService()
        {
        }

        public static RehabilitationRoomService GetInstance()
        {

            return null;

        }

        public RehabilitationRoomService(IRehabilitationRoomRepository repository)
        {
            _roomRepository = repository;

        }

        public bool AddPatient(MedicalRecord record, RehabilitationRoom room)
        {
            RehabilitationRoom foundRehabilitationRoom = _roomRepository.GetRoom(room);
            if (foundRehabilitationRoom.CurrentlyInUse >= foundRehabilitationRoom.MaxCapacity)
            {
                return false;
            }
            else
            {
                foundRehabilitationRoom.Patients.Add(record);
                foundRehabilitationRoom.CurrentlyInUse++;
                _roomRepository.Edit(foundRehabilitationRoom);
                return true;
            }


        }

        public RehabilitationRoom Create(RehabilitationRoom obj)
        {

            RehabilitationRoom rehabilitationRoom = _roomRepository.Save(obj);
            return rehabilitationRoom;
        }

        public bool Delete(RehabilitationRoom obj)
        {
            return _roomRepository.Delete(obj);
        }

        public RehabilitationRoom Edit(RehabilitationRoom obj)
        {
            return _roomRepository.Edit(obj);
        }

        public List<RehabilitationRoom> GetAll()
        {
            List<RehabilitationRoom> records = _roomRepository.GetAll();
            return records;
        }

        public List<Patient> GetAllPatientsByRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public bool IsRoomFree(DateTime from, DateTime to, Room room)
        {
            throw new NotImplementedException();
        }

        public RehabilitationRoom getRoom(RehabilitationRoom room)
        {
            return _roomRepository.GetRoom(room);
        }

        public RehabilitationRoom GetRoomById(long id)
        {
            return _roomRepository.GetRoomById(id);
        }

        public Room IncreaseQuantity(Room room, Equipment equipment)
        {
            foreach (Equipment equipmentInRoom in room.Equipments)
            {
                if (equipmentInRoom.Id == equipment.Id)
                {
                    equipmentInRoom.Quantity += equipment.Quantity;
                    return room;
                }
            }
            room.Equipments.Add(equipment);
            return room;


        }

        public Room DecreaseQuantity(Room room, Equipment equipment)
        {
            foreach (Equipment equipmentInRoom in room.Equipments)
            {
                if (equipmentInRoom.Id == equipment.Id)
                {
                    if ((equipmentInRoom.Quantity - equipment.Quantity) < 0)
                    {
                        return room;
                    }
                    equipmentInRoom.Quantity -= equipment.Quantity;
                    if (equipmentInRoom.Quantity == 0)
                    {
                        room.Equipments.Remove(equipment);
                    }
                    return room;
                }
            }
            return room;
        }

        public bool ReleasePatient(MedicalRecord record, RehabilitationRoom room)
        {
            var foundRehabilitationRoom = _roomRepository.GetRoom(room);
            foreach (MedicalRecord oneRecord in foundRehabilitationRoom.Patients)
            {
                if (oneRecord.Id.Equals(record.Id))
                {
                    foundRehabilitationRoom.Patients.Remove(oneRecord);
                    break;
                }
            }
            foundRehabilitationRoom.CurrentlyInUse--;
            _roomRepository.Edit(foundRehabilitationRoom);
            return true;
        }
    }
}
