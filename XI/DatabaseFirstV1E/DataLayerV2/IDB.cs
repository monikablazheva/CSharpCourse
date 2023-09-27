﻿using System;
using System.Collections.Generic;

namespace DataLayerV2
{
    public interface IDB<T, K>
    {
        void Create(T item);

        T Read(K key);

        IEnumerable<T> ReadAll();

        void Update(T item);

        void Delete(K key);

    }
}
