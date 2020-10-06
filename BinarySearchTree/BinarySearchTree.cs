using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        //member variable
        public Node root;

        //constructor
        public BinarySearchTree()
        {
            root = null;
        }

        //member method
        public void Add(int valueToInsert)
        {
            Node insertNode = new Node(valueToInsert);
            if(root == null)
            {
                root = insertNode;
            }
            else
            {
                Node currentNode = root;
            }
            currentNode.next = insertNode;
        }
        public void Search()
        {

        }
    }
}
