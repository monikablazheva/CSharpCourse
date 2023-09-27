using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    public class MovieManager : IContext<Movie, int>
    {
        private MovieContext _movieContext;

        public MovieManager(MovieLibraryDbContext context)
        {
            _movieContext = new MovieContext(context);
        }
        public void Create(Movie movie)
        {
            _movieContext.Create(movie);
        }

        public void Delete(int key)
        {
            _movieContext.Delete(key);
        }

        public Movie Read(int key)
        {
            return _movieContext.Read(key);
        }

        public IEnumerable<Movie> ReadAll()
        {
            return _movieContext.ReadAll();
        }

        public void Update(Movie movie)
        {
            _movieContext.Update(movie);
        }
    }
}
