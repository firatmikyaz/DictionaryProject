using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryProject
{
    class MyDictionary<TKey,TValue>
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
            TKey[] tempKey = keys;
            TValue[] TempValue = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }
            for (int i = 0; i < TempValue.Length; i++)
            {
                values[i] = TempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
            Console.Write(keys[keys.Length - 1] + " numaralı ");
            Console.WriteLine(values[values.Length - 1] + " isminde öğrenci eklendi.");
        }
    }
}
