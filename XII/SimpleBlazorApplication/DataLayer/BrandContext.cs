using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BrandContext : IDb<Brand, int>
    {
        SimpleBlazorDbContext dbContext;

        public BrandContext(SimpleBlazorDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(Brand item)
        {
            try
            {
                dbContext.Brands.Add(item);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Brand> ReadAsync(int key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Brand> query = dbContext.Brands;

                if (useNavigationalProperties)
                {
                    query = query.Include(b => b.Products);
                }

                return await query.FirstOrDefaultAsync(b => b.Id == key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Brand>> ReadAllAsync(bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Brand> query = dbContext.Brands;

                if (useNavigationalProperties)
                {
                    query = query.Include(b => b.Products);
                }

                return await query.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // dbContext's life is singleton based on the current implementation in ContextGenerator class!
        // Call the methods with useNewContext = true to reset the context whenever you would like!
        // That's why we have to use Local and change the State before calling Update().
        // Using a View Model offers many benefits for performance and simplifying issues like this.
        // Source: https://stackoverflow.com/questions/70095949/the-instance-of-entity-type-cannot-be-tracked-because-another-instance-with-the
        public async Task UpdateAsync(Brand item)
        {
            Brand brandFromDb = dbContext.Brands.Local.FirstOrDefault(b => b.Id == item.Id);
            if (brandFromDb != null)
            {
                dbContext.Entry(brandFromDb).State = EntityState.Detached;
            }

            // Update navigational properties
            if (item.Products.Count != 0)
            {
                List<Product> products = new(item.Products.Count);

                foreach (Product p in item.Products)
                {
                    Product productFromDb = dbContext.Products.Local.FirstOrDefault(pr => pr.Barcode == p.Barcode);

                    if (productFromDb != null)
                    {
                        products.Add(productFromDb);
                    }
                    else
                    {
                        products.Add(p);
                        //dbContext.Attach(p);
                    }
                }

                item.Products = products;
            }

            dbContext.Update(item);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int key)
        {
            try
            {
                Brand brand = await ReadAsync(key);

                if (brand != null)
                {
                    dbContext.Brands.Remove(brand);
                    await dbContext.SaveChangesAsync();
                }
                else
                {
                    throw new ArgumentException("Brand with that Id does not exist!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
