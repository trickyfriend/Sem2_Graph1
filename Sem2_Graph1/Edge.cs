using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Graph1
{
    class Edge
    {
        public Node to;
        public int weight;

        public Edge(Node to, int weight)
        {
            this.to = to;
            this.weight = weight;
        }
    }
}
