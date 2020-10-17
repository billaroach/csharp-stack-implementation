using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> st1 = new MyStack<int>();

            st1.Add(3);
            for (int i = 0; i < st1.GetCount(); i++)
            {
                Console.WriteLine(st1.Get(i).ToString());
            }
            Console.ReadLine();
            st1.Add(4);
            for (int i = 0; i < st1.GetCount(); i++)
            {
                Console.WriteLine(st1.Get(i).ToString());
            }
            Console.ReadLine();
            st1.Add(5);
            for (int i = 0; i < st1.GetCount(); i++)
            {
                Console.WriteLine(st1.Get(i).ToString());
            }
            Console.ReadLine();

            st1.Pop();
            st1.Pop();
            st1.Pop();
            st1.Pop();

            for (int i = 0; i < st1.GetCount(); i++)
            {
                Console.WriteLine(st1.Get(i).ToString());
            }

        }
    }
}
