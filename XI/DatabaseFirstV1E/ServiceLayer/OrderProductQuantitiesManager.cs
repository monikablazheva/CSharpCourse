using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public class OrderProductQuantitiesManager : IContext<OrdersProductsQuantities, Dictionary<int, string>>
    {
        OrderProductQuantitiesContext _context;

        public OrderProductQuantitiesManager(OnlineShopDBContext context)
        {
            _context = new OrderProductQuantitiesContext(context);
        }

        public void Create(OrdersProductsQuantities item)
        {
            throw new NotImplementedException();
        }

        public OrdersProductsQuantities Read(Dictionary<int, string> key)
        {
            try
            {
                return _context.Read(key);
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
                _context.Delete(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
