using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeNameSpace
{
    public class BinarySearchTree<K> where K : IComparable
    {
        public BinarySearchTreeNode<K> Root;

        public void AddNode(K Key)
        {
            Root = AddRecursively(Root, Key);
        }

        public K GetRoot{ get { return Root.Key; } }
        private BinarySearchTreeNode<K> AddRecursively(BinarySearchTreeNode<K> Current, K Key)
        {
            if (Current == null)
                return new BinarySearchTreeNode<K>(Key);
            int CompareResult = Key.CompareTo(Current.Key);
            if (CompareResult == 0)
                return Current;
            if (CompareResult < 0)
                Current.Left = AddRecursively(Current.Left, Key);
            else
                Current.Right = AddRecursively(Current.Right, Key);
            return Current;
        }
    }
}
