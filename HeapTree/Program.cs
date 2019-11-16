using System;

namespace HeapTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Write tests in unit tests project 

            HeapTree<int> tree = new HeapTree<int>(10);

            // insert should be:
            // 1 3 2 6 4 5

            for (int i = 6; i > 0; i--)
            {
                tree.Insert(i);
            }

            // Pop not correct -- currently moves a "null" value into root

            int temp = tree.Pop();

            ;

            Console.ReadKey();
        }
    }
}
