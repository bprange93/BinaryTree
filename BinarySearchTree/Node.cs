using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public Node right;
        public Node left;

        public Node(int data)
        {
            this.data = data;
            
        }
    }
}
