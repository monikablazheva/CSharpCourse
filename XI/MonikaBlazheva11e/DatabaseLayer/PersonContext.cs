using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DatabaseLayer
{
    class PersonContext : IDB<Person, int>
    {
        private mysqlexam1v1Context _context;
        public PersonContext(mysqlexam1v1Context context)
        {
            this._context = context;
        }
        public void Create(Person item)
        {
            try
            {
                _context.Persons.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Person Read(int key)
        {
            try
            {
                return _context.Persons.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Person> ReadAll()
        {
            try
            {
                return _context.Persons.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Person item)
        {
            try
            {
                Person personFromDb = Read(item.Id);

                _context.Entry(personFromDb).CurrentValues.SetValues(item);
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
                Person personFromDb = Read(key);

                _context.Persons.Remove(personFromDb);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
