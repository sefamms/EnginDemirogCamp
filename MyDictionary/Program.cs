using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class MyDictionary<K, V>
    {
        K[] key;  //boş dizi oluştur
        K[] tempKey; //geçiçi boş bir dizi oluştur

        V[] value;
        V[] tempValue;

        public MyDictionary()
        {
            key = new K[0];  //Program başladığından new le ve içerisinde 0 eleman olsun
            value = new V[0];
        }


        public void Add(K keyItem, V valueItem)
        {
            tempKey = key;

            key = new K[key.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
            }

            key[key.Length - 1] = keyItem;



            tempValue = value;

            value = new V[value.Length + 1];

            for (int i = 0; i < tempValue.Length; i++)
            {
                value[i] = tempValue[i];
            }

            value[value.Length - 1] = valueItem;


        }

        public K[] Key { get { return key; } }

        public V[] Value { get { return value; } }

    }
}
