using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Graph1
{
    class Graph
    {
        public List<Node> Nodes;
        public Graph()
        {
            Nodes = new List<Node>();
        }

        public Node FindNode(int x, int y)
        {
            foreach (Node n in Nodes)
                if ((n.x - x) * (n.x - x) + (n.y - y) * (n.y - y) < n.R * n.R)
                    return n;
            return null;
        }

        public void AddNode(int x, int y, string name)
        {
            Nodes.Add(new Node(name, x, y));
        }

        public void AddEdge(int x, int y, int wt)
        {
            if (FindNode(x, y) == null)
            {
                RemoveSelection();
                return;
            }
            foreach (Node n in Nodes)
                if (n.select)
                {
                    Node p = FindNode(x, y);
                    n.Edges.Add(new Edge(p, wt));
                    p.Edges.Add(new Edge(n, wt));
                    n.select = false;
                    return;
                }
            FindNode(x, y).select = true;
        }

        private void DeleteEdgeP1P2(Node p1, Node p2)
        {
            foreach (Edge e in p1.Edges)
                if (e.to == p2)
                {
                    p1.Edges.Remove(e);
                    break;
                }
            foreach (Edge e in p2.Edges)
                if (e.to == p1)
                {
                    p2.Edges.Remove(e);
                    break;
                }
        }

        public void DeleteEdge(int x, int y)
        {
            if (FindNode(x, y) == null)
            {
                RemoveSelection();
                return;
            }
            foreach (Node n in Nodes)
                if (n.select)
                {
                    Node p = FindNode(x, y);
                    DeleteEdgeP1P2(p, n);
                    n.select = false;
                    return;
                }
            FindNode(x, y).select = true;
        }

        public void DeleteNode(int x, int y)
        {
            if (FindNode(x, y) == null)
            {
                RemoveSelection();
                return;
            }
            foreach (Node n in Nodes)
                if (n == FindNode(x, y))
                {
                    foreach (Edge e in n.Edges)
                        foreach (Edge u in e.to.Edges)
                            if (u.to == n)
                            {
                                e.to.Edges.Remove(u);
                                break;
                            }
                    Nodes.Remove(n);
                    break;
                }
        }

        public void MoveNode(int x, int y)
        {
            if (FindNode(x, y) == null && !SelectionNodes())
                return;
            foreach (Node n in Nodes)
                if (n.select)
                {
                    n.x = x;
                    n.y = y;
                    n.select = false;
                    return;
                }
            FindNode(x, y).select = true;
        }

        private void RemoveSelection()
        {
            foreach (Node n in Nodes)
                if (n.select)
                    n.select = false;
        }

        private bool SelectionNodes()
        {
            foreach (Node n in Nodes)
                if (n.select)
                    return true;
            return false;
        }
    }
}
