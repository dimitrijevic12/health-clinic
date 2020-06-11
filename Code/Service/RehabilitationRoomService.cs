using health_clinicClassDiagram.Repository;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> master

namespace health_clinicClassDiagram.Service
{
    public class RehabilitationRoomService : IRehabilitationRoomService
    {
        private readonly IRehabilitationRoomRepository _roomRepository;
        private readonly IUserService _patientService;

        private static MedicalRecordService instance = null;
<<<<<<< HEAD
        public static RehabilitationRoomService GetInstance() {

            return null;
            
=======
        public static RehabilitationRoomService GetInstance()
        {

            return null;

>>>>>>> master
        }

        public RehabilitationRoomService(IRehabilitationRoomRepository repository, IUserService service)
        {
            _roomRepository = repository;
            _patientService = service;
        }

        public bool AddPatient(MedicalRecord record, RehabilitationRoom room)
        {
            var foundRehabilitationRoom = _roomRepository.GetRoom(room);
            //var foundPatient = _patientService.Get(patient);
            foundRehabilitationRoom.Patients.Add(record);
            foundRehabilitationRoom.CurrentlyInUse++;
            _roomRepository.Edit(foundRehabilitationRoom);
            return true;


        }

        public RehabilitationRoom Create(RehabilitationRoom obj)
        {
<<<<<<< HEAD
          
            var RehabilitationRoom = _roomRepository.Save(obj);           
=======

            var RehabilitationRoom = _roomRepository.Save(obj);
>>>>>>> master
            return RehabilitationRoom;
        }

        public bool Delete(RehabilitationRoom obj)
<<<<<<< HEAD
        {      
=======
        {
>>>>>>> master
            return _roomRepository.Delete(obj);
        }

        public RehabilitationRoom Edit(RehabilitationRoom obj)
<<<<<<< HEAD
        {        
            return _roomRepository.Edit(obj);            
=======
        {
            return _roomRepository.Edit(obj);
>>>>>>> master
        }

        public List<RehabilitationRoom> GetAll()
        {
            var patients = _patientService.GetAll();
            var records = _roomRepository.GetAll();
            //BindPatientsWithRecords(patients, records);
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
    }
}
