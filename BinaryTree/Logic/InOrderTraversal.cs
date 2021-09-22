using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Logic
{
    public static class InOrderTraversal
    {
        // In-Order is Node followed by Left Node followed by Right Node
        // Where used?
        public static List<int?> TraverseInOrder(BinarySearchTree tree)
        {
            List<int?> inOrderOutput = new List<int?>();

            if (tree == null)
            {
                // Do nothing as the list will be returned as is with no additions
            }

            inOrderOutput.AddRange(TraverseInOrderLogic(tree.Root.Value, tree.Left, tree.Right));

            return inOrderOutput;
        }

        // Recursion function
        private static List<int?> TraverseInOrderLogic(int? val, BinarySearchTree leftTree, BinarySearchTree rightTree)
        {
            List<int?> inOrderOutput = new List<int?>();

            // First handle left node
            if (leftTree != null)
            {
                inOrderOutput.AddRange(TraverseInOrderLogic(leftTree.Root.Value, leftTree.Left, leftTree.Right));
            }

            // Now handle the Root itself
            if (val != null) // as it is a nullable int
            {
                inOrderOutput.Add(val);
            }

            // Lastly take up the right side
            if (rightTree != null)
            {
                inOrderOutput.AddRange(TraverseInOrderLogic(rightTree.Root.Value, rightTree.Left, rightTree.Right));
            }

            return inOrderOutput;
        }
    }
}
