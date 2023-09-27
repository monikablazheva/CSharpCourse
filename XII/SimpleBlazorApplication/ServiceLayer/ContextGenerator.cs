using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class ContextGenerator
    {
        private static SimpleBlazorDbContext dbContext;
        private static BrandContext brandContext;
        private static ProductContext productContext;

        public static SimpleBlazorDbContext GetDbContext(bool useNewContext = false)
        {
            if (dbContext == null || useNewContext)
            {
                SetDbContext();
            }
            return dbContext;
        }

        public static void SetDbContext()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
            
            dbContext = new SimpleBlazorDbContext();
        }

        public static BrandContext GetBrandContext(bool useNewContext = false)
        {
            if (brandContext == null || useNewContext)
            {
                SetBrandContext(useNewContext);
            }

            return brandContext;
        }

        public static void SetBrandContext(bool useNewContext = false)
        {
            brandContext = new BrandContext(GetDbContext(useNewContext));
        }

        public static ProductContext GetProductContext(bool useNewContext = false)
        {
            if (productContext == null || useNewContext)
            {
                SetProductContext(useNewContext);
            }

            return productContext;
        }

        public static void SetProductContext(bool useNewContext = false)
        {
            productContext = new ProductContext(GetDbContext(useNewContext));
        }

    }
}
