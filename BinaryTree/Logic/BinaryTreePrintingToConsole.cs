using BinaryTree.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Logic
{
    public static class BinaryTreePrintingToConsole
    {
        public static void Print(BinarySearchTree tree)
        {
            if (tree == null)
            {
                // Do nothing as the list will be returned as is with no additions
                Console.WriteLine("There are no nodes in the tree to print");
            }

            // Find the height of input Binary Tree
            int height = BinaryTreeMetadataGeneration.BinaryTreeHeight(tree);

            // Find the total width of the tree for printing
            int totalWidth = (int)Math.Pow(2, height);

            PrintBinaryTree(tree, totalWidth, totalWidth, height);
        }

        public static StringBuilder PrintBinaryTree(BinarySearchTree tree, int totalWidth, int width, int height)
        {
            if (tree == null)
            {
                // Nothing to print
                return null;
            }
            else

            // At each tree (read node) level, width would be the total width under it
            if (width % 2 != 0) // Odd number
                width = width + 1;

            StringBuilder sb = new StringBuilder((width/2) + 1);
            StringBuilder sbChildren = new StringBuilder((width / 2) + 1);

            // Go through its immediate left node
            // But give it half the width of the total root level width
            sbChildren.Append(PrintBinaryTree(tree.Left, totalWidth, width / 2, height));

            // Go through its immediate right node
            // But give it half the width of the total root level width
            sbChildren.Append(PrintBinaryTree(tree.Right, totalWidth, totalWidth - width / 2, height));

            // Add initial spaces
            for (int i = 0; i <= width / 2; i++)
            {
                sb.Append(" ");
            }
            // Add the actual value
            sb.Append(tree.Root.Value);

            //for(int j=0; j < height; j++)
            Console.WriteLine(sbChildren);
            Console.WriteLine(sb);

            height--;

            return sb;
        }
    }
}
