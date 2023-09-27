using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    // клас с абстракци, който отговаря за crud на животните
    public class AnimalContext<T> 
    {
        private AppDbContext _context;
        public AnimalContext(AppDbContext context)
        {
            this._context = context;
        }
        //клас за създаване на обект животно в базата данни
        public void Create(T item)
        {
            try
            {
                //проверява вида на обекта и го добавя към подходящата бд
                if (item is Lion)
                {
                    _context.Lions.Add(item as Lion);
                }
                if (item is Dolphin)
                {
                    _context.Dolphins.Add(item as Dolphin);
                }
                else if (item is Monkey)
                {
                    _context.Monkeys.Add(item as Monkey);
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //клас за изтриване на обект животно от базата данни
        public void Delete(int key,Type T)
        {
            try
            {
                Animal item = Read(key,T);
                //проверява вида на обекта и го премахва от подходящата бд
                if (item is Monkey)
                {
                    _context.Monkeys.Remove((Monkey)item);
                }
                 if (item is Lion)
                {
                    _context.Lions.Remove((Lion)item);
                }
                else if (item is Dolphin)
                {
                    _context.Dolphins.Remove((Dolphin)item);
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //клас за четене на обект животно от базата данни
        public Animal Read(int key,Type T)
        {
            try
            {
                IQueryable<Animal> query = null;
                //проверява вида на обекта 
                if (T == typeof(Lion))
                {
                query = _context.Lions;
                }
                if (T == typeof(Monkey))
                {
                query = _context.Monkeys;
                }
                else if (T == typeof(Dolphin))
                {
                    query = _context.Dolphins;
                }

                return query.SingleOrDefault(f => f.Id == key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //клас за четене на всияки обекти животно от базата данни
        public IEnumerable<T> ReadAll()
        {
            try
            {
                IQueryable<T> query=null;

                if (typeof(T) == typeof(Lion))
                {
                    query = _context.Lions as IQueryable<T>;
                }
                 if (typeof(T) == typeof(Monkey))
                {
                    query = _context.Monkeys as IQueryable<T>;
                }
                else if (typeof(T) == typeof(Dolphin))
                {
                    query = _context.Dolphins as IQueryable<T>;
                }
                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //клас за промяна на обект животно в базата данни
        public void Update(Animal item)
        {
            try
            {
                //проверява вида на обекта и го редактира в подходящата бд
                if (item is Monkey)
                {
                    Monkey monkeyFrom = (Monkey)Read(item.Id,typeof(Monkey));
                    _context.Entry(monkeyFrom).CurrentValues.SetValues(item);
                }
                if (item is Lion)
                {
                    Lion lionFrom = (Lion)Read(item.Id, typeof(Lion));
                    _context.Entry(lionFrom).CurrentValues.SetValues(item);
                }
                else if (item is Dolphin)
                {
                    Dolphin dolphinFrom = (Dolphin)Read(item.Id, typeof(Dolphin));
                    _context.Entry(dolphinFrom).CurrentValues.SetValues(item);
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
