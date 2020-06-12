/***********************************************************************
 * Module:  TreatmentRepository.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.TreatmentRepository
 ***********************************************************************/

using Model.Treatment;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class TreatmentRepository : ITreatmentRepository
   {
<<<<<<< HEAD
      public TreatmentRepository GetInstance() { return null; }
=======
        private readonly CSVStream<Treatment> _stream = new CSVStream<Treatment>("C:\\health-clinic\\health-clinic\\Code\\treatmentRepo", new TreatmentCSVConverter("|"));//TODO: Namesti stream kao Stefan
        private readonly LongSequencer _sequencer = new LongSequencer();
        private TreatmentRepository()
        {
            InitializeId();
        }
        private static TreatmentRepository instance = null;
        public static TreatmentRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TreatmentRepository();
                }
                return instance;
            }
        }
>>>>>>> master

        public Treatment GetTreatment()
        {
            throw new NotImplementedException();
        }

        public Treatment Save(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public Treatment Edit(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public List<Treatment> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        private static TreatmentRepository Instance;
      private String Path;
   
   }
}