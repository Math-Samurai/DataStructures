using System.Collections.Generic;

namespace DataStructures
{
    class NonBinaryTreeNode<T>
    {
        T value;
        List<T> branches;
        public NonBinaryTreeNode(T value)
        {
            this.value = value;
            branches = new List<T>();
        }
    }
}
