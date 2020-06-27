using Controller;
using health_clinicClassDiagram.Repository.Csv.Converter;
using health_clinicClassDiagram.Repository.Sequencer;
using Model.SystemUsers;
using Repository;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Repository
{
    public class WorkingDaysRepository : IRepository<WorkingDays>
    {
        private static WorkingDaysRepository instance = null;
        private readonly ICSVStream<WorkingDays> _stream = new CSVStream<WorkingDays>("../../Resources/Data/workingDays.csv", new WorkingDaysCSVConverter(",", "dd.MM.yyyy."));
        private readonly LongSequencer _sequencer = new LongSequencer();


        private String _path = "../../Resources/Data/doctors.csv";
        public static WorkingDaysRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WorkingDaysRepository();
                }
                return instance;
            }
        }

        private WorkingDaysRepository()
        {
        }

        private long GetMaxId(List<WorkingDays> allWorkingDays)
        {
            return allWorkingDays.Count() == 0 ? 0 : allWorkingDays.Max(work => work.Id);
        }

        public WorkingDays Save(WorkingDays obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public WorkingDays Edit(WorkingDays obj)
        {
            var allWorkingDays = _stream.ReadAll().ToList();
            allWorkingDays[allWorkingDays.FindIndex(apt => apt.Id == obj.Id)] = obj;
            _stream.SaveAll(allWorkingDays);
            return obj;
        }

        public bool Delete(WorkingDays obj)
        {
            var allWorkingDays = _stream.ReadAll().ToList();
            var workingDayToRemove = allWorkingDays.SingleOrDefault(acc => acc.Id == obj.Id);
            if (workingDayToRemove != null)
            {
                allWorkingDays.Remove(workingDayToRemove);
                _stream.SaveAll(allWorkingDays);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<WorkingDays> GetAll()
        {
            var allWorkingDays = (List<WorkingDays>)_stream.ReadAll();
            return allWorkingDays;
        }

        public WorkingDays GetWorkingDaysById(long id)
        {
            var allWorkingDays = _stream.ReadAll().ToList();
            return allWorkingDays[allWorkingDays.FindIndex(apt => apt.Id == id)];
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
