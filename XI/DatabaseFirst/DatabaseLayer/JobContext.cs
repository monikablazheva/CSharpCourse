using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DatabaseLayer
{
    class JobContext : IDB<Job, string>
    {
        private complicatedscenariodbContext _context;
        public JobContext(complicatedscenariodbContext context)
        {
            this._context = context;
        }
        public void Create(Job item)
        {
            try
            {
                _context.Jobs.Add(item);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Job Read(string key)
        {
            try
            {
                return _context.Jobs.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Job> ReadAll()
        {
            try
            {
                return _context.Jobs.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Job item)
        {
            try
            {
                Job jobFromDb = Read(item.JobId);
                _context.Entry(jobFromDb).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void Delete(string key)
        {
            try
            {
                Job jobFromDB = Read(key);
                _context.Jobs.Remove(jobFromDB);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
