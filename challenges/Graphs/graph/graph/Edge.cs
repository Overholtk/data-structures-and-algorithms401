using System;
using System.Collections.Generic;
using System.Text;

namespace graphs
{
    class Edge<T>
    {
        public int Weight { get; set; }
        public Vertex<T> Vertex { get; set; }
    }
}
