using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerV2
{
    public class ProductContext : IDB<Product, string>
    {
        OnlineShopDBContext context;

        public ProductContext(OnlineShopDBContext context)
        {
            this.context = context;
        }

        public void Create(Product item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string key)
        {
            throw new NotImplementedException();
        }

        public Product Read(string key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
