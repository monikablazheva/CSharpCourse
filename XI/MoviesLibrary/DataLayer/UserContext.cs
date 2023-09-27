using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserContext : IDB<User, int>
    {
        private MovieLibraryDbContext _context;
        public UserContext(MovieLibraryDbContext context)
        {
            _context = context;
        }

        public void Create(User item)
        {
            _context.Users.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int key)
        {
            User userFromDb = Read(key);

            _context.Users.Remove(userFromDb);
            _context.SaveChanges();
        }

        public User Read(int key)
        {
            return _context.Users.Find(key);
        }

        public IEnumerable<User> ReadAll()
        {
            return _context.Users.ToList();
        }

        public void Update(User item)
        {
            User userFromDb = Read(item.Id);

            _context.Entry(userFromDb).CurrentValues.SetValues(item);
            _context.SaveChanges();
        }
    }
}
