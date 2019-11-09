using System;
using System.Collections.Generic;
using System.Text;

namespace HeapTree
{
    class HeapTree<T> where T : IComparable
    {

        private T[] tree;

        private void expand(int amount)
        {
            T[] newTree = new T[tree.Length + amount];

            for (int i = 0; i < tree.Length; i++)
            {
                newTree[i] = tree[i];
            }

            tree = newTree;
        }
    }
}
