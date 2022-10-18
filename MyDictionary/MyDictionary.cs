using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<K , V>
    {
        K[] _key;
        V[] _value;

        public MyDictionary()
        {
            _key = new K[0];
            _value = new V[0];
        }

        public void Add(K key,V value)
        {
            K[] tempKey = _key;
            _key=new K[_key.Length+1];
            V[] tempValue= _value;
            _value=new V[tempKey.Length+1];

            for(int i = 0; i < tempKey.Length; i++)
            {
                _key[i]=tempKey[i];
                _value[i]=tempValue[i];
            }
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }

        public int Count { get { return _key.Length; } }

        public void DictionaryList()
        {
            for(int i = 0; i < Count; i++)
            {
                Console.WriteLine("Key: " + _key[i]);
                Console.WriteLine("Value: " + _value[i]);
            }
        }

    }
}
