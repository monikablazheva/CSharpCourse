using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerV2
{
    public class OrderContext : IDB<Order, int>
    {
        OnlineShopDBContext context;

        public OrderContext(OnlineShopDBContext context)
        {
            this.context = context;
        }

        public void Create(Order item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public Order Read(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
