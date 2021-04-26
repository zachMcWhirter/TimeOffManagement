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
            _db.TimeOffTypes.Add(entity);
            return Save();
        }

        public bool Delete(TimeOffType entity)
        {
            _db.TimeOffTypes.Remove(entity);
            return Save();
        }

        public ICollection<TimeOffType> GetAll()
        {
            var timeOffTypes = _db.TimeOffTypes.ToList();
            return timeOffTypes;
        }

        public TimeOffType GetById(int id)
        {
            var timeOffType = _db.TimeOffTypes.Find(id);
            return timeOffType;
        }

        public ICollection<TimeOffType> GetEmployeesByTimeOffType(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsExistingId(int id)
        {
            // Any() is looking for any id that matched the id of the queried item
            var exists = _db.TimeOffTypes.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges() ;
            return changes > 0;
        }

        public bool Update(TimeOffType entity)
        {
            _db.TimeOffTypes.Update(entity);
            return Save();

        }
    }
}
