using BinaryTree.Classes;
using BinaryTree.Logic;
using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initiation Code

            // Creating an array
            int?[] binarySearchTreeInput = null;

            // Input 1: Standard 
            binarySearchTreeInput = new int?[] { 12, 7, 3, 7, 14, 18 };
            // Input 2: Standard + 1 change
            //binarySearchTreeInput = new int?[] { 12, 7, 3, 8, 14, 18 };
            // Input 3: With negative number at root level
            //binarySearchTreeInput = new int?[] { -10, 9, 20, null, null, 15, 7 };

            Console.WriteLine("Input array : ");
            for(int i=0; i < binarySearchTreeInput.Length; i++)
            {
                if(binarySearchTreeInput[i] != null)
                    Console.Write(binarySearchTreeInput[i] + " ");
                else
                    Console.Write("Null" + " ");
            }

            // Create Binary Tree
            BinarySearchTree tree =  BinaryTreeCreation.CreateBinaryTree(binarySearchTreeInput);

            Console.WriteLine("\nPress any key to print the tree");
            Console.Read();

            #endregion Initiation Code

            #region Printing Binary Tree on Console - Work in Progress

            // Print the Binary Tree on the Console - First create a print friendly version using pre-order traversal and copy process
            BinarySearchTreeWithNodeCoordinateMetadata treePrint = new BinarySearchTreeWithNodeCoordinateMetadata();

            #endregion Printing Binary Tree on Console - Work in Progress

            #region Finding the Height of the Tree

            // Find the height of input Binary Tree
            int height = BinaryTreeMetadataGeneration.BinaryTreeHeight(tree);

            BinaryTreePrintingToConsole.Print(tree);

            #endregion Finding the Height of the Tree

            #region Traverse through the tree in PreOrder, InOrder and PostOrder methods

            Console.WriteLine("\n Press any key to traverse through the tree");
            Console.Read();

            // Pre-Order Traversal
            List<int?> outputPreOrder = PreOrderTraversal.TraversePreOrder(tree);
            // Printing PreOrder
            Console.WriteLine("\n");
            Console.WriteLine("PreOrder Traversal Result: ");
            foreach(int i in outputPreOrder)
            {
                Console.Write(i + " ");
            }

            // In-Order Traversal
            List<int?> outputInOrder = InOrderTraversal.TraverseInOrder(tree);
            // Printing InOrder
            Console.WriteLine("\n");
            Console.WriteLine("InOrder Traversal Result: ");
            foreach (int i in outputInOrder)
            {
                Console.Write(i + " ");
            }

            // Post-Order Traversal
            List<int?> outputPostOrder = PostOrderTraversal.TraversePostOrder(tree);
            // Printing PostOrder
            Console.WriteLine("\n");
            Console.WriteLine("PostOrder Traversal Result: ");
            foreach (int i in outputPostOrder)
            {
                Console.Write(i + " ");
            }

            #endregion Traverse through the tree in PreOrder, InOrder and PostOrder methods

            Console.WriteLine("\n");
            Console.WriteLine("Press any key to end program");
            Console.Read();

        }
    }
}
