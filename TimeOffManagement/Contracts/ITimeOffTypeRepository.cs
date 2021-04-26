using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeOffManagement.Data;

namespace TimeOffManagement.Contracts
{
    // ITimeOffTypeRepository inherits the methods from IRepositoryBase
    // and then allows the TimeOffTypeRepository to inherit those same methods
    public interface ITimeOffTypeRepository : IRepositoryBase<TimeOffType>
    {
        ICollection<TimeOffType> GetEmployeesByTimeOffType(int id);
    }
}
