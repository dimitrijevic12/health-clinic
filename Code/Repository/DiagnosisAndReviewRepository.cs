﻿using health_clinicClassDiagram.Repository.Sequencer;
using Model.Treatment;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repository.Csv.Converter;

namespace Repository
{
    public class DiagnosisAndReviewRepository : IDiagnosisAndReviewRepository
    {
        private DiagnosisAndReviewRepository()
        {
        }
        private static DiagnosisAndReviewRepository instance = null;
        public static DiagnosisAndReviewRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DiagnosisAndReviewRepository();
                }
                return instance;
            }
        }
        private String _path;
        private readonly CSVStream<DiagnosisAndReview> _stream = new CSVStream<DiagnosisAndReview>("C:\\health-clinic\\health-clinic\\Code\\diagnosisAndReviewRepo", new DiagnosisAndReviewConverter("|"));
        private readonly iSequencer<long> _sequencer;

        private long GetMaxId(List<DiagnosisAndReview> dAndRs)
        {
            return dAndRs.Count() == 0 ? 0 : dAndRs.Max(apt => apt.Id);
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DiagnosisAndReview dAndR)
        {
            var diagnosisAndReviews = _stream.ReadAll().ToList();
            var diagnosisAndReviewToRemove = diagnosisAndReviews.SingleOrDefault(ent => ent.Id.CompareTo(dAndR.Id) == 0);
            if (diagnosisAndReviewToRemove != null)
            {
                diagnosisAndReviews.Remove(diagnosisAndReviewToRemove);
                _stream.SaveAll(diagnosisAndReviews);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            var diagnosisAndReviews = _stream.ReadAll().ToList();
            var diagnosisAndReviewToRemove = diagnosisAndReviews.SingleOrDefault(ent => ent.Id.CompareTo(id) == 0);
            if (diagnosisAndReviewToRemove != null)
            {
                diagnosisAndReviews.Remove(diagnosisAndReviewToRemove);
                _stream.SaveAll(diagnosisAndReviews);
                return true;
            }
            else
            {
                return false;
            }
        }

        public DiagnosisAndReview Edit(DiagnosisAndReview obj)
        {
            var diagnosisAndReviews = _stream.ReadAll().ToList();
            diagnosisAndReviews[diagnosisAndReviews.FindIndex(apt => apt.Id == obj.Id)] = obj;
            _stream.SaveAll(diagnosisAndReviews);
            return obj;
        }

        public List<DiagnosisAndReview> GetAll()
        {
            return _stream.ReadAll();
        }

        public DiagnosisAndReview GetDiagnosisAndReview(int id)
        {
            List<DiagnosisAndReview> diagnosisAndReviews = _stream.ReadAll();
            return FindById(diagnosisAndReviews, id);
        }

        private DiagnosisAndReview FindById(List<DiagnosisAndReview> diagnosisAndReviews, int id)
        {
            foreach (DiagnosisAndReview diagnosisAndReview in diagnosisAndReviews)
            {
                if (diagnosisAndReview.Id == id)
                {
                    return diagnosisAndReview;
                }
            }
            return null;
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public DiagnosisAndReview Save(DiagnosisAndReview obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }
    }
}