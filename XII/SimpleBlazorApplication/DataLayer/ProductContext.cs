using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductContext : IDb<Product, string>
    {
        SimpleBlazorDbContext dbContext;

        public ProductContext(SimpleBlazorDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(Product item)
        {
            try
            {
                Brand brand = dbContext.Brands.Find(item.BrandId);
                if (brand != null)
                {
                    item.Brand = brand;
                }

                dbContext.Products.Add(item);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Product> ReadAsync(string key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Product> query = dbContext.Products;

                if (useNavigationalProperties)
                {
                    query = query.Include(p => p.Brand);
                }

                return await query.FirstOrDefaultAsync(p => p.Barcode == key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Product>> ReadAllAsync(bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Product> query = dbContext.Products;

                if (useNavigationalProperties)
                {
                    query = query.Include(p => p.Brand);
                }

                return await query.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdateAsync(Product item)
        {
            try
            {
                Product productFromDb = await dbContext.Products.FindAsync(item.Barcode);

                if (productFromDb != null)
                {
                    dbContext.Entry(productFromDb).CurrentValues.SetValues(item);

                    /*
                    Brand brandFromDb = await dbContext.Brands.FindAsync(item.BrandId);

                    if (brandFromDb != null)
                    {
                        productFromDb.Brand = brandFromDb;
                    }
                    else
                    {
                        productFromDb.Brand = item.Brand;
                    }
                    */
                    await dbContext.SaveChangesAsync();
                }
                else
                {
                    await CreateAsync(item);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteAsync(string key)
        {
            try
            {
                Product product = await ReadAsync(key);

                if (product != null)
                {
                    dbContext.Products.Remove(product);
                    await dbContext.SaveChangesAsync();
                }
                else
                {
                    throw new ArgumentException("Product with that Barcode does not exist!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
