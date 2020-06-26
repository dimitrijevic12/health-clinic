/***********************************************************************
 * Module:  BlogCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.BlogCSVConverter
 ***********************************************************************/

using Model.Surveys;
using System;

namespace Repository.Csv.Converter
{
   public class BlogCSVConverter : ICSVConverter<Blog>
   {
      private String Delimiter;

        public Blog ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}