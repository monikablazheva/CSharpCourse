using System;
using System.Collections.Generic;
using BusinessLayer;
using DataLayerV2;

namespace ServiceLayerV4ForDataLayerV2
{
    public class CustomerManager : IContext<Customer, int>
    {
        private CustomerContext _customerContext;

        public CustomerManager(OnlineShopDBContext context)
        {
            _customerContext = new CustomerContext(context);
        }

        public void Create(Customer customer /* string name, int age, ... */)
        {
            try
            {
                // Validate data
                // Transform primitive types to object from Business Layer
                _customerContext.Create(customer);
            }
            catch (Exception ex)
            {
                //Log the current exception in .txt file!
                throw ex;
            }
            
        }

        public Customer Read(int key)
        {
            try
            {
                return _customerContext.Read(key);
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
                return _customerContext.ReadAll();
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
                _customerContext.Update(item);
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
                _customerContext.Delete(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
