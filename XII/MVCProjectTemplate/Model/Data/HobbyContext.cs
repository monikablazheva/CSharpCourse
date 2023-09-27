using Microsoft.EntityFrameworkCore;
using Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class HobbyContext : IDb<Hobby, int>, IQueryDb<Hobby, int>
    {
        MVCDbContext context;

        public HobbyContext(MVCDbContext context)
        {
            this.context = context;
        }

        public async  Task CreateAsync(Hobby item)
        {
            try
            {
                context.Hobbies.Add(item);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Hobby> ReadAsync(int key)
        {
            try
            {
                return await context.Hobbies.Include(h => h.Users)
                    .FirstOrDefaultAsync(h => h.Id == key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Hobby>> ReadAllAsync()
        {
            try
            {
                return await context.Hobbies.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateAsync(Hobby item)
        {
            try
            {
                context.Update(item);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteAsync(int key)
        {
            try
            {
                Hobby hobby = await context.Hobbies.FindAsync(key);

                if (hobby == null)
                {
                    throw new ArgumentException("Hobby does not exist!");
                }

                context.Hobbies.Remove(hobby);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Exists(int key)
        {
            Hobby hobby = context.Hobbies.Find(key);
            if (hobby == null)
            {
                return false;
            }
            return true;

            // Any can throw exception!
            //return context.Hobbies.Any(h => h.Id == key);
        }

        // Wrapper used in HobbyToUser() in HobbiesController!
        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}
