using System;
using System.Collections.Generic;

namespace ServiceLayerV2
{
    public interface IContext<K>
    {
        void Create(object[] item);

        object[] Read(K key);

        IEnumerable<object[]> ReadAll();

        void Update(object[] item);

        void Delete(K key);
    }
}
