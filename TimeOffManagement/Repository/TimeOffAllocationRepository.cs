using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeOffManagement.Contracts;
using TimeOffManagement.Data;

namespace TimeOffManagement.Repository
{
    public class TimeOffAllocationRepository : ITimeOffAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public TimeOffAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(TimeOffAllocation entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TimeOffAllocation entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<TimeOffAllocation> GetAll()
        {
            throw new NotImplementedException();
        }

        public TimeOffAllocation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(TimeOffAllocation entity)
        {
            throw new NotImplementedException();
        }
    }
}
