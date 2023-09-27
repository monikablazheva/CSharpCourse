using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class ClientContext : IDB<Client, int>
    {
        private RestaurantDbContext _context;
        public ClientContext(RestaurantDbContext context)
        {
            _context = context;
        }
        public void Create(Client item)
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
                _context.Clients.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Client Read(int key)
        {
            try
            {
                return _context.Clients.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Client> ReadAll()
        {
            try
            {
                return _context.Clients.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Client item)
        {
            try
            {
                Client clientFromDB = Read(item.Id);

                _context.Entry(clientFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
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
                _context.Clients.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
