using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Treatment;

namespace Repository.Csv.Converter
{
    class DiagnosisAndReviewConverter : ICSVConverter<DiagnosisAndReview>
    {
        private String Delimiter;

        public DiagnosisAndReviewConverter(string delimiter)
        {
            Delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(DiagnosisAndReview entity)
            => string.Join(Delimiter,
              entity.Id,
              entity.Diagnosis,
              entity.Review);
        
        public DiagnosisAndReview ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(Delimiter.ToCharArray());
            return new DiagnosisAndReview(
                tokens[1],
                tokens[2],
                int.Parse(tokens[0]));
        }
    }
}
