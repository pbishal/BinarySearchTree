using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Binary Search Tree");
            Console.WriteLine("Inserted nodes are : ");

            //Inserting nodes into binary search tree.
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.InsertNode(30);
            bst.InsertNode(70);
            bst.InsertNode(22);
            bst.InsertNode(40);
            bst.InsertNode(60);
            bst.InsertNode(95);
            bst.InsertNode(11);
            bst.InsertNode(65);
            bst.InsertNode(3);
            bst.InsertNode(16);
            bst.InsertNode(63);
            bst.InsertNode(67);

            bst.DisplayMethod();
            bst.getSizeOfTree();
            Console.ReadLine();
        }
    }
}
