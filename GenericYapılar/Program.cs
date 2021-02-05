using System;
using System.Collections.Generic;

namespace GenericYapılar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> sehirler = new List<string>() { "1", "2", "2", };
            //sehirler.Add("4");
            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count); 

            Mylist<string> mylist = new Mylist<string>();
            Console.WriteLine(mylist.Count);
           
        }
    }

    public class Mylist<T> //generic class
    {
        T[] _array;
        T[] _tempArray;
        public Mylist()
        {
            _array = new T[0];
        }  
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
             
        }
        //private int _count { get; set; }
        public int Count
        { get
            {
             return _array.Length;
            }

        }

    }
}
