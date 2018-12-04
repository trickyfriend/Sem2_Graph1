using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Graph1
{
    class Logic
    {
        public static void DextreeAlgorithm(Graph g, Node A)
        {
            foreach (Node n in g.Nodes)
            {
                n.visited = false;
                n.min = int.MaxValue;
            }
            A.visited = true;
            foreach (Edge e in A.Edges)
                e.to.min = e.weight;
            A.min = 0;
            while (NotVisitedNodes(g))
            {
                int nA;
                Node p = MinNode(g, A, out nA);
                foreach (Node n in g.Nodes)
                    if (n == p)
                    {
                        n.visited = true;
                        foreach (Edge e in n.Edges)
                        {
                            if (e.to != A)
                            {
                                int d = e.weight + nA;
                                if (d < e.to.min)
                                    e.to.min = d;
                            }
                        }
                    }
            }
        }

        private static bool NotVisitedNodes(Graph g)
        {
            foreach (Node n in g.Nodes)
                if (!n.visited)
                    return true;
            return false;
        }

        private static Node MinNode(Graph g, Node A, out int min)
        {
            Node p = null;
            foreach (Node n in g.Nodes)
                if (!n.visited && (p == null || n.min < p.min))
                    p = n;
            min = p.min;
            return p;
        }

        public static Node FindCity(Graph g)
        {
            int minSumOfDistances = int.MaxValue;
            Node minNode = null;

            foreach (Node n in g.Nodes)
            {
                if (SumOfDistances(g, n) < minSumOfDistances)
                {
                    minSumOfDistances = SumOfDistances(g, n);
                    minNode = n;
                }
            }

            return minNode;
        }

        private static int SumOfDistances(Graph g, Node city)
        {
            DextreeAlgorithm(g, city);
            int sum = 0;
            foreach (Edge e in city.Edges)
            {
                sum += e.to.min;
            }
            return sum;
        }
    }
}
