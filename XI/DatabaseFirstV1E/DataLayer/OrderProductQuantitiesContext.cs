using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;

namespace DataLayer
{
    public class OrderProductQuantitiesContext : IDB<OrdersProductsQuantities, Dictionary<int, string>>
    {
        private OnlineShopDBContext _context;

        public OrderProductQuantitiesContext(OnlineShopDBContext onlineShopDBContext)
        {
            _context = onlineShopDBContext;
        }

        public void Create(OrdersProductsQuantities item)
        {
            // We use OrderContext to create OPQ objects!
            throw new NotImplementedException();
        }

        public OrdersProductsQuantities Read(Dictionary<int, string> key)
        {
            try
            {
                return _context.OPQs.Find(key.Keys.First(), key.Values.First());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<OrdersProductsQuantities> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(OrdersProductsQuantities item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Dictionary<int, string> key)
        {
            try
            {
                _context.OPQs.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
