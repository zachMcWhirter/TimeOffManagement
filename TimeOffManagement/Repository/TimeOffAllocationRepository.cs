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
            _db.TimeOffAllocations.Add(entity);
            return Save();
        }

        public bool Delete(TimeOffAllocation entity)
        {
            _db.TimeOffAllocations.Remove(entity);
            return Save();
        }

        public ICollection<TimeOffAllocation> GetAll()
        {
            var timeOffAllocations = _db.TimeOffAllocations.ToList();
            return timeOffAllocations;
        }

        public TimeOffAllocation GetById(int id)
        {
            var timeOffAllocation = _db.TimeOffAllocations.Find(id);
            return timeOffAllocation;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(TimeOffAllocation entity)
        {
            _db.TimeOffAllocations.Update(entity);
            return Save();
        }
    }
}
