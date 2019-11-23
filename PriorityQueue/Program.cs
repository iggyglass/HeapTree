using System;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            //   - Write Unit Tests

            PriorityQueue<int> queue = new PriorityQueue<int>(5);
            int[] output = new int[5];

            // 5 4 3 2 1
            for (int i = 5; i > 0; i--)
            {
                queue.Enqueue(i);
            }

            // 1 2 3 4 5
            for (int i = 0; i < 5; i++)
            {
                output[i] = queue.Dequeue();
            }

            ;

            Console.ReadKey();
        }
    }
}
