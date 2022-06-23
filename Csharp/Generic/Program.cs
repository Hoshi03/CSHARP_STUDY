using System;

namespace Generic
{
    class Program
    {

        class Mylist<T>
        {
            T[] arr = new T[10];
        }

        static void Test<T>(T input)
        {
            Console.WriteLine(input);
        }


        static void Main(string[] args)
        {
            Mylist<int> a = new Mylist<int>();
            Mylist<int> b = new Mylist<int>();
            Test<int>(3/2);
            Test<float>(3.141592f/2);
            Test<double>(3.141592/2);

        }
    }
}
