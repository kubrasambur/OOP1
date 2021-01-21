using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//referansı geçici olarak emanet ettik
            items = new T[items.Length + 1];//eleman sayısını 1 arttırdık
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//emanet ettik
            }
            items[items.Length - 1] = item;//istediğimiz eleman şu an eklendi
        }
    }
}
