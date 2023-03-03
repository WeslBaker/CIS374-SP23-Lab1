using System.Collections.Generic;
using DSA.DataStructures.Trees;

namespace Lab1
{
    //TODO
    class RedBlackTreeKeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
    {
        private RedBlackTreeMap<TKey, TValue> RBTreeMap = new RedBlackTreeMap<TKey, TValue>();

        public int Height => RBTreeMap.Height;

        public int Count => RBTreeMap.Count;

        public void Add(TKey key, TValue value)
        {
            RBTreeMap.Add(key, value);
        }

        public void Clear()
        {
            RBTreeMap.Clear();
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            TValue value;
            RBTreeMap.TryGetValue(key, out value);
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        public bool Remove(TKey key)
        {
            if (RBTreeMap.ContainsKey(key))
            {
                RBTreeMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            };
        }
    }
}