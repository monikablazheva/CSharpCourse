using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    public class SerieManager : IContext<Serie, int>
    {
        private SerieContext _serieContext;

        public SerieManager(MovieLibraryDbContext context)
        {
            _serieContext = new SerieContext(context);
        }
        public void Create(Serie serie)
        {
            _serieContext.Create(serie);
        }

        public void Delete(int key)
        {
            _serieContext.Delete(key);
        }

        public Serie Read(int key)
        {
            return _serieContext.Read(key);
        }

        public IEnumerable<Serie> ReadAll()
        {
            return _serieContext.ReadAll();
        }

        public void Update(Serie serie)
        {
            _serieContext.Update(serie);
        }
    }
}
