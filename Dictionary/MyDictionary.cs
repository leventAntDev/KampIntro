using System;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key,TValue value)
        {
            TKey[] tempkeys = keys;
            TValue[] tempvalue = values;
            
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
                values[i] = tempvalue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int Length
        {
            get { return keys.Length; }
        }
        public void Items()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] +" , "+ values[i]);
            }
            
        }

    }
}
