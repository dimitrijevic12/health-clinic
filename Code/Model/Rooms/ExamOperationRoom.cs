/***********************************************************************
 * Module:  Exam/operationRoom.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Rooms.Exam/operationRoom
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Model.Rooms
{
   public class ExamOperationRoom : Room
   {
      private Boolean InUse;
      

        public long _id;
       

        public ExamOperationRoom()
        {

        }
        public ExamOperationRoom(long id) : base(id)
        {
            this.Id = id;
            tip = TypeOfRoom.EXAMOPERATION;
        }

        public ExamOperationRoom(long id, List<Equipment> equipments) : base(id)
        {
            this.Id = id;
            tip = TypeOfRoom.EXAMOPERATION;
            Equipments = equipments;
        }
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public TypeOfRoom tip
        {
            get { return tipSobe; }
            set { tipSobe = value; }
        }
    }
   

}
