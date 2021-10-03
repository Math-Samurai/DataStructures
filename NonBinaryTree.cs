using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class NonBinaryTree<T>
    {
        NonBinaryTreeNode<T> root;
        public NonBinaryTree(T value)
        {
            root = new NonBinaryTreeNode<T>(value);
        }
    }
}
