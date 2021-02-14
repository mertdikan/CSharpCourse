using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);

            Console.ReadLine();
            
        }
    }

    class MyList<T> //GENERİC CLASS
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];  //0 elemanlı bir array yapmış olduk
        }

          public void Add(T item)

        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
            
        }

        

        public int Count
        {
            get { return _array.Length; }  //saymasını sağladık
            
        }

    }
}
