using Model.Rooms;
using Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Repository.Csv.Converter
{
    class ExamOperationRoomCSVConverter : ICSVConverter<ExamOperationRoom>
    {
        

        private readonly string _delimiter;

      
        public ExamOperationRoomCSVConverter(string delimiter)
        {
            _delimiter = delimiter;      

        }
        public ExamOperationRoom ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());
            ExamOperationRoom room = new ExamOperationRoom(long.Parse(tokens[0]));
            return room;
        }

        public string ConvertEntityToCSVFormat(ExamOperationRoom entity)
        {
            return string.Join(_delimiter,
                entity.Id);
        }
    }
}

