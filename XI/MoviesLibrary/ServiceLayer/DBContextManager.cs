using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ServiceLayer
{
    public static class DBContextManager
    {
        private static MovieLibraryDbContext _context;

        public static MovieLibraryDbContext CreateContext()
        {
            _context = new MovieLibraryDbContext();
            return _context;
        }

        public static MovieLibraryDbContext GetContext()
        {
            return _context;
        }
    }
}
