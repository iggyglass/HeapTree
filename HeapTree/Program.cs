using System;

namespace HeapTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            //   - Write Heap Sort

            HeapTree<int> tree = new HeapTree<int>(10);

            // insert should be:
            // 1 3 2 6 4 5

            for (int i = 6; i > 0; i--)
            {
                tree.Insert(i);
            }

            // pop should be:
            // 2 3 5 6 4

            int temp = tree.Pop();

            ;

            Console.ReadKey();
        }
    }
}
