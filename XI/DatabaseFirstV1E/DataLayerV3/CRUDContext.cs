using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayerV3
{
    public class CRUDContext<T, K> : IDB<T, K> where T : class
    {
        private DbSet<T> dbSet;
        private OnlineShopDBContext context;

        public CRUDContext(DbSet<T> dbSet, OnlineShopDBContext context)
        {
            this.dbSet = dbSet;
            this.context = context;
        }

        public void Create(T item)
        {
            switch (dbSet.EntityType.ShortName())
            {
                case "Customer":
                    break;
                case "Product":
                    break;
                case "Order":
                    break;
                case "OrdersProductsQuantities":
                    break;
                default:
                    throw new ArgumentException("Type not suported!");
            }

            dbSet.Add(item);
            context.SaveChanges();
        }

        public T Read(K key)
        {
            switch (dbSet.EntityType.ShortName())
            {
                case "Customer":
                    return context.Customers.Include(c => c.FavouriteProducts).SingleOrDefault(c => c.ID == Convert.ToInt32(key)) as T;
                case "Product":
                    return context.Products.Include(p => p.FavouriteForCustomers).SingleOrDefault(p => p.Barcode == key.ToString()) as T;
                case "Order":
                    return context.Orders.Include(o => o.Customer).Include(o => o.OPQ).SingleOrDefault(o => o.ID == Convert.ToInt32(key)) as T;
                case "OrdersProductsQuantities":
                    Dictionary<int, string> dictionary = new Dictionary<int, string>(key as Dictionary<int, string>);
                    return context.OPQs.Include(opq => opq.Order).Include(opq => opq.Product).SingleOrDefault(opq => opq.OrderID == dictionary.Keys.First() && opq.ProductBarcode == dictionary.Values.First()) as T;
                default:
                    throw new ArgumentException("Type not suported!");
            }
        }

        public IEnumerable<T> ReadAll()
        {
            try
            {
                switch (dbSet.EntityType.ShortName())
                {
                    case "Customer":
                        return context.Customers.Include(c => c.FavouriteProducts).ToList() as IEnumerable<T>;
                    case "Product":
                        return context.Products.Include(p => p.FavouriteForCustomers).ToList() as IEnumerable<T>;
                    case "Order":
                        return context.Orders.Include(o => o.Customer).Include(o => o.OPQ).ToList() as IEnumerable<T>;
                    case "OrdersProductsQuantities":
                        Dictionary<int, string> dictionary = new Dictionary<int, string>();
                        return context.OPQs.Include(opq => opq.Order).Include(opq => opq.Product).ToList() as IEnumerable<T>;
                    default:
                        throw new ArgumentException("Type not suported!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(T item)
        {
            dbSet.Update(item);
            context.SaveChanges();
        }

        public void Delete(K key)
        {
            dbSet.Remove(Read(key));
            context.SaveChanges();
        }
    }
}
