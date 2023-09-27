using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SerieContext : IDB<Serie, int>
    {
        private MovieLibraryDbContext _context;
        public SerieContext(MovieLibraryDbContext context)
        {
            _context = context;
        }

        public void Create(Serie item)
        {
            _context.Series.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int key)
        {
            Serie serieFromDb = Read(key);

            _context.Series.Remove(serieFromDb);
            _context.SaveChanges();
        }

        public Serie Read(int key)
        {
            return _context.Series.Find(key);
        }

        public IEnumerable<Serie> ReadAll()
        {
            return _context.Series.ToList();
        }

        public void Update(Serie item)
        {
            Serie serieFromDb = Read(item.Id);

            _context.Entry(serieFromDb).CurrentValues.SetValues(item);
            _context.SaveChanges();
        }
    }
}
