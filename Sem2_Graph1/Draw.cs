using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Graph1
{
    class Draw
    {
        private static void Edge(Graphics g, int x1, int y1, int x2, int y2, int wt)
        {
            Font f = new Font("TimeNewRoman", 15F);
            g.DrawLine(Pens.Black, x1, y1, x2, y2);
            SizeF sz = g.MeasureString(Convert.ToString(wt), f);
            int x = (x1 + x2) / 2, y = (y1 + y2) / 2;
            g.DrawString(Convert.ToString(wt), f, Brushes.Black, x - sz.Width / 2, y - sz.Height / 2);
        }
        private static void Node(Graphics g, int x, int y, int R, string name)
        {
            Font f = new Font("TimeNewRoman", 15F);
            Brush br = Brushes.Black;
            SizeF sz = g.MeasureString(name, f);
            g.DrawString(name, f, br, x - sz.Width / 2, y - sz.Height / 2);
        }
        private static void Ellipse(Graphics g, int x, int y, int R, bool special)
        {
            Brush br;
            if (special)
                br = Brushes.Orange;
            else
                br = Brushes.Yellow;
            g.FillEllipse(br, x - R, y - R, 2 * R, 2 * R);
            g.DrawEllipse(Pens.Black, x - R, y - R, 2 * R, 2 * R);
        }
        public static Bitmap Graph(Graphics g, Graph p, int d)
        {
            Bitmap bmp = new Bitmap(1000, 1000);
            g = Graphics.FromImage(bmp);
            Font f = new Font("TimeNewRoman", 15F);
            int L = p.Nodes.Count;
            for (int i = 0; i < L; i++)
                for (int j = 0; j < p.Nodes[i].Edges.Count; j++)
                    Edge(g, p.Nodes[i].x, p.Nodes[i].y, p.Nodes[i].Edges[j].to.x, p.Nodes[i].Edges[j].to.y, p.Nodes[i].Edges[j].weight);
            for (int i = 0; i < L; i++)
            {
                Ellipse(g, p.Nodes[i].x, p.Nodes[i].y, p.Nodes[i].R, p.Nodes[i].select);
                Node(g, p.Nodes[i].x, p.Nodes[i].y, p.Nodes[i].R, p.Nodes[i].name);

            }
            float HH = g.MeasureString("X", f).Height;
            return bmp;
        }
    }
}
