using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;
using ServiceLayer;

namespace PresentationLayer
{
    public class OrderView
    {
        private OrderManager orderManager;
        private CustomerManager customerManager;
        private CustomerView customerView;
        private ProductManager productManager;
        private ProductView productView;
        private OrderProductQuantitiesManager opqManager;

        public OrderView()
        {
            orderManager = new OrderManager(DBContextManager.CreateContext());
            customerManager = new CustomerManager(DBContextManager.GetContext()); // Use the same context as OrderManager
            customerView = new CustomerView(customerManager);
            productManager = new ProductManager(DBContextManager.GetContext());
            productView = new ProductView(productManager);
            opqManager = new OrderProductQuantitiesManager(DBContextManager.GetContext());
        }

        public void Create()
        {
            try
            {
                Console.Write("Do you want to see all of the customers? [Y/y or leave blank] ");
                string seeData = Console.ReadLine();

                if (!string.IsNullOrEmpty(seeData))
                {
                    customerView.ReadAll();
                }

                int customerID;
                Console.Write(Environment.NewLine + "Enter customer id: ");
                customerID = Convert.ToInt32(Console.ReadLine());

                Customer customer = customerManager.Read(customerID);

                if (customer == null)
                {
                    throw new ArgumentException("Customer with that ID does Not exist in the DB!");
                }


                Console.Write("Do you want to see all of the products? [Y/y or leave blank] ");
                seeData = Console.ReadLine();

                if (!string.IsNullOrEmpty(seeData))
                {
                    productView.ReadAll();
                }

                string barcode; 
                int quantity;
                List<OrdersProductsQuantities> ordersProductsQuantities = new List<OrdersProductsQuantities>();
                do
                {
                    Console.WriteLine("Enter product barcode or nothing to stop adding products to the order!");
                    Console.Write("Barcode: ");
                    barcode = Console.ReadLine();

                    if (string.IsNullOrEmpty(barcode))
                    {
                        break;
                    }

                    Console.Write("Quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());

                    OrdersProductsQuantities opq = new OrdersProductsQuantities(barcode, quantity);
                    ordersProductsQuantities.Add(opq);

                } while (true);

                Order order = new Order(customer);

                orderManager.Create(order);
                orderManager.AddProductsToLastOrder(ordersProductsQuantities);
                orderManager.CalculateOrderPriceForLastOrder();

                Console.WriteLine("Order created successfully!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Order Read()
        {
            try
            {
                Console.Write("Enter order id: ");
                int orderID = Convert.ToInt32(Console.ReadLine());

                Order order = orderManager.Read(orderID);

                // No need to check with If for null because ThenInclude throws exception on empty object!

                Console.WriteLine("ID: {0}; Price: {1}; DateCreated: {2} ",
                    order.ID, order.Price, order.OrderDate);
                Console.WriteLine("Customer: {0}", order.Customer.Name);

                Console.WriteLine("Products Information: ");
                List<OrdersProductsQuantities> opqs = (List<OrdersProductsQuantities>)order.OPQ;
                for (int j = 0; j < opqs.Count; j++)
                {
                    Console.WriteLine("Name: {0}; Price: {1}; Quantity: {2}; Barcode = {3}", opqs[j].Product.Name, opqs[j].Product.Price, opqs[j].Quantity, opqs[j].Product.Barcode);
                }
                Console.WriteLine(Environment.NewLine);

                return order;
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
                List<Order> orders = (List<Order>)orderManager.ReadAll();

                for (int i = 0; i < orders.Count; i++)
                {
                    Console.WriteLine("Order #{0} Information:", i + 1);
                    Console.WriteLine("ID: {0}; Price: {1}; DateCreated: {2} ", 
                        orders[i].ID, orders[i].Price, orders[i].OrderDate);
                    Console.WriteLine("Customer: {0}", orders[i].Customer.Name);

                    Console.WriteLine("Products Information: ");
                    List<OrdersProductsQuantities> opqs = (List<OrdersProductsQuantities>)orders[i].OPQ;
                    for (int j = 0; j < opqs.Count; j++)
                    {
                        Console.WriteLine("Name: {0}; Price: {1}; Quantity: {2}; Barcode: {3}", opqs[j].Product.Name, opqs[j].Product.Price, opqs[j].Quantity, opqs[j].Product.Barcode);
                    }
                    Console.WriteLine(Environment.NewLine);
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
                Order order = Read();

                string inputData, barcode;
                int quantity;

                do
                {
                    Console.Write("Enter product's barcode you want to change or leave blank:");
                    barcode = Console.ReadLine();

                    if (string.IsNullOrEmpty(barcode))
                    {
                        break;
                    }

                    Console.Write("Enter y/Y/yes to change product's quantity or anything else to delete the product from the order!");
                    inputData = Console.ReadLine();

                    OrdersProductsQuantities opq = order.OPQ.Single(item => item.ProductBarcode == barcode);

                    if (inputData == "y" || inputData == "Y" || inputData == "yes")
                    {
                        Console.Write("Old quantity => {0}; Enter new quantity: ", opq.Quantity);
                        quantity = Convert.ToInt32(Console.ReadLine());

                        opq.Quantity = quantity;

                        orderManager.Update(order);
                    }
                    else
                    {
                        opqManager.Delete(new Dictionary<int, string>() { { order.ID, barcode } });
                    }

                    Console.WriteLine("Order updated successfully!");
                } while (true);
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
                Order order = Read();

                orderManager.Delete(order.ID);

                Console.WriteLine("Order deleted successfully!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
