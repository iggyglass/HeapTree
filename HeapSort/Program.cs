using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] val = { 3, 2, 4, 1, 5 };

            HeapSort<int> sort = new HeapSort<int>();
            val = sort.Sort(val);

            ;

            Console.ReadKey();
        }
    }
}
