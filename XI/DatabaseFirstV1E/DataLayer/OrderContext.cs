using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class OrderContext : IDB<Order, int>
    {
        private OnlineShopDBContext _context;

        public OrderContext(OnlineShopDBContext context)
        {
            this._context = context;
        }

        public void Create(Order item)
        {
            try
            {
                Customer customerFromDB = _context.Customers.Find(item.CustomerID);

                if (customerFromDB != null)
                {
                    item.Customer = customerFromDB;
                }

                _context.Orders.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Order Read(int key)
        {
            try
            {
                /*
                Order order = _context.Orders.Find(key);

                _context.Entry(order).Reference(o => o.Customer).Load();
                _context.Entry(order).Collection(o => o.OPQ).Load();

                return order;
                */

                return _context.Orders.Include(o => o.Customer).Include(o => o.OPQ).ThenInclude(opq => opq.Product).Single(o => o.ID == key);
            }
            catch(InvalidOperationException ex)
            {
                throw new Exception("There is no order with that id in the DB!");
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
                return _context.Orders.Include(o => o.Customer).Include(o => o.OPQ).ThenInclude(opq => opq.Product).ToList();
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
                _context.Orders.Update(item);
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
                _context.Orders.Remove(Read(key));
                _context.SaveChanges();
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
                Order order = _context.Orders.OrderBy(o => o.ID).Last();

                foreach (var item in ordersProductsQuantities)
                {
                    item.OrderID = order.ID;
                }

                order.OPQ = ordersProductsQuantities;
                //_context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CalculateOrderPriceForLastOrder()
        {
            Order order = _context.Orders.Include(o => o.OPQ).ThenInclude(opq => opq.Product).OrderBy(o => o.ID).Last();

            order.Price = 0;
            foreach (var item in order.OPQ)
            {
                order.Price += item.Product.Price * item.Quantity;
            }

            _context.SaveChanges();
        }

    }
}
