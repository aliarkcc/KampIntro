using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary<K,V>
    {
        K[] _key;
        V[] _value;
        public Dictionary()
        {
            _key = new K[0];
            _value = new V[0];
        }
        public void Add(K key,V value)
        {
            K[] _tempKey = _key;
            V[] _tempValue = _value;

            _key = new K[_key.Length + 1];
            _value = new V[_value.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value; 
        }
        public int Lenght
        {
            get { return _key.Length; }
        }
    }
}
