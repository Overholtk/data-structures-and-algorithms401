using graphs;
using System;
using System.Collections.Generic;
using Xunit;

namespace graphtests
{
    public class UnitTest1
    {
        [Fact]
        public void AddVertex()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddVertex(17);

            Assert.Equal(1, graph.GetSize());
        }

        [Fact]
        public void AddEdge()
        {
            Graph<int> graph = new Graph<int>();
            Vertex<int> test = graph.AddVertex(17);
            Vertex<int> test2 = graph.AddVertex(2);
            graph.AddUndirectedEge(test, test2);

            Assert.Single(graph.GetNeighbors(test));
        }

        [Fact]
        public void GetAllNodes()
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
            List<Vertex<int>> list2 = new List<Vertex<int>>();
            list2.Add(test);
            list2.Add(test2);
            list2.Add(test3);
            list2.Add(test4);

            Assert.Equal(list2, list);
        }

        [Fact]
        public void GetNeighbors()
        {
            Graph<int> graph = new Graph<int>();
            Vertex<int> test = graph.AddVertex(17);
            Vertex<int> test2 = graph.AddVertex(2);
            graph.AddUndirectedEge(test, test2);
            Assert.Single(graph.GetNeighbors(test));
        }

        [Fact]
        public void GetEdgeWeight()
        {
            Graph<int> graph = new Graph<int>();
            Vertex<int> test = graph.AddVertex(17);
            Vertex<int> test2 = graph.AddVertex(2);
            graph.AddUndirectedEge(test, test2);
            List<Edge<int>> list = graph.GetNeighbors(test);
            int weight = 1;
            foreach(var l in list)
            {
                weight = l.Weight;
            }

            Assert.Equal(0, weight);
        }

        [Fact]
        public void GetSize()
        {
            Graph<int> graph = new Graph<int>();
            Vertex<int> test = graph.AddVertex(17);
            Vertex<int> test2 = graph.AddVertex(2);
            Vertex<int> test3 = graph.AddVertex(15);
            Vertex<int> test4 = graph.AddVertex(31);

            Assert.Equal(4, graph.GetSize());
        }

        [Fact]
        public void SingleEdge()
        {
            Graph<int> graph = new Graph<int>();
            Vertex<int> test = graph.AddVertex(17);
            List<Vertex<int>> values = new List<Vertex<int>>();
            List<Vertex<int>> list = new List<Vertex<int>>();
            list.Add(test);

            Assert.Equal(list, graph.GetNodes(test, values));
        }

        [Fact]
        public void EmptyGraph()
        {
            Graph<int> graph = new Graph<int>();
            Assert.Empty(graph.AdjacencyList);
        }
    }
}
