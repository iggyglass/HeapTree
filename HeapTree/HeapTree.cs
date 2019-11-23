using System;

namespace HeapTree
{

    /// <summary>
    /// A Binary tree where all elements are stored in a
    /// singular array
    /// </summary>
    /// <typeparam name="T">The type of tree node</typeparam>
    public class HeapTree<T> where T : IComparable
    {
        // This is a min-heap implementation:

        // Left node = i * 2 + 1
        // Right node = i * 2 + 2
        // Parent node = (i - 1) / 2

        private T[] tree; // The tree
        private int tp = 0; // Points to end of tree in array

        public HeapTree(int maxHeap)
        {
            tree = new T[maxHeap];
        }

        #region Public Methods

        /// <summary>
        /// Inserts a value into Heap
        /// </summary>
        /// <param name="value">The value to insert</param>
        public void Insert(T value)
        {
            if (tp < tree.Length)
            {
                tree[tp] = value;
            }
            else
            {
                expand(1);
                tree[tp] = value;
            }

            heapifyUp(tp);
            tp++;
        }

        /// <summary>
        /// Removes root from Heap, and returns it
        /// </summary>
        /// <returns>The old root of the tree</returns>
        public T Pop()
        {
            T temp = tree[0];
            tree[0] = default;

            swap(0, tp - 1);
            tp--;

            heapifyDown(0);

            return temp;
        }

        /// <summary>
        /// Returns the tree in array form
        /// </summary>
        /// <returns>The tree</returns>
        public T[] GetTree()
        {
            return tree;
        }

        /// <summary>
        /// Returns true if the tree is empty
        /// </summary>
        /// <returns>If the tree is empty</returns>
        public bool IsEmpty()
        {
            return tp == 0;
        }

        #endregion
        #region Private Methods

        private void heapifyUp(int index)
        {
            if (index == 0) return; // Return if root

            int parent = getParent(index);

            if (tree[index].CompareTo(tree[parent]) < 0) // min heap
            {
                swap(index, parent);
                heapifyUp(parent);
            }
        }

        private void heapifyDown(int index)
        {
            int left = getLeft(index);
            int right = getRight(index);

            if (right < tp && tree[right].CompareTo(tree[left]) < 0) // right < left
            {
                if (tree[right].CompareTo(tree[index]) < 0) // right < this
                {
                    swap(right, index);
                    heapifyDown(right);
                }
            }
            else if (left < tp) // left < right
            {
                if (tree[left].CompareTo(tree[index]) < 0) // left < this
                {
                    swap(left, index);
                    heapifyDown(left);
                }
            }
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

        private void swap(int indexA, int indexB)
        {
            T temp = tree[indexA];
            tree[indexA] = tree[indexB];
            tree[indexB] = temp;
        }

        private int getRight(int index)
        {
            return (index * 2) + 2;
        }

        private int getLeft(int index)
        {
            return (index * 2) + 1;
        }

        private int getParent(int index)
        {
            return (index - 1) / 2;
        }

        #endregion
    }
}
