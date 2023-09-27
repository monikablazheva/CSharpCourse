using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DatabaseLayer
{
    class CityContext : IDB<City, int>
    {
        private mysqlexam1v1Context _context;
        public CityContext(mysqlexam1v1Context context)
        {
            this._context = context;
        }
        public void Create(City item)
        {
            try
            {
                _context.Cities.Add(item);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public City Read(int key)
        {
            try
            {
                return _context.Cities.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<City> ReadAll()
        {
            try
            {
                return _context.Cities.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(City item)
        {
            try
            {
                City cityFromDb = Read(item.Id);

                _context.Entry(cityFromDb).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(int key)
        {
            try
            {
                City cityFromDb = Read(key);

                _context.Cities.Remove(cityFromDb);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
