using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binaryTree = new BinarySearchTree(50);

            binaryTree.Add(70);
            binaryTree.Add(40);
            binaryTree.Add(60);

            //Node node = binaryTree.Search(50);
            

            //Console.WriteLine(binaryTree.root);
            Console.WriteLine();
            Console.ReadLine();
        }

       
    }
}
