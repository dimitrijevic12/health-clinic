using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Rooms;
using Model.Treatment;

namespace Repository.Csv.Converter
{
    class PrescriptionCSVConverter : ICSVConverter<Prescription>
    {

        private String Delimiter;

        public PrescriptionCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Prescription entity)
        {
            String drugs = "";
            foreach(Drug drug in entity.Drug)
            {
                drugs += drug.Name + "," + drug.Quantity + "#";
            }
            return string.Join(Delimiter, entity.Id, drugs);
        }
           
        public Prescription ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(Delimiter.ToCharArray());
            List<Drug> drugs = new List<Drug>();
            string drugString = tokens[1];
            string[] drugParts = drugString.Split('#');
            
            foreach(string drugParams in drugParts)
            {
                string[] drugParamParts = drugParams.Split(',');
                string drugName = drugParamParts[0];
                if (drugName.Equals("")) break;
                int drugQuantity = int.Parse(drugParamParts[1]);
                Drug drug = new Drug(drugName, drugQuantity);
                drugs.Add(drug);
            }

           
            return new Prescription(
                long.Parse(tokens[0]), drugs);
        }
    }
}
