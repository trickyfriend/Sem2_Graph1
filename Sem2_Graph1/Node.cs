using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Graph1
{
    class Node
    {
        public string name;
        public int x;
        public int y;
        public int R = 20;
        public bool visited;
        public bool select;
        public int min;
        public List<Edge> Edges;
        public Node(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            visited = false;
            select = false;
            min = int.MaxValue;
            Edges = new List<Edge>();
        }

        public string ConvertToString()
        {
            string str = name + " " + x.ToString() + " " + y.ToString() + " " + Environment.NewLine;
            if (Edges != null)
                for (int i = 0; i < Edges.Count; i++)
                    str += Edges[i].to.name + " " + Edges[i].weight.ToString() + " ";
            str += Environment.NewLine;
            return str;
        }
    }
}
