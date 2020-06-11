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
<<<<<<< HEAD
      public List<InventoryDrugs> inventoryDrugs;
      private List<MedicalRecord> _patients;
   
      private int _maxCapacity;
      private int _currentlyInUse;
=======
        public List<InventoryDrugs> inventoryDrugs;
        private List<MedicalRecord> _patients;

        private int _maxCapacity;
        private int _currentlyInUse;
>>>>>>> master

        public RehabilitationRoom(long idRoom, int currentlyInUse, int maxCapacity, List<MedicalRecord> patients)
        {
            _patients = patients;
            _maxCapacity = maxCapacity;
            _currentlyInUse = currentlyInUse;
            IdRoom = idRoom;
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

<<<<<<< HEAD


=======
>>>>>>> master
    }
}