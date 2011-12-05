using System;
using CS_binaryTree_CompositePattern.core;

namespace CS_binaryTree_CompositePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tree = BuildTree();
            var smallestPrime = tree.GetSmallestPrime(tree.Root);
            Console.WriteLine("Total: {0} ", tree.GetTotal(tree.Root));
            Console.WriteLine("Smallest Prime: {0} ", smallestPrime);
        }

        private static BinaryTree BuildTree() {
            var tree = new BinaryTree(new TreeNode(8));

            // Generate 10 random number

            // Test purpose
            tree.Add(new TreeNode(4));
            tree.Add(new TreeNode(4));
            tree.Add(new TreeNode(12));
            tree.Add(new TreeNode(50));
            tree.Add(new TreeNode(43));

            return tree;
        }
    }
}