using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class RestaurantContext : IDB<Restaurant, string>
    {
        private RestaurantDbContext _context;
        public RestaurantContext(RestaurantDbContext context)
        {
            _context = context;
        }
        public void Create(Restaurant item)
        {
            try
            {
                List<Booking> bookings = new List<Booking>();

                foreach (var b in item.bookings)
                {
                    Booking bookingFromDB = _context.Bookings.Find(b.Id);

                    if (bookingFromDB != null)
                    {
                        bookings.Add(bookingFromDB);
                    }
                    else
                    {
                        bookings.Add(b);
                    }
                }

                item.bookings = bookings;
                _context.Restaurants.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Restaurant Read(string key)
        {
            try
            {
                return _context.Restaurants.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Restaurant> ReadAll()
        {
            try
            {
                return _context.Restaurants.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Restaurant item)
        {
            try
            {
                Restaurant restaurantFromDB = Read(item.Name);

                _context.Entry(restaurantFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string key)
        {
            try
            {
                _context.Restaurants.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
