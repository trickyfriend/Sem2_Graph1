using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2_Graph1
{
    public partial class GraphForm : Form
    {
        Graph graph = new Graph();
        static Graphics g;
        public GraphForm()
        {
            InitializeComponent();
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButtonNodeAdd.Checked)
            {
                graph.AddNode(e.X, e.Y, textBoxNodeValue.Text);
                int q = 0;
                if (int.TryParse(textBoxNodeValue.Text, out q))
                    textBoxNodeValue.Text = (q + 1).ToString();
            }
            else if (radioButtonEdgeAdd.Checked)
            {
                try
                {
                    graph.AddEdge(e.X, e.Y, Convert.ToInt32(textBoxEdgeWeight.Text));
                }
                catch
                {
                    MessageBox.Show("Enter integer value");
                }
            }
            else if (radioButtonNodeMove.Checked)
                graph.MoveNode(e.X, e.Y);
            else if (radioButtonNodeRemove.Checked)
                graph.DeleteNode(e.X, e.Y);
            else
                graph.DeleteEdge(e.X, e.Y);
            pictureBox.Image = Draw.Graph(g, graph, 9);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            graph.Nodes.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                File.LoadGraph(openFileDialog.FileName, graph);
            pictureBox.Image = Draw.Graph(g, graph, 9);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                File.SaveGraph(saveFileDialog.FileName, graph);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            graph.Nodes.Clear();
            pictureBox.Image = Draw.Graph(g, graph, 9);
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            labelNumber.Text = Logic.FindCity(graph).name;
        }
    }

}
