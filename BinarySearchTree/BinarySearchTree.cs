using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree : Node
    {
        //member variable
        public Node root { get; set;  }

        //constructor
        public BinarySearchTree()
        {
            root = null;
        }

        //member method
        public bool Add(int value)
        {
            Node before = null, after = this.root;
            
            while(after != null)
            {
                before = after;
                if (value < after.data)
                    after = after.leftNode;
                else if (value > after.data)
                    after = after.rightNode;
                else
                {
                    return false;
                }
                Node newNode = new Node();
                newNode.data = value;

                if (this.root == null)
                    this.root = newNode;
                else
                {
                    if (value < before.data)
                        before.leftNode = newNode;
                    else
                        before.rightNode = newNode;
                }
                
            }
            return true;

        }
        public Node Search(int value)
        {
            return value(this.root);
        }
    }
}
