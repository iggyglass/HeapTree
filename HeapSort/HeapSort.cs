using HeapTree;
using System;

namespace HeapSort
{

    /// <summary>
    /// Sorts elements from least to greatest using a 
    /// heap tree
    /// </summary>
    /// <typeparam name="T">The type of value to be sorted</typeparam>
    public class HeapSort<T> where T : IComparable
    {

        /// <summary>
        /// Sorts array
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        /// <returns>The sorted array</returns>
        public T[] Sort(T[] arr)
        {
            // Sort is done by continuing to pop value into new array
            HeapTree<T> tree = new HeapTree<T>(arr.Length);
            T[] ret = new T[arr.Length];
            int ap = 0;
            
            // I need to insert into tree
            for (int i = 0; i < arr.Length; i++)
            {
                tree.Insert(arr[i]);
            }

            while (!tree.IsEmpty())
            {
                ret[ap] = tree.Pop();
                ap++;
            }

            return ret;
        }
    }
}
