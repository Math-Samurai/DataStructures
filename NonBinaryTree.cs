using System.Collections.Generic;

namespace DataStructures
{
    class NonBinaryTree<T>
    {
        T value;
        List<NonBinaryTree<T>> branches;
        public NonBinaryTree(T rootValue)
        {
            value = rootValue;
            branches = new List<NonBinaryTree<T>>();
        }
        public void Add(T newValue)
        {
            NonBinaryTree<T> newBranch = new NonBinaryTree<T>(newValue);
            branches.Add(newBranch);
        }
        public List<NonBinaryTree<T>> Branches
        {
            get
            {
                return branches;
            }
        }
    }
}
