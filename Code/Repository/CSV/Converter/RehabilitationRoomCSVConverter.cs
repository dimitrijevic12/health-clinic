using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
using Repository;
using Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinicClassDiagram.Repository.Csv.Converter
{
    public class RehabilitationRoomCSVConverter : ICSVConverter<RehabilitationRoom>
    {
        private readonly string _delimiter;
        

        public RehabilitationRoomCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
           
        }

        public RehabilitationRoom ConvertCSVFormatToEntity(string entityCSVFormat)
        {
           /* List<MedicalRecord> records = new List<MedicalRecord>();
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());
            long idRoom = long.Parse(tokens[0]);
            int inUse = int.Parse(tokens[1]);
            int max = int.Parse(tokens[2]);

            List<Equipment> equipments = new List<Equipment>();

            int i = 3;

            while (i < tokens.Length - 1)
            {
                int idEquip = int.Parse(tokens[i]);
                i++;
                string naziv = tokens[i];
                i++;
                int quantity = int.Parse(tokens[i]);

                Equipment equipment = new Equipment(idEquip, naziv, quantity);
                equipments.Add(equipment);
                i++;
            }

            return new RehabilitationRoom(idRoom, inUse, max, equipments);*/
          
            List<MedicalRecord> records = new List<MedicalRecord>();
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());
            long idRoom = long.Parse(tokens[0]);
            int inUse = int.Parse(tokens[1]);
            int max = int.Parse(tokens[2]);



            var recordRepository = MedicalRecordRepository.Instance;
            List<Equipment> equipments = new List<Equipment>();

            if (tokens[3] != "")
            {
                String idString = tokens[3];

                String[] oneId = idString.Split('|');

                for (int j = 0; j < oneId.Length; j++)
                {
                    records.Add(recordRepository.getMedRecById(long.Parse(oneId[j])));
                }
            }
            int i = 4;
            while (i < tokens.Length - 1)
            {
                int idEquip = int.Parse(tokens[i]);
                i++;
                string naziv = tokens[i];
                i++;
                int quantity = int.Parse(tokens[i]);

                Equipment equipment = new Equipment(idEquip, naziv, quantity);
                equipments.Add(equipment);
                i++;
            }



            return new RehabilitationRoom(idRoom, inUse, max, records, equipments);

        }

        public string ConvertEntityToCSVFormat(RehabilitationRoom entity)
        {
            /*  String resenje = "";




              foreach (Equipment equipment in entity.Equipments)
              {
                  resenje += string.Join(_delimiter, equipment.Id, equipment.Naziv, equipment.Quantity);
                  resenje += _delimiter;
              }


              return string.Join(_delimiter,
                entity.IdRoom,
                entity.CurrentlyInUse,
                entity.MaxCapacity,
                resenje);*/
            String resenje = "";

            if (entity.Patients.Count != 0)
            {
                MedicalRecord last = entity.Patients.Last();
                foreach (MedicalRecord record in entity.Patients)
                {
                    if (record != last)
                    {
                        resenje += record.Id + "|";
                    }
                    else
                    {
                        resenje += record.Id;
                    }
                }
            }
            String resenje2 = "";
            foreach (Equipment equipment in entity.Equipments)
            {
                resenje2 += string.Join(_delimiter, equipment.Id, equipment.Naziv, equipment.Quantity);
                resenje2 += _delimiter;
            }

            return string.Join(_delimiter,
              entity.IdRoom,
              entity.CurrentlyInUse,
              entity.MaxCapacity,
              resenje,
              resenje2);
        }
    }
}
