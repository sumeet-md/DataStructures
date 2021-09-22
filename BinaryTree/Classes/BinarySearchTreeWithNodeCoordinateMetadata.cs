using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Classes
{
    public class BinarySearchTreeWithNodeCoordinateMetadata : BinarySearchTree
    {
        private int x; // X Coordinate
        private int y; // Y Coordinate

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
    }
}
