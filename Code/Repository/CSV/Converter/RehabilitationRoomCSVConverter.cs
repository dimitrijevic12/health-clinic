using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
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

            return new RehabilitationRoom(idRoom, inUse, max, equipments);

            /*int i = 3;

            while (i < tokens.Length - 1)
            {
                long idNaloga = long.Parse(tokens[i]);
                i++;
                string ime = tokens[i];
                i++;
                string prezime = tokens[i];
                i++;
                int idPatient = int.Parse(tokens[i]);
                Patient patient = new Patient(ime, prezime, idPatient);
                MedicalRecord record = new MedicalRecord(idNaloga, patient, new Doctor(), new List<Treatment>());
                records.Add(record);
                i++;
            }

            return new RehabilitationRoom(idRoom, inUse, max, records);*/
        }

        public string ConvertEntityToCSVFormat(RehabilitationRoom entity)
        {
            String resenje = "";


            /*foreach (MedicalRecord record in entity.Patients)
            {
                resenje += string.Join(_delimiter, record.IDnaloga, record.Name, record.Surname, record.IDPatient);
                resenje += _delimiter;
            }*/

            foreach (Equipment equipment in entity.Equipments)
            {
                resenje += string.Join(_delimiter, equipment.Id, equipment.Naziv, equipment.Quantity);
                resenje += _delimiter;
            }


            return string.Join(_delimiter,
              entity.IdRoom,
              entity.CurrentlyInUse,
              entity.MaxCapacity,
              resenje);
        }
    }
}
