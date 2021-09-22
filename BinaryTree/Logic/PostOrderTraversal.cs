using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class PostOrderTraversal
    {
        // Post-Order is Left node, then right node and then main node
        // Where used?
        public static List<int?> TraversePostOrder(BinarySearchTree tree)
        {
            List<int?> postOrderOutput = new List<int?>();

            if (tree == null)
            {
                // Do nothing as the list will be returned as is with no additions
            }

            postOrderOutput.AddRange(TraversePostOrderLogic(tree.Root.Value, tree.Left, tree.Right));

            return postOrderOutput;
        }

        // Recursion function
        private static List<int?> TraversePostOrderLogic(int? val, BinarySearchTree leftTree, BinarySearchTree rightTree)
        {
            List<int?> postOrderOutput = new List<int?>();

            // First handle left node
            if (leftTree != null)
            {
                postOrderOutput.AddRange(TraversePostOrderLogic(leftTree.Root.Value, leftTree.Left, leftTree.Right));
            }
            
            // Then handle the right node
            if(rightTree != null)
            {
                postOrderOutput.AddRange(TraversePostOrderLogic(rightTree.Root.Value, rightTree.Left, rightTree.Right));
            }

            // Lastly handle the root
            if (val != null) // as it is a nullable int
            {
                postOrderOutput.Add(val);
            }

            return postOrderOutput;
        }
    }
}
