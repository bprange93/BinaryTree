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
                if (value < after.Data)
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
                else
                {
                    return false;
                }
                Node newNode = new Node();
                newNode.Data = value;

                if (this.Root == null)
                    this.Root = newNode;
                else
                {
                    if (value < before.Data)
                        before.LeftNode = newNode;
                    else
                        before.RightNode = newNode;
                }
                
            }
            return true;

        }
        public string Search(int searchValue)
        {
            return this.Search(searchValue);
            
        }
        
        private string Search(int value, Node parent)
        {
            if(parent != null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                    return Search(value, parent.LeftNode);
                else
                    return Search(value, parent.RightNode);
            }
            return null;
        }
    }
}
