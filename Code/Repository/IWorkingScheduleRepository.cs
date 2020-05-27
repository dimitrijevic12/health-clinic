/***********************************************************************
 * Module:  IWorkingScheduleRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IWorkingScheduleRepository
 ***********************************************************************/

using Model.SystemUsers;

namespace Repository
{
    public interface IWorkingScheduleRepository : IRepository<WorkingSchedule>
    {
        Model.SystemUsers.WorkingSchedule GetWorkingSchedule(Model.SystemUsers.WorkingSchedule workingSchedule);
    }
}