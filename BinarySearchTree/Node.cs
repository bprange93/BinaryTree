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
        public int Data { get; set; }
        public Node RightNode { get; set; }
        public Node LeftNode { get; set; } 

        public Node()
        { }
        public Node(int data)
        {
            this.Data = data;
        }

        public string Search(int searchValue)
        {
            if (searchValue < Data && LeftNode != null)
            {
                return LeftNode.Search(searchValue);
            }
            else if(searchValue > Data && RightNode != null)
            {
                return RightNode.Search(searchValue);
            }

            return "";
        }
    }
}
