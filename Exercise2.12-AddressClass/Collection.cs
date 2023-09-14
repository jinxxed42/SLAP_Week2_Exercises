using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._12_AddressClass
{
    internal class Collection<TKey> where TKey : class
    {

        private readonly Dictionary<TKey, IHasAddress> _myCollection;

        public Collection()
        {
            _myCollection = new();
        }

        public void AddElement(TKey key, IHasAddress value)
        {
            _myCollection.Add(key, value);
        }

        public IHasAddress GetElement(TKey key)
        {
            if (_myCollection.ContainsKey(key))
            {
                return _myCollection[key];
            }
            else return null!;
        }

        public int Size()
        {
            return _myCollection.Count;
        }
    }
}
