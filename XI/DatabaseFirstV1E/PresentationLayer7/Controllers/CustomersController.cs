using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer7.Controllers
{
    public class CustomersController : Controller
    {
        private CustomerContext context;

        public CustomersController()
        {
            context = new CustomerContext(new OnlineShopDBContext());
        }

        // GET: CustomersController
        public ActionResult Index()
        {
            try
            {
                IEnumerable<Customer> customers = context.ReadAll();
                return View(customers);
            }
            catch (Exception ex)
            {
                throw ex;
            }    
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                Customer customer = context.Read(id);
                return View(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                string name = collection["Name"];
                string country = collection["Country"];
                int age = Convert.ToInt32(collection["Age"]);

                Customer customer = new Customer(name, country, age);
                context.Create(customer);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                Customer customer = context.Read(id);
                return View(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                Customer customer = context.Read(id);

                customer.Name = collection["Name"];
                customer.Country = collection["Country"];
                customer.Age = Convert.ToInt32(collection["Age"]);

                context.Update(customer);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                Customer customer = context.Read(id);
                return View(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                context.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
