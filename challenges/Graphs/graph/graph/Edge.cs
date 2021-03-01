using System;
using System.Collections.Generic;
using System.Text;

namespace graphs
{
    public class Edge<T>
    {
        public int Weight { get; set; }
        public Vertex<T> Vertex { get; set; }
    }
}
