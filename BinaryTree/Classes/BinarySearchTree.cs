using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree
    {
        private int? root;
        private BinarySearchTree left;
        private BinarySearchTree right;
        private int nodeHeight;

        public BinarySearchTree()
        { }

        public BinarySearchTree(int? root, BinarySearchTree left, BinarySearchTree right)
        {
            this.root = root;
            this.left = left;
            this.right = right;
        }

        public BinarySearchTree Add(int? root)
        {
            this.root = root;
            this.left = null;
            this.right = null;

            return this;
        }

        public int? Root
        {
            get { return this.root; }
            set { this.root = value; }
        }
        
        public BinarySearchTree Left 
        {
            get { return this.left; }
            set { this.left = value; } 
        }

        public BinarySearchTree Right 
        {
            get { return this.right; }
            set { this.right = value; }
        }

        public int NodeHeight
        {
            get { return this.nodeHeight; }
            set { this.nodeHeight = value; }
        }
    }
}
