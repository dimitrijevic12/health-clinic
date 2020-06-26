using health_clinicClassDiagram.Repository.Sequencer;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
using Repository;
using Repository.Csv.Converter;
using Repository.Csv.Stream;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Repository.Csv.Converter
{
    public class RehabilitationRoomCSVConverter : ICSVConverter<RehabilitationRoom>
    {
        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public RehabilitationRoomCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public RehabilitationRoom ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            List<MedicalRecord> records = new List<MedicalRecord>();
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());
            long idRoom = long.Parse(tokens[0]);
            int inUse = int.Parse(tokens[1]);
            int max = int.Parse(tokens[2]);

            int i = 3;

            var recordRepository = MedicalRecordRepository.Instance;

            if (tokens[3] != "")
            {
                String idString = tokens[3];

                String[] oneId = idString.Split('|');

                for (int j = 0; j < oneId.Length; j++)
                {
                    records.Add(recordRepository.getMedRecById(long.Parse(oneId[j])));
                }
            }

            

            return new RehabilitationRoom(idRoom, inUse, max, records); 
        }

        public string ConvertEntityToCSVFormat(RehabilitationRoom entity)
        {

            String resenje = "";

            if (entity.Patients.Count != 0)
            {
                MedicalRecord last = entity.Patients.Last();
                foreach (MedicalRecord record in entity.Patients)
                {
                    if (record != last)
                    {
                        resenje += record.IDnaloga + "|";
                    }
                    else
                    {
                        resenje += record.IDnaloga;
                    }
                }
            }


            return string.Join(_delimiter,
              entity.IdRoom,
              entity.CurrentlyInUse,
              entity.MaxCapacity,
              resenje);
        }
    }
}
