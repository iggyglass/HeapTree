using HeapTree;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        // TODO:
        //   -Impliment functions then write tests

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

            for (int i = 6; i > 0; i--)
            {
                tree.Insert(i);
            }

            int temp = tree.Pop();

            Assert.Equal(1, temp);

            // todo: test if tree is correct
        }
    }
}
