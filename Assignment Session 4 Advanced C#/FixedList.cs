using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session_4_Advanced_C_
{
    internal class FixedList<T>
    {
        private T[] items; 
        private int count = 0; 

        public int Capacity { get; }
        public int Count => count; 

        public FixedList(int capacity)
        {
            if (capacity <= 0)
                Console.WriteLine("Capacity must be > 0  .");

            Capacity = capacity;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count >= Capacity)
                Console.WriteLine("List is full ");

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                Console.WriteLine("Invalid index ");

            return items[index];
        }
    }
}
