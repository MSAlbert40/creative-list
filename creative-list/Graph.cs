using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace creative_list
{
    class Graph
    {
        public String tGraph { set; get; }
        public int xGraph { set; get; }
        public int yGraph { set; get; }
        public int dGraph { set; get; }
        private int rGraph { set; get; }
        private List<GraphColor> cGraph;
        private Random rd = new Random();
        private int rgb { set; get; }
        private Pen pen { set; get; }
        private Brush brush { set; get; }
        private Font font { set; get; }
        private StringFormat aligment { set; get; }
        public Graph() 
        {
            // Aditional Components
            this.cGraph = new List<GraphColor>();
            this.newColors();
            this.rgb = rd.Next(0, cGraph.Count);
            this.pen = new Pen(Color.FromArgb(cGraph[rgb].rColor, cGraph[rgb].gColor, cGraph[rgb].bColor), 4);
        }
        public Graph(String tGraph, int xGraph, int yGraph, int dGraph)
        {
            this.tGraph = tGraph;
            this.xGraph = xGraph;
            this.yGraph = yGraph;
            this.dGraph = dGraph;
            this.rGraph = dGraph / 2;
            // Aditional Components
            this.cGraph = new List<GraphColor>();
            this.newColors();
            this.rgb = rd.Next(0, cGraph.Count);
            this.pen = new Pen(Color.FromArgb(cGraph[rgb].rColor, cGraph[rgb].gColor, cGraph[rgb].bColor), 4);
            this.brush = new SolidBrush(Color.FromArgb(40, 40, 40));
            this.font = new Font(new FontFamily("Economica"), 11);
            this.aligment = new StringFormat();
            aligment.Alignment = StringAlignment.Center;
            aligment.LineAlignment = StringAlignment.Center;
        }
        public Boolean Collision(Graph firstGraph, Graph secondGraph)
        {
            float dx = secondGraph.xGraph - firstGraph.xGraph;
            float dy = secondGraph.yGraph - firstGraph.yGraph;
            int dr = secondGraph.rGraph + firstGraph.rGraph + 30;
            if ((Math.Pow(dx, 2)) + (Math.Pow(dy, 2)) <= Math.Pow(dr, 2)) return true;
            else return false;
        }
        public void Drawing(Graphics paper)
        {
            paper.FillEllipse(brush, xGraph, yGraph, dGraph, dGraph);
            paper.DrawEllipse(pen, new Rectangle(xGraph, yGraph, dGraph, dGraph));
            paper.DrawString(tGraph, font, Brushes.White, new Rectangle(xGraph, yGraph, dGraph, dGraph), aligment);
        }
        public void Drawing(Graphics paper, Graph vGraph, Graph eGraph)
        {
            Point vPoint = new Point(vGraph.xGraph + vGraph.rGraph, vGraph.yGraph + vGraph.rGraph);
            Point ePoint = new Point(eGraph.xGraph + eGraph.rGraph, eGraph.yGraph + eGraph.rGraph);
            paper.DrawLine(pen, vPoint, ePoint);
        }
        private void newColors()
        {
            cGraph.Add(new GraphColor(250, 148, 15));
            cGraph.Add(new GraphColor(0, 123, 248));
        }
    }
    class GraphColor
    {
        public int rColor { set; get; }
        public int gColor { set; get; }
        public int bColor { set; get; }
        public GraphColor() { }
        public GraphColor(int rColor, int gColor, int bColor)
        {
            this.rColor = rColor;
            this.gColor = gColor;
            this.bColor = bColor;
        }
    }
    class GraphExecution
    {
        private int diameter;
        private Boolean overhead;
        private Graphics paper;
        private Random rd = new Random();
        private PictureBox pGraph;
        private ListBox lGraph, lVertex, lEdge;
        private Graph relations = new Graph();
        private List<Graph> graphs = new List<Graph>();
        // private String[] list = new string[12];
        private String[] Elist = { "glasses", "socks", "shirt", "underpants", "watch", "pants", "waistcoat", "shoes", "belt", "coat", "tie", "briefcase" };
        private int[] vertex = { 0, 0, 1, 2, 2, 3, 5, 5, 6, 8, 9, 10 };
        private int[] edge = { 1, 3, 7, 8, 10, 5, 7, 8, 9, 9, 11, 6 };
        public GraphExecution(PictureBox pGraph, ListBox lGraph, ListBox lVertex, ListBox lEdge)
        {
            this.pGraph = pGraph;
            this.lGraph = lGraph;
            this.lVertex = lVertex;
            this.lEdge = lEdge;
            this.diameter = 70;
            this.paper = pGraph.CreateGraphics();
        }
        public void viewGraph(int value)
        {
            // Clean All Form
            if (graphs.Count > 0)
            {
                lVertex.Items.Clear();
                lEdge.Items.Clear();
                graphs.Clear();
                pGraph.Refresh();
            }

            while (graphs.Count < value)
            {
                Graph newGraph = new Graph(Elist[graphs.Count], rd.Next(1, pGraph.Width - diameter - 5), rd.Next(1, pGraph.Height - diameter - 5), diameter);
                if (graphs.Count == 0) graphs.Add(newGraph);
                else if (graphs.Count > 0)
                {
                    for (int i = 0; i < graphs.Count; i++)
                    {
                        overhead = newGraph.Collision(graphs[i], newGraph);
                        if (overhead) break;
                    }
                    if (!overhead) graphs.Add(newGraph);
                }
            }

            // Add Relation in ListBox
            for (int l = 0; l < Elist.Length; l++)
            {
                if (vertex[l] < value && edge[l] < value)
                {
                    lVertex.Items.Add(Elist[vertex[l]]);
                    lEdge.Items.Add(Elist[edge[l]]);
                    relations.Drawing(paper, graphs[vertex[l]], graphs[edge[l]]);
                }
            }

            foreach (Graph view in graphs) view.Drawing(paper);
        }
    }
}
