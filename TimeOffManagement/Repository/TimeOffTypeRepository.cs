using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeOffManagement.Contracts;
using TimeOffManagement.Data;

namespace TimeOffManagement.Repository
{
    // ITimeOffTypeRepository inherits the methods from IRepositoryBase
    // and then allows the TimeOffTypeRepository to inherit those same methods
    public class TimeOffTypeRepository : ITimeOffTypeRepository
    {
        private readonly ApplicationDbContext _db;

        // Constructor
        public TimeOffTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(TimeOffType entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TimeOffType entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<TimeOffType> GetAll()
        {
            throw new NotImplementedException();
        }

        public TimeOffType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(TimeOffType entity)
        {
            throw new NotImplementedException();
        }
    }
}
