using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Generic_Types.NonGenericList
{
    internal class MyNongenericList : IEnumerable
    {
        private object[] items;
        private static int capacity = 2;
        private int itemCount;

        public MyNongenericList()
        {
            items = new object[capacity];
            itemCount = 0;
        }

        public void Add(object obj)
        {
            if (itemCount == capacity)
            {
                capacity = capacity * 2;
                Resize();
            }
            items[itemCount] = obj;
            itemCount++;
        }

        private void Resize()
        {
            Array.Resize(ref items, capacity);
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public object this[int index]
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
