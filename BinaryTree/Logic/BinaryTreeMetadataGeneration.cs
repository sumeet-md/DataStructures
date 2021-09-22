using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Logic
{
    public static class BinaryTreeMetadataGeneration
    {
        public static int BinaryTreeHeight(BinarySearchTree tree)
        {
            if (tree == null || tree.Root == null)
                return 0;

            int heightLeft = BinaryTreeHeight(tree.Left);
            int heightRight = BinaryTreeHeight(tree.Right);

            if (heightLeft > heightRight)
                return heightLeft + 1;
            else
                return heightRight + 1;
        }
    }
}
