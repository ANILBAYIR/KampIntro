using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOdev
{
    class MyDictionary<TKey, TVal>
    {
        TKey[] keys;
        TVal[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TVal[0];
        }

        public void Add(TKey key,TVal value)
        {
            TKey[] tempArrayK = keys;
            keys = new TKey[keys.Length + 1];

            TVal[] tempArrayV = values;
            values = new TVal[values.Length + 1];

            for (int i = 0; i < tempArrayK.Length; i++)
            {
                keys[i] = tempArrayK[i];
            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempArrayV.Length; i++)
            {
                values[i] = tempArrayV[i];
            }
            values[values.Length - 1] = value;

            Console.WriteLine("Id: " + key + " " + "İsim: " + value );
        }

    }
}
