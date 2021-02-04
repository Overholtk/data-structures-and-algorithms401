using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree : BinaryTree
    {
        /// <summary>
        /// Adds a new node to a tree
        /// </summary>
        /// <param name="node">The node the value is being added to, nullable</param>
        /// <param name="value">the value to be assigned to the node</param>
        /// <param name="tree">the tree being used</param>
        public static void Add(Node node, int value, BinaryTree tree)
        {
            Node newNode = new Node(value);

            if(tree.Root == null)
            {
                tree.Root = newNode;
                return;
            }
            if (newNode.Value < node.Value)
            {
                if (node.Left == null) { node.Left = newNode; }
                else { Add(node.Left, value, tree); }
            }
            else if (newNode.Value > node.Value)
            {
                if (node.Right == null) { node.Right = newNode; }
                else{ Add(node.Right, value, tree); }
            }
        }

        /// <summary>
        /// Iterates through a tree to see if it contains a certain value
        /// </summary>
        /// <param name="value">the value to be searched for</param>
        /// <param name="node">the starting node (should be root)</param>
        /// <returns>true/false if the value is found</returns>
        public static bool Contains(int value, Node node)
        {
            bool doesContain = false;
            if(node.Value > value) { Contains(value, node.Right); }
            if(node.Value < value) { Contains(value, node.Left); }
            else { doesContain = true; }
            return doesContain;
        }
    }
}
