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

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            TBMinimum.Text = "8";
            TBMinimum.Enabled = false;
            TBMaximum.Text = "12";
            TBMaximum.Enabled = false;
            BView.Visible = true;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
            this.PBViewGraph.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PBViewGraph.Width, PBViewGraph.Height, 25, 25));
            this.LBTopologicalSorting.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LBTopologicalSorting.Width, LBTopologicalSorting.Height, 25, 25));
            this.BView.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BView.Width, BView.Height, 25, 25));
            this.BGenerate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BGenerate.Width, BGenerate.Height, 20, 20));
            this.TBMinimum.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TBMinimum.Width, TBMinimum.Height, 15, 15));
            this.TBBelongs.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TBBelongs.Width, TBBelongs.Height, 15, 15));
            this.TBMaximum.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TBMaximum.Width, TBMaximum.Height, 15, 15));
            this.LBVertex.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LBVertex.Width, LBVertex.Height, 20, 20));
            this.LBEdge.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LBEdge.Width, LBEdge.Height, 20, 20));
        }
        private void Back_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
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
