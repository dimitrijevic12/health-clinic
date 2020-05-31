/***********************************************************************
 * Module:  ICSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.ICSVConverter
 ***********************************************************************/

using System;

namespace Repository.Csv.Converter
{
   public interface ICSVConverter
   {
      String ConvertEntityToCSVFormat(Object entity);
      Object ConvertCSVFormatToEntity(String entityCSVFormat);
   }
}