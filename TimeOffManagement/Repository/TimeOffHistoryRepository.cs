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
            throw new NotImplementedException();
        }

        public bool Delete(TimeOffHistory entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<TimeOffHistory> GetAll()
        {
            throw new NotImplementedException();
        }

        public TimeOffHistory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(TimeOffHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
