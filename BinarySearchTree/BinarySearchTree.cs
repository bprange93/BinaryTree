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
        Node Root;

        //constructor
        public BinarySearchTree(int data)
        {
            Root = new Node(data);
        }

        //member method
        public bool Add(int value)
        {
            Node after = this.Root;
            
            while(after != null)
            {
                Node before = after;
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

                if (this.Root == null)
                    this.Root = newNode;
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
        //public Node Search(int value)
        //{
        //    return this.Search(value, this.root);
        //}
        public Node Search(int value, Node parent)
        {
            if(parent != null)
            {
                if (value == parent.data) return parent;
                if (value < parent.data)
                    return Search(value, parent.leftNode);
                else
                    return Search(value, parent.rightNode);
            }
            return null;
        }
    }
}
