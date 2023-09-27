﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDb<T, K>
    {
        Task CreateAsync(T item);

        Task<T> ReadAsync(K key, bool useNavigationalProperties = false);

        Task<List<T>> ReadAllAsync(bool useNavigationalProperties = false);

        Task UpdateAsync(T item);

        Task DeleteAsync(K key);
        
    }
}
