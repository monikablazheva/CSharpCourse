using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DatabaseLayer
{
    class CountryContext : IDB<Country, string>
    {
        private complicatedscenariodbContext _context;
        public CountryContext(complicatedscenariodbContext context)
        {
            this._context = context;
        }
        public void Create(Country item)
        {
            try
            {
                _context.Countries.Add(item);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public Country Read(string key)
        {
            try
            {
                return _context.Countries.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Country> ReadAll()
        {
            try
            {
                return _context.Countries.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Country item)
        {
            try
            {
                Country countryFromDb = Read(item.CountryId);
                _context.Entry(countryFromDb).CurrentValues.SetValues(item);
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
                Country countryFromDb = Read(key);
                _context.Countries.Remove(countryFromDb);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
