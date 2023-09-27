using BusinessLayer;
using ServiceLayerV3;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayerV3
{
    public class CustomerView
    {
        private DBManager<Customer, int> manager;

        public CustomerView()
        {
            manager = new DBManager<Customer, int>(DBContextManager.CreateCustomerContext(DBContextManager.CreateContext()));
        }

        public CustomerView(DBManager<Customer, int> manager)
        {
            this.manager = manager;
        }

        public void Create()
        {
            try
            {
                string name, country;
                int age;

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Country: ");
                country = Console.ReadLine();

                Console.Write("Age: ");
                age = Convert.ToInt32(Console.ReadLine());

                // Validate data

                Customer customer = new Customer(name, country, age);

                manager.Create(customer);

                Console.WriteLine("Customer created successfully!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customer Read()
        {
            try
            {
                Console.Write("Enter customer id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Customer customer = manager.Read(id);

                if (customer == null)
                {
                    throw new ArgumentException("Customer with that id does not exist in the DB!");
                }

                Console.WriteLine("Name: {0}; Age: {1}; Country: {2}; ID: {3}", customer.Name,
                    customer.Age, customer.Country, customer.ID);

                return customer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ReadAll()
        {
            try
            {
                List<Customer> customers = (List<Customer>)manager.ReadAll();

                for (int i = 0; i < customers.Count; i++)
                {
                    Console.WriteLine("Customer #{0} Info", i + 1);
                    Console.WriteLine("Name: {0}; Age: {1}; Country: {2}; ID: {3}", customers[i].Name,
                    customers[i].Age, customers[i].Country, customers[i].ID);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update()
        {
            try
            {
                Customer customer = Read();

                Console.Write("Write new name or choose enter to leave the current value: ");
                string newName = Console.ReadLine();

                if (!string.IsNullOrEmpty(newName))
                {
                    customer.Name = newName;
                }

                Console.Write("Write new age or choose enter to leave the current value: ");
                string ageString = Console.ReadLine();

                if (!string.IsNullOrEmpty(ageString))
                {
                    customer.Age = Convert.ToInt32(ageString);
                }

                Console.Write("Write new country name or choose enter to leave the current value: ");
                string newCountryName = Console.ReadLine();

                if (!string.IsNullOrEmpty(newCountryName))
                {
                    customer.Country = newCountryName;
                }

                manager.Update(customer);

                Console.WriteLine("Customer updated successfully!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete()
        {
            try
            {
                Customer customer = Read();

                manager.Delete(customer.ID);

                Console.WriteLine("Customer deleted successfully!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
