using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Graph1
{
    class File
    {
        public static void SaveGraph(string FileName, Graph g)
        {
            using (StreamWriter sw = new StreamWriter(FileName))
            {
                string str = "";
                for (int i = 0; i < g.Nodes.Count; i++)
                    str += g.Nodes[i].ConvertToString();
                sw.Write(str);
            }
        }
        public static void LoadGraph(string FileName, Graph g)
        {
            List<string> str1 = new List<string>();
            List<string> str2 = new List<string>();
            g.Nodes.Clear();
            using (StreamReader sr = new StreamReader(FileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    str1.Add(line);
                    if ((line = sr.ReadLine()) != null)
                        str2.Add(line);
                }

                for (int i = 0; i < str1.Count; i++)
                {
                    string[] str = str1[i].Split(' ');
                    g.Nodes.Add(ConvertToNode(g, str));
                }

                for (int i = 0; i < str2.Count; i++)
                {
                    string[] str = str2[i].Split(' ');
                    AddEdges(g, g.Nodes[i], str);
                }
            }
        }
        private static Node ConvertToNode(Graph g, string[] str)
        {
            Node p = new Node(str[0], Convert.ToInt32(str[1]), Convert.ToInt32(str[2]));
            return p;
        }
        private static void AddEdges(Graph g, Node A, string[] str)
        {
            for (int i = 0; i < str.Length - 1; i += 2)
                A.Edges.Add(new Edge(FindNodeName(g, str[i]), Convert.ToInt32(str[i + 1])));
        }

        private static Node FindNodeName(Graph g, string name)
        {
            foreach (Node n in g.Nodes)
                if (n.name == name)
                    return n;
            return null;
        }
    }
}
