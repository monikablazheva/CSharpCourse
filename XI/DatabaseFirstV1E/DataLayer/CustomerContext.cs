using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class CustomerContext : IDB<Customer, int>
    {
        private OnlineShopDBContext _context;

        public CustomerContext(OnlineShopDBContext context)
        {
            this._context = context;
        }

        public void Create(Customer item)
        {
            try
            {
                List<Product> products = new List<Product>(item.FavouriteProducts.Count());

                foreach (Product product in item.FavouriteProducts)
                {
                    Product productFromDB = _context.Products.Find(product.Barcode);

                    if (productFromDB != null)
                    {
                        products.Add(productFromDB);
                    }
                    else
                    {
                        products.Add(product);
                    }
                }

                item.FavouriteProducts = products;

                _context.Customers.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customer Read(int key)
        {
            try
            {
                return _context.Customers.Include(c => c.FavouriteProducts).SingleOrDefault(c => c.ID == key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Customer> ReadAll()
        {
            try
            {
                return _context.Customers.Include(c => c.FavouriteProducts).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Customer item)
        {
            try
            {
                _context.Update(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                Customer customerFromDB = Read(key);

                _context.Customers.Remove(customerFromDB);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
