using HeapTree;
using HeapSort;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Insert()
        {
            HeapTree<int> tree = new HeapTree<int>(10);

            int[] expected = { 1, 3, 2, 6, 4, 5, 0, 0, 0, 0 }; 

            for (int i = 6; i > 0; i--)
            {
                tree.Insert(i);
            }

            Assert.Equal(expected, tree.GetTree());
        }

        [Fact]
        public void Pop()
        {
            HeapTree<int> tree = new HeapTree<int>(10);

            int[] expected = { 2, 3, 5, 6, 4, 0, 0, 0, 0, 0 };

            for (int i = 6; i > 0; i--)
            {
                tree.Insert(i);
            }

            int temp = tree.Pop();

            Assert.Equal(1, temp);

            Assert.Equal(expected, tree.GetTree());
        }

        [Fact]
        public void Sort()
        {
            int[] expected = { 1, 2, 3, 4, 5 };
            int[] val = { 3, 2, 4, 1, 5 };

            HeapSort<int> sort = new HeapSort<int>();
            val = sort.Sort(val);

            Assert.Equal(expected, val);
        }
    }
}
