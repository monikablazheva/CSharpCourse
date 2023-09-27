using BusinessLayer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayerV2
{
    public class CustomerContext : IDB<Customer, int>
    {
        OnlineShopDBContext context;
        SqlConnection connection;

        public CustomerContext(OnlineShopDBContext context)
        {
            this.context = context;
            connection = new SqlConnection(context.connectionString);
        }

        public void Create(Customer item)
        {
            try
            {
                string query = "insert into Customers (name, country, age) values (@name, @country, @age)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("name", item.Name);
                command.Parameters.AddWithValue("country", item.Country);
                command.Parameters.AddWithValue("age", item.Age);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public Customer Read(int key)
        {
            try
            {
                /*
                SqlParameter id = new SqlParameter("id", key);

                IQueryable<Customer> query = context.Customers.FromSqlRaw("select * from Customers where id = @id", id);
                
                Customer customer = query.Single();
                 */

                string query = "select * from Customers where id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("id", key);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                Customer customer = null;

                while (reader.Read())
                {
                    
                    int id = Convert.ToInt32(reader["ID"]);
                    string name = reader["Name"].ToString();
                    string country = reader["Country"].ToString();
                    int age = Convert.ToInt32(reader["Age"]);
                    customer = new Customer(id, name, country, age); // (!)
                }

                return customer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public IEnumerable<Customer> ReadAll()
        {
            try
            {
                /*
                IQueryable<Customer> customers = context.Customers.FromSqlRaw("select * from Customers");

                return customers.ToList();
                */

                string query = "select * from Customers";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                List<Customer> customers = new List<Customer>();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string name = reader["Name"].ToString();
                    string country = reader["Country"].ToString();
                    int age = Convert.ToInt32(reader["Age"]);
                    Customer customer = new Customer(id, name, country, age);
                    customers.Add(customer);
                }

                return customers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public void Update(Customer item)
        {
            try
            {
                string query = "update Customers set name = @name, country = @country, age = @age where id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("id", item.ID);
                command.Parameters.AddWithValue("name", item.Name);
                command.Parameters.AddWithValue("country", item.Country);
                command.Parameters.AddWithValue("age", item.Age);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public void Delete(int key)
        {
            try
            {
                string query = "delete from Customers where id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("id", key);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
