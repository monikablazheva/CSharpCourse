using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MovieContext : IDB<Movie, int>
    {
        private MovieLibraryDbContext _context;
        public MovieContext(MovieLibraryDbContext context)
        {
            _context = context;
        }

        public void Create(Movie item)
        {
            _context.Movies.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int key)
        {
            Movie movieFromDb = Read(key);

            _context.Movies.Remove(movieFromDb);
            _context.SaveChanges();
        }

        public Movie Read(int key)
        {
            return _context.Movies.Find(key);
        }

        public IEnumerable<Movie> ReadAll()
        {
            return _context.Movies.ToList();
        }

        public void Update(Movie item)
        {
            Movie movieFromDb = Read(item.Id);

            _context.Entry(movieFromDb).CurrentValues.SetValues(item);
            _context.SaveChanges();
        }
    }
}
