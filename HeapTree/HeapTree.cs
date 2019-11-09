using System;
using System.Collections.Generic;
using System.Text;

namespace HeapTree
{
    class HeapTree<T> where T : IComparable
    {
        // TODO:
        //   -Write insert
        //   -Write pop
        //   -Write HeapifyUp
        //   -Write HeapifyDown


        private T[] tree;

        public HeapTree()
        {

        }



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
