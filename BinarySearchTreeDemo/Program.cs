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
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.InsertNode(30);
            binarySearchTree.InsertNode(70);
            binarySearchTree.DisplayMethod();
            Console.ReadLine();
        }
    }
}
