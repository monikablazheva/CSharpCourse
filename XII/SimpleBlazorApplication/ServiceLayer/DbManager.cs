using DataLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class DbManager<T, K>
    {
        IDb<T, K> context;

        public DbManager(IDb<T, K> context)
        {
            this.context = context;
        }

        public async Task CreateAsync(T item)
        {
            // Validation + Logging + Authorization + Authentication
            // + Error handling + Transformation from ViewModel to Model ...
            // Wrapper of Data Layer!
            await context.CreateAsync(item);
        }

        public async Task<T> ReadAsync(K key, bool useNavigationalProperties = false)
        {
            return await context.ReadAsync(key, useNavigationalProperties);
        }

        public async Task<List<T>> ReadAllAsync(bool useNavigationalProperties = false)
        {
            return await context.ReadAllAsync(useNavigationalProperties);
        }

        public async Task UpdateAsync(T item)
        {
            await context.UpdateAsync(item);
        }

        public async Task DeleteAsync(K key)
        {
            await context.DeleteAsync(key);
        }

    }
}
