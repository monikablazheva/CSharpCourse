using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public class OrderManager : IContext<Order, int>
    {
        private OrderContext _orderContext;

        public OrderManager(OnlineShopDBContext context)
        {
            _orderContext = new OrderContext(context);
        }

        public void Create(Order item)
        {
            try
            {
                _orderContext.Create(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Order Read(int key)
        {
            try
            {
                return _orderContext.Read(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Order> ReadAll()
        {
            try
            {
                return _orderContext.ReadAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Order item)
        {
            try
            {
                _orderContext.Update(item);
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
                _orderContext.Delete(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AddProductsToLastOrder(IEnumerable<OrdersProductsQuantities> ordersProductsQuantities)
        {
            try
            {
                _orderContext.AddProductsToLastOrder(ordersProductsQuantities);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CalculateOrderPriceForLastOrder()
        {
            try
            {
                _orderContext.CalculateOrderPriceForLastOrder();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
