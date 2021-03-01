using System;
using System.Collections.Generic;

namespace graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vertex<int>> list = new List<Vertex<int>>();
            Graph<int> graph = new Graph<int>();
            Vertex<int> test = graph.AddVertex(17);
            Vertex<int> test2 = graph.AddVertex(2);
            graph.AddUndirectedEge(test, test2);
            Vertex<int> test3 = graph.AddVertex(15);
            graph.AddUndirectedEge(test, test3);
            Vertex<int> test4 = graph.AddVertex(31);
            graph.AddUndirectedEge(test3, test4);
            graph.GetNodes(test, list);

            foreach(var n in list)
            {
                Console.Write(n.Value + " ");
            }
            Console.WriteLine(graph.GetSize());
        }
    }
}
