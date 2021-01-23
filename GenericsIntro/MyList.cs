using System;
using System.Collections.Generic;
using System.Text;


// T = type demek

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //contructor
        public MyList() //class ı new dediğimizde bu otomatik çalışıyor
        {
            items = new T[0];

        }
        public void Add(T item) //ben san ne dersem istediğim şeyin türü o olacak.
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
