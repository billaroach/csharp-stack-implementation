using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class MyStack<T>
    {   
        // число элементов в стеке
        private int count;
        //первый элемент стека
        private Item<T> _head;

        public MyStack()
        {
            count = 0;
        }

        public int GetCount()
        {
            return count;
        }

        public void Add(T value)
        {

            var item = new Item<T>(value);

            if(count == 0)
            {
                _head = item;
            }

            else
            {
                item.Next = _head;
                _head = item;
            }

            count++;
        }

        public T Get(int index)
        {
            Item<T> current = _head;
            Item<T> getting = null;

            for (int i = 0;i < count;i++)
            {   
                if(i == index)
                {
                    getting = current; 
                }
                current = current.Next;
            }

            return getting.Data;
        }

        public bool Pop()
        {   
            if(isEmpty())
            {
                return false;
            }

            else
            {
                _head = _head.Next;
                count--;
                return true;
            }
            
        }

        public bool isEmpty()
        {
            if (_head == null)
            {
                return true;
            }

            else
                return false;
        }
    }
}
