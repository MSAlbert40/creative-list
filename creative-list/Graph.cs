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
        private int vGraph { set; get; }
        private LinkedList<int>[] eGraph;
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
        public Graph(int vGraph)
        {
            this.vGraph = vGraph;
            this.eGraph = new LinkedList<int>[vGraph];
            for (int i = 0; i < vGraph; i++) eGraph[i] = new LinkedList<int>();
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
        public void AddEdge(int vertex, int edge)
        {
            this.eGraph[vertex].AddFirst(edge);
        }
        public void TopologicalSort(List<int> graph)
        {
            Stack<int> stack = new Stack<int>();
            Boolean[] visited = new Boolean[vGraph];
            //for (int i = 0; i < vGraph; i++) visited[i] = false;
            for (int l = 0; l < vGraph; l++)
            {
                if (visited[l] == false) TopologicalSortUtil(l, visited, stack);
            }
            foreach (int vertex in stack) graph.Add(vertex);
        }
        private void TopologicalSortUtil(int vertex, Boolean[] visited, Stack<int> stack)
        {
            visited[vertex] = true;
            foreach (int v in eGraph[vertex])
            {
                if (!visited[v]) TopologicalSortUtil(v, visited, stack);
            }
            stack.Push(vertex);
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
        public void Drawing(Graphics paper, Graph vGraph, Graph eGraph, int distance)
        {
            Point vPoint = new Point(vGraph.xGraph + vGraph.rGraph, vGraph.yGraph + vGraph.rGraph);
            Point ePoint = new Point(eGraph.xGraph + eGraph.rGraph, eGraph.yGraph + eGraph.rGraph);

            if ((rd.Next(0, 2) > 0)) dGraph = -35;
            else dGraph = 195;
            Point cPoint = new Point(((ePoint.X - vPoint.X) / 2) + vPoint.X, dGraph);

            if ((ePoint.X - vPoint.X) < distance) paper.DrawLine(pen, vPoint, ePoint);
            else ZBezier(paper, pen, vPoint, cPoint, ePoint, 4);
        }
        private void ZBezier(Graphics paper, Pen pen, Point vPoint, Point cPoint, Point ePoint, int count)
        {
            if (count > 0)
            {
                Point pOne = new Point((vPoint.X + cPoint.X) / 2, (vPoint.Y + cPoint.Y) / 2);
                Point pTwo = new Point((cPoint.X + ePoint.X) / 2, (cPoint.Y + ePoint.Y) / 2);
                Point pMain = new Point((pOne.X + pTwo.X) / 2, (pOne.Y + pTwo.Y) / 2);

                ZBezier(paper, pen, vPoint, pOne, pMain, count - 1);
                ZBezier(paper, pen, pMain, pTwo, ePoint, count - 1);
            }
            else
            {
                paper.DrawLine(pen, vPoint, cPoint);
                paper.DrawLine(pen, cPoint, ePoint);
            }
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
    class GraphRelation
    {
        public int vertex { set; get; }
        public int edge { set; get; }
        public GraphRelation() { }
        public GraphRelation(int vertex, int edge)
        {
            this.vertex = vertex;
            this.edge = edge;
        }
    }
    class GraphExecution
    {
        private int diameter;
        private Boolean overhead;
        private Graphics paper;
        private Graph sort;
        private Random rd = new Random();
        private PictureBox pGraph;
        private ListBox lGraph, lVertex, lEdge;
        private Graph relations = new Graph();
        private String[] list = new string[12];
        private List<int> vsort = new List<int>();
        private List<Graph> graphs = new List<Graph>();
        private List<GraphRelation> rGraphs = new List<GraphRelation>();
        public GraphExecution(PictureBox pGraph)
        {
            this.pGraph = pGraph;
            diameter = 70;
            paper = pGraph.CreateGraphics();
        }
        public GraphExecution(PictureBox pGraph, ListBox lGraph, ListBox lVertex, ListBox lEdge)
        {
            this.pGraph = pGraph;
            this.lGraph = lGraph;
            this.lVertex = lVertex;
            this.lEdge = lEdge;
            diameter = 70;
            paper = pGraph.CreateGraphics();
        }
        public void exportResources(String[] list, List<GraphRelation> rGraphs)
        {
            for (int x = 0; x < 12; x++)
            {
                this.list[x] = list[x];
                this.rGraphs.Add(new GraphRelation(rGraphs[x].vertex, rGraphs[x].edge));
            }
        }
        public void viewGraph(int value, List<String> topological)
        {
            // Clean All Form
            if (graphs.Count > 0)
            {
                lVertex.Items.Clear();
                lEdge.Items.Clear();
                lGraph.Items.Clear();
                vsort.Clear();
                graphs.Clear();
                pGraph.Refresh();
                topological.Clear();
            }

            while (graphs.Count < value)
            {
                Graph newGraph = new Graph(list[graphs.Count], rd.Next(1, pGraph.Width - diameter - 5), rd.Next(1, pGraph.Height - diameter - 5), diameter);
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
            for (int l = 0; l < list.Length; l++)
            {
                if (rGraphs[l].vertex < value && rGraphs[l].edge < value)
                {
                    lVertex.Items.Add(list[rGraphs[l].vertex]);
                    lEdge.Items.Add(list[rGraphs[l].edge]);
                    relations.Drawing(paper, graphs[rGraphs[l].vertex], graphs[rGraphs[l].edge]);
                }
            }

            for (int t = 0; t < 12; t++)
            {
                this.TSort();
                if (vsort[t] < value)
                {
                    lGraph.Items.Add(list[vsort[t]]);
                    topological.Add(list[vsort[t]]);
                }
            }

            foreach (Graph view in graphs) view.Drawing(paper);
        }
        public void TSort()
        {
            sort = new Graph(12);
            for (int z = 0; z < 12; z++) sort.AddEdge(rGraphs[z].vertex, rGraphs[z].edge);
            sort.TopologicalSort(vsort);
        }
        public void viewTopological(int value, List<String> topological)
        {
            while (vsort.Count < value)
            {
                if (vsort.Count == 0) vsort.Add(24);
                else if (vsort.Count > 0) vsort.Add(vsort[vsort.Count - 1] + diameter + 30);
            }
            
            while (graphs.Count < value)
            {
                int ypos = (pGraph.Height / 2) - (diameter / 2);
                for (int z = 0; z < topological.Count; z++)
                {
                    if (graphs.Count == Array.IndexOf(list, topological[z]))
                    {
                        int search = topological.IndexOf(topological[z]);
                        graphs.Add(new Graph(topological[search], vsort[search], ypos, diameter));
                        break;
                    }
                }
            }

            // Add Relation in ListBox
            for (int l = 0; l < list.Length; l++)
            {
                if (rGraphs[l].vertex < value && rGraphs[l].edge < value) relations.Drawing(paper, graphs[rGraphs[l].vertex], graphs[rGraphs[l].edge], (diameter + 54));
            }

            foreach (Graph view in graphs) view.Drawing(paper);
        }
    }
}
