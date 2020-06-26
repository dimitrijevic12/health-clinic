﻿using health_clinicClassDiagram.Repository;
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

        public RehabilitationRoomService(IRehabilitationRoomRepository repository)
        {
            _roomRepository = repository;

        }

        public bool AddPatient(MedicalRecord record, RehabilitationRoom room)
        {
            var foundRehabilitationRoom = _roomRepository.GetRoom(room);
            foundRehabilitationRoom.Patients.Add(record);
            foundRehabilitationRoom.CurrentlyInUse++;
            _roomRepository.Edit(foundRehabilitationRoom);
            return true;


        }

        public RehabilitationRoom Create(RehabilitationRoom obj)
        {

            var RehabilitationRoom = _roomRepository.Save(obj);
            return RehabilitationRoom;
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
            var records = _roomRepository.GetAll();
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

        public bool releasePatient(MedicalRecord record, RehabilitationRoom room)
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
