using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using ServiceLayer;

namespace PresentationLayer
{
    class SerieView
    {
        private SerieManager _serieManager;

        public SerieView()
        {
            _serieManager = new SerieManager(DBContextManager.CreateContext());
        }

        public SerieView(SerieManager serieManager)
        {
            _serieManager = serieManager;
        }

        public void CreateSerie()
        {

        }
    }
}
