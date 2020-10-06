using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int data;
        public Node rightNode;
        public Node leftNode; 

        public Node()
        { }
        public Node(int data)
        {
            this.data = data;
        }
    }
}
