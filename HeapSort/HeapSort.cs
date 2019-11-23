using HeapTree;
using System;

namespace HeapSort
{
    public class HeapSort<T> where T : IComparable
    {

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
