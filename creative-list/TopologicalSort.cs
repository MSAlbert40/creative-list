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
    public partial class TopologicalSortForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, // rect of corner
            int nWidthEllipse, int nHeightEllipse // dimension of ellipse
        );

        Boolean active;

        public int value;

        GraphExecution graph;

        public List<String> tSort;

        public TopologicalSortForm()
        {
            InitializeComponent();
            graph = new GraphExecution(PBViewGraph);
            tSort = new List<String>();
            active = true;
        }

        private void TopologicalSort_Load(object sender, EventArgs e)
        {
            if (active)
            {
                this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
                this.PBViewGraph.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PBViewGraph.Width, PBViewGraph.Height, 25, 25));
            }
        }

        private void TopologicalSort_Time(object sender, EventArgs e)
        {
            graph.viewTopological(value, tSort);
            TDraw.Enabled = false;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
