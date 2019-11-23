using HeapTree;
using System;

namespace PriorityQueue
{

    /// <summary>
    /// A queue where nodes with a lesser value are dequeued prior
    /// to nodes with a greater value
    /// </summary>
    /// <typeparam name="T">The type of node</typeparam>
    public class PriorityQueue<T> where T : IComparable
    {

        private HeapTree<T> tree;

        public PriorityQueue(int maxSize)
        {
            tree = new HeapTree<T>(maxSize);
        }

        #region Public Methods

        /// <summary>
        /// Enqueues a value into queue
        /// </summary>
        /// <param name="val">The value to enqueue</param>
        public void Enqueue(T val)
        {
            tree.Insert(val);
        }

        /// <summary>
        /// Dequeues a value from queue
        /// </summary>
        /// <returns>The value that was dequeued</returns>
        public T Dequeue()
        {
            return tree.Pop();
        }

        #endregion
    }
}
