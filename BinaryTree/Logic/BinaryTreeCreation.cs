using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class BinaryTreeCreation
    {
        public static BinarySearchTree CreateBinaryTree(int?[] binarySearchTreeInput)
        {
            // Create a Binary Search Tree
            BinarySearchTree tree = new BinarySearchTree();
            // Set height to 1
            int height = 1;

            for(int i=0; i< binarySearchTreeInput.Length; i++)
            {
                tree = CreateBinaryTreeFunc(tree, binarySearchTreeInput[i]);
            }

            return tree;
        }

        private static BinarySearchTree CreateBinaryTreeFunc(BinarySearchTree tree, int? val)
        {
            // Check if Root is null or has a value assigned already            
            if(tree == null || tree.Root == null )
            {
                // Create a tree with a root
                tree = new BinarySearchTree(val, null, null);
                // Set height to 1
                //int height
            }
            else
            {
                if(val == null)
                {
                    // Skip & do nothing
                    return tree;
                }
                // Traverse the tree to identify how the tree should grow
                if (val < tree.Root.Value) // Need to place the lower value to the left
                {
                    tree.Left = CreateBinaryTreeFunc(tree.Left, val);
                }
                else if (val >= tree.Root.Value) // Need to place the higher value to the right
                {
                    tree.Right = CreateBinaryTreeFunc(tree.Right, val);
                }
            }
            return tree;
        }

        private static BinarySearchTree CreateBinaryTreeFunc(BinarySearchTree tree, int? val, int height)
        {
            // Check if Root is null or has a value assigned already            
            if (tree == null || tree.Root == null)
            {
                // Create a tree with a root
                tree = new BinarySearchTree(val, null, null);
            }
            else
            {
                if (val == null)
                {
                    // Skip & do nothing
                    return tree;
                }
                else
                {
                    // Root has height = 1 and then it increments each time a node is added
                    height++; 
                }
                // Traverse the tree to identify how the tree should grow
                if (val < tree.Root.Value) // Need to place the lower value to the left
                {
                    tree.Left = CreateBinaryTreeFunc(tree.Left, val, height);
                }
                else if (val >= tree.Root.Value) // Need to place the higher value to the right
                {
                    tree.Right = CreateBinaryTreeFunc(tree.Right, val, height);
                }
            }
            return tree;
        }
    }
}
