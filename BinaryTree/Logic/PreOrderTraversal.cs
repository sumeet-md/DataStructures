using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class PreOrderTraversal
    {
        // Pre-Order is Node followed by Left Node followed by Right Node
        // Most useful in copying an entire tree and create an exact copy of it
        public static List<int?> TraversePreOrder(BinarySearchTree tree)
        {
            List<int?> preOrderOutput = new List<int?>();

            if (tree == null)
            {
                // Do nothing as the list will be returned as is with no additions
            }

            preOrderOutput.AddRange(TraversePreOrderLogic(tree.Root.Value, tree.Left, tree.Right));

            return preOrderOutput;
        }

        // Recursion function
        private static List<int?> TraversePreOrderLogic(int? val, BinarySearchTree leftTree, BinarySearchTree rightTree)
        {
            List<int?> preOrderOutput = new List<int?>();

            // First handle the Root itself
            if (val != null) // as it is a nullable int
            {
                preOrderOutput.Add(val);
            }

            // Then, handle left node
            if (leftTree != null)
            {
                preOrderOutput.AddRange(TraversePreOrderLogic(leftTree.Root.Value, leftTree.Left, leftTree.Right));
            }
            
            // Lastly take up the right side
            if(rightTree != null)
            {
                preOrderOutput.AddRange(TraversePreOrderLogic(rightTree.Root.Value, rightTree.Left, rightTree.Right));
            }

            return preOrderOutput;
        }
    }
}
