using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using ServiceLayer;

namespace PresentationLayer
{
    public class ProductView
    {
        private ProductManager _productManager;

        public ProductView()
        {
            _productManager = new ProductManager(DBContextManager.CreateContext());
        }

        public ProductView(ProductManager productManager)
        {
            _productManager = productManager;
        }

        public void Create()
        {
            try
            {
                string barcode, name, brand;
                int quantity;
                decimal price;

                Console.Write("Barcode: ");
                barcode = Console.ReadLine();

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Brand: ");
                brand = Console.ReadLine();

                Console.Write("Quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Price: ");
                price = Convert.ToDecimal(Console.ReadLine());

                Product product = new Product(barcode, name, brand, quantity, price);
                _productManager.Create(product);

                Console.WriteLine("Product created successfully!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Product Read()
        {
            try
            {
                Console.Write("Enter barcode: ");
                string barcode = Console.ReadLine();

                Product product = _productManager.Read(barcode);

                if (product == null)
                {
                    throw new ArgumentException("Product with that barcode does not exist in the DB!");
                }

                Console.WriteLine("Name: {0}; Brand: {1}; Quantity: {2}; Price: {3}; Barcode: {4}",
                        product.Name, product.Brand, product.Quantity, product.Price, product.Barcode);

                return product;
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
                List<Product> products = (List<Product>)_productManager.ReadAll();

                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine("Product #{0}", i + 1);
                    Console.WriteLine("Barcode: {0}; Name: {1}; Brand: {2}; Quantity = {3}; Price = {4};",
                            products[i].Barcode, products[i].Name, products[i].Brand, products[i].Quantity, products[i].Price);
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
                Product product = Read();

                Console.Write("Write new name or choose enter to leave the current value: ");
                string name = Console.ReadLine();

                if (!string.IsNullOrEmpty(name))
                {
                    product.Name = name;
                }

                Console.Write("Write new brand or choose enter to leave the current value: ");
                string brand = Console.ReadLine();

                if (!string.IsNullOrEmpty(brand))
                {
                    product.Brand = brand;
                }

                Console.Write("Write new quantity or choose enter to leave the current value: ");
                string quantity = Console.ReadLine();

                if (!string.IsNullOrEmpty(quantity))
                {
                    product.Quantity = Convert.ToInt32(quantity);
                }

                Console.Write("Write new price or choose enter to leave the current value: ");
                string price = Console.ReadLine();

                if (!string.IsNullOrEmpty(price))
                {
                    product.Price = Convert.ToDecimal(price);
                }

                _productManager.Update(product);

                Console.WriteLine("Product updated successfully!");
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
                Product product = Read();

                _productManager.Delete(product.Barcode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
