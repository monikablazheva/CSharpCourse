using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class AirportContext : IDB<Airport, int>
    {
        private monikaairportContext _context;
        public AirportContext(monikaairportContext context)
        {
            _context = context;
        }
        public void Create(Airport item)
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
                _context.Airports.Add(item);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Airport Read(int key)
        {
            try
            {
                return _context.Airports.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Airport> ReadAll()
        {
            try
            {
                return _context.Airports.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Airport item)
        {
            try
            {
                Airport airportFromDB = Read(item.Id);

                _context.Entry(airportFromDB).CurrentValues.SetValues(item);
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
                _context.Airports.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
