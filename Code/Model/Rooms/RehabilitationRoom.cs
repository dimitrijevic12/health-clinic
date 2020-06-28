/***********************************************************************
 * Module:  RehabilitationRoom.cs
 * Author:  User
 * Purpose: Definition of the Class Rooms.RehabilitationRoom
 ***********************************************************************/

using Model.Appointment;
using System;
using System.Collections.Generic;

namespace Model.Rooms
{
   public class RehabilitationRoom : Room
   {
       
        private List<MedicalRecord> _patients;

        private int _maxCapacity;
        private int _currentlyInUse;

        public RehabilitationRoom(long idRoom, int currentlyInUse, int maxCapacity, List<MedicalRecord> patients) : base(idRoom)
        {
            
            _patients = patients;
            _maxCapacity = maxCapacity;
            _currentlyInUse = currentlyInUse;
            IdRoom = idRoom;
            tip = TypeOfRoom.REHABILITATION;
            Equipments = new List<Equipment>();
        }
        public RehabilitationRoom(long idRoom, int currentlyInUse, int maxCapacity, List<MedicalRecord> patients, List<Equipment> equipments) : base(idRoom)
        {
            _patients = patients;
            _maxCapacity = maxCapacity;
            _currentlyInUse = currentlyInUse;
            IdRoom = idRoom;
            tip = TypeOfRoom.REHABILITATION;
            Equipments = equipments;
        }

        public RehabilitationRoom(long idRoom, int currentlyInUse, int maxCapacity, List<Equipment> equipments) : base(idRoom)
        {

            Equipments = equipments;
            _maxCapacity = maxCapacity;
            _currentlyInUse = currentlyInUse;
            IdRoom = idRoom;
            tip = TypeOfRoom.REHABILITATION;
        }
        public RehabilitationRoom(long idRoom, int currentlyInUse, int maxCapacity) : base(idRoom)
        {

            
            _maxCapacity = maxCapacity;
            _currentlyInUse = currentlyInUse;
            IdRoom = idRoom;
            tip = TypeOfRoom.REHABILITATION;
            Equipments = new List<Equipment>();
        }

        public List<MedicalRecord> Patients
        {
            get { return _patients; }   // get method
            set { _patients = value; }
        }

        public int MaxCapacity
        {
            get { return _maxCapacity; }   // get method
            set { _maxCapacity = value; }
        }

        public int CurrentlyInUse
        {
            get { return _currentlyInUse; }   // get method
            set { _currentlyInUse = value; }
        }

        public long IdRoom
        {
            get { return Id; }   // get method
            set { Id = value; }
        }
        public TypeOfRoom tip
        {
            get { return tipSobe; }
            set { tipSobe = value; }
        }

        /*public List<Equipment> Equipments
        {
            get { return equipments; }
            set { equipments = value; }
        }*/


    }
}