using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_list
{
    public partial class DashboardForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, // rect of corner
            int nWidthEllipse, int nHeightEllipse // dimension of ellipse
        );

        int value;

        public String[] list;

        public int[] vertex, edge;

        List<String> tSort;

        List<GraphRelation> rGraphs;

        Boolean active, view;

        GraphExecution graph;

        TopologicalSortForm topologicalSort;

        public DashboardForm()
        {
            InitializeComponent();
            graph = new GraphExecution(PBViewGraph, LBTopologicalSorting, LBVertex, LBEdge);
            rGraphs = new List<GraphRelation>();
            tSort = new List<String>();
            list = new String[12];
            vertex = new int[12];
            edge = new int[12];         
            active = true;
            view = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            TBMinimum.Text = "8";
            TBMaximum.Text = "12";

            TBMinimum.Enabled = false;
            TBMaximum.Enabled = false;

            BGenerate.Enabled = false;
            BView.Visible = false;

            if (active)
            {
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
                PBViewGraph.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PBViewGraph.Width, PBViewGraph.Height, 25, 25));
                LBTopologicalSorting.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LBTopologicalSorting.Width, LBTopologicalSorting.Height, 25, 25));
                BView.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BView.Width, BView.Height, 25, 25));
                BGenerate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BGenerate.Width, BGenerate.Height, 20, 20));
                TBMinimum.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TBMinimum.Width, TBMinimum.Height, 15, 15));
                TBBelongs.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TBBelongs.Width, TBBelongs.Height, 15, 15));
                TBMaximum.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TBMaximum.Width, TBMaximum.Height, 15, 15));
                LBVertex.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LBVertex.Width, LBVertex.Height, 20, 20));
                LBEdge.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LBEdge.Width, LBEdge.Height, 20, 20));
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            for (int z = 0; z < 12; z++) rGraphs.Add(new GraphRelation(vertex[z], edge[z]));
            graph.exportResources(list, rGraphs);

            value = Convert.ToInt32(TBBelongs.Text);
            if (value >= Convert.ToInt32(TBMinimum.Text) && value <= Convert.ToInt32(TBMaximum.Text)) graph.viewGraph(value, tSort);
            else if (value < Convert.ToInt32(TBMinimum.Text)) MessageBox.Show("Sorry, but the entered value is less than the Minimum", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (value > Convert.ToInt32(TBMaximum.Text)) MessageBox.Show("Sorry, but the value entered is greater than the Maximum", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (view) this.topologicalSort.Close();
            BView.Visible = true;
        }

        private void Belongs_Valid(object sender, EventArgs e)
        {
            BGenerate.Enabled = TBBelongs.TextLength > 0;
        }

        private void Belongs_Text(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        private void TopologicalSort_Click(object sender, EventArgs e)
        {
            topologicalSort = new TopologicalSortForm();

            for (int z = 0; z < 12; z++)
            {
                topologicalSort.list[z] = list[z];
                topologicalSort.vertex[z] = vertex[z];
                topologicalSort.edge[z] = edge[z];
            }

            topologicalSort.value = Convert.ToInt32(TBBelongs.Text);
            for (int t = 0; t < Convert.ToInt32(TBBelongs.Text); t++) topologicalSort.tSort.Add(tSort[t]);
            topologicalSort.Show();
            view = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            Close();

            if (view) topologicalSort.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
            if (view) topologicalSort.Close();
        }
    }
}
