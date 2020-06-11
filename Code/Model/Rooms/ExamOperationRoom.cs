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

    

        public ExamOperationRoom(long id) : base(id)
        {
            this.Id = id;
        }
        
   }
}