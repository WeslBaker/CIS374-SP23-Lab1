using DSA.DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Lab1
{
    //TODO
    class AVLTreeKeyValueMap<TKey, TValue>: IKeyValueMap<TKey, TValue>
    {
        private AVLTreeKeyValueMap<TKey, TValue> aVLTreeValueMap = new AVLTreeKeyValueMap<TKey, TValue>;

        public int Height => aVLTreeValueMap.Height;

        public int Count => aVLTreeValueMap.Count;

        public void Add(TKey key, TValue value)
        {
            aVLTreeValueMap.Add(key, value);
        }

        public void Clear()
        {
            aVLTreeValueMap.Clear();
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            TValue value = aVLTreeValueMap.Get(key);
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        public bool Remove(TKey key)
        {
            if (aVLTreeValueMap.Contains(key))
            {
                aVLTreeValueMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            };
        }
    }
}