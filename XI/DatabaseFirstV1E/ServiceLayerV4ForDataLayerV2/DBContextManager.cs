using DataLayerV2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayerV4ForDataLayerV2
{
    public static class DBContextManager
    {
        private static OnlineShopDBContext _context;
        private static CustomerContext _customerContext;
        private static ProductContext _productContext;
        private static OrderContext _orderContext;

        #region DB Context

        public static OnlineShopDBContext CreateContext()
        {
            _context = new OnlineShopDBContext();
            return _context;
        }

        public static OnlineShopDBContext GetContext()
        {
            return _context;
        }

        public static void SetChangeTracking(bool value)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = value;
        }

        #endregion

        #region TContexts

        public static CustomerContext CreateCustomerContext(OnlineShopDBContext context)
        {
            _customerContext = new CustomerContext(context);
            return _customerContext;
        }

        public static CustomerContext GetCustomerContext()
        {
            return _customerContext;
        }

        public static ProductContext CreateProductContext(OnlineShopDBContext context)
        {
            _productContext = new ProductContext(context);
            return _productContext;
        }

        public static ProductContext GetProductContext()
        {
            return _productContext;
        }

        public static OrderContext CreateOrderContext(OnlineShopDBContext context)
        {
            _orderContext = new OrderContext(context);
            return _orderContext;
        }

        public static OrderContext GetOrderContext()
        {
            return _orderContext;
        }

        #endregion

    }
}
