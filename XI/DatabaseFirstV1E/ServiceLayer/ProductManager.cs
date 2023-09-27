using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public class ProductManager : IContext<Product, string>
    {
        private ProductContext _productContext;

        public ProductManager(OnlineShopDBContext context)
        {
            this._productContext = new ProductContext(context);
        }

        public void Create(Product item)
        {
            try
            {
                _productContext.Create(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Product Read(string key)
        {
            try
            {
                return _productContext.Read(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Product> ReadAll()
        {
            try
            {
                return _productContext.ReadAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Product item)
        {
            try
            {
                _productContext.Update(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string key)
        {
            try
            {
                _productContext.Delete(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
