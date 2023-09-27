using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class FlightContext : IDB<Flight, int>
    {
        private monikaairportContext _context;
        public FlightContext(monikaairportContext context)
        {
            _context = context;
        }
        public void Create(Flight item)
        {
            try
            {
                List<Booking> bookings = new List<Booking>();

                foreach (var b in item.Bookings)
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

                item.Bookings = bookings;
                _context.Flights.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Flight Read(int key)
        {
            try
            {
                return _context.Flights.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Flight> ReadAll()
        {
            try
            {
                return _context.Flights.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Flight item)
        {
            try
            {
                Flight flightFromDB = Read(item.Id);

                _context.Entry(flightFromDB).CurrentValues.SetValues(item);
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
                _context.Flights.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
