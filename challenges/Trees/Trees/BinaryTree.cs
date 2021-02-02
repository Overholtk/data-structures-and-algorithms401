using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinaryTree
    {
        public Node Root { get; set; }


        /// <summary>
        /// Orders all values in a given tree starting with the root and then moving to the left subtree and then the right
        /// </summary>
        /// <param name="node">The starting node(should always be the root)</param>
        /// <param name="values">The list to hold the values in</param>
        /// <returns>Returns the values list</returns>
        public static List<int> PreOrder(Node node, List<int> values)
        {
            values.Add(node.Value);
            if(node.Left != null) { PreOrder(node.Left, values); }
            if(node.Right != null) { PreOrder(node.Right, values); }
            return values;
        }

        /// <summary>
        /// Orders all the values in a given tree starting with the left subtree, then the root, then the right subtree
        /// </summary>
        /// <param name="node">Tree's root</param>
        /// <param name="values">List of values</param>
        /// <returns>values list</returns>
        public static List<int> InOrder(Node node, List<int> values)
        {
            if(node.Left != null) { InOrder(node.Left, values); }
            values.Add(node.Value);
            if(node.Right != null) { InOrder(node.Right, values); }
            return values;
        }

        /// <summary>
        /// Orders all values in a given tree starting with the left subtree, then the right, then the root.
        /// </summary>
        /// <param name="node">Tree's root</param>
        /// <param name="values">List of values</param>
        /// <returns>values list</returns>
        public static List<int> PostOrder(Node node, List<int> values)
        {
            if(node.Left != null) { PostOrder(node.Left, values); }
            if(node.Right != null) { PostOrder(node.Right, values); }
            values.Add(node.Value);
            return values;
        }
    }
}
