using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayerV2
{
    public class CustomerManager : IContext<int>
    {
        CustomerContext customerContext;

        public CustomerManager(OnlineShopDBContext context)
        {
            customerContext = new CustomerContext(context);
        }

        public void Create(object[] item)
        {
            try
            {
                string name = item[0].ToString();
                string country = item[1].ToString();
                int age = Convert.ToInt32(item[2]);

                Customer customer = new Customer(name, country, age);

                customerContext.Create(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object[] Read(int key)
        {
            try
            {
                Customer customer = customerContext.Read(key);

                object[] array = new object[4];
                array[0] = customer.ID;
                array[1] = customer.Name;
                array[2] = customer.Country;
                array[3] = customer.Age;

                return array;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<object[]> ReadAll()
        {
            try
            {
                List<Customer> customers = (List<Customer>)customerContext.ReadAll();
                List<object[]> array = new List<object[]>(customers.Count);

                for (int i = 0; i < customers.Count; i++)
                {
                    object[] customer = new object[4];
                    customer[0] = customers[i].ID;
                    customer[1] = customers[i].Name;
                    customer[2] = customers[i].Country;
                    customer[3] = customers[i].Age;

                    array.Add(customer);
                }

                return array;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(object[] item)
        {
            try
            {
                int id = Convert.ToInt32(item[0]);
                string name = item[1].ToString();
                string country = item[2].ToString();
                int age = Convert.ToInt32(item[3]);

                Customer customeFromDB = customerContext.Read(id);
                customeFromDB.Name = name;
                customeFromDB.Country = country;
                customeFromDB.Age = age;

                customerContext.Update(customeFromDB);
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
                customerContext.Delete(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
