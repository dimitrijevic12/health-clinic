/***********************************************************************
 * Module:  ICSVStream.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.ICSVStream
 ***********************************************************************/

using System;

namespace Repository.Csv.Stream
{
   public interface ICSVStream
   {
      void SaveAll(List<Object> entities);
      List<Object> ReadAll();
      void AppendToFile(Object entity);
   }
}