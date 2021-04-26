using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeOffManagement.Contracts;
using TimeOffManagement.Data;

namespace TimeOffManagement.Repository
{
    public class TimeOffHistoryRepository : ITimeOffHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public TimeOffHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(TimeOffHistory entity)
        {
            _db.TimeOffHistories.Add(entity);
            return Save();
        }

        public bool Delete(TimeOffHistory entity)
        {
            _db.TimeOffHistories.Remove(entity);
            return Save();
        }

        public ICollection<TimeOffHistory> GetAll()
        {
            var timeOffHistories = _db.TimeOffHistories.ToList();
            return timeOffHistories;
        }

        public TimeOffHistory GetById(int id)
        {
            var timeOffHistory = _db.TimeOffHistories.Find(id);
            return timeOffHistory;
        }

        public bool IsExistingId(int id)
        {
            // Any() is looking for any id that matched the id of the queried item
            var exists = _db.TimeOffTypes.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(TimeOffHistory entity)
        {
            _db.TimeOffHistories.Update(entity);
            return Save();
        }
    }
}
