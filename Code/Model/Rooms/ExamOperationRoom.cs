/***********************************************************************
 * Module:  Exam/operationRoom.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Rooms.Exam/operationRoom
 ***********************************************************************/

using System;

namespace Model.Rooms
{
   public class ExamOperationRoom : Room
   {
      private Boolean InUse;
      private TypeOfRoom TypeOfRoom;

        public long _id;
       


        public ExamOperationRoom(long id) : base(id)
        {
            this.Id = id;
            tip = TypeOfRoom.EXAMOPERATION;
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
