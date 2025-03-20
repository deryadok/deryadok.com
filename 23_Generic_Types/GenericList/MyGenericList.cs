using System;
using System.Collections;
using System.Collections.Generic;

namespace _23_Generic_Types.GenericList
{
    internal class MyGenericList<T> : IEnumerable<T>
    {
        private T[] items;
        private static int capacity = 2;
        private int itemCount;

        public MyGenericList()
        {
            items = new T[capacity];
            itemCount = 0;
        }

        public void Add(T item)
        {
            if (itemCount == capacity)
            {
                capacity = capacity * 2;
                Resize();
            }
            items[itemCount] = item;
            itemCount++;
        }

        private void Resize()
        {
            Array.Resize(ref items, capacity);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= itemCount)
                {
                    throw new IndexOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index < 0 || index >= itemCount)
                {
                    throw new IndexOutOfRangeException();
                }

                items[index] = value;
            }
        }
    }
}
