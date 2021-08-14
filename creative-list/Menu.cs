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
    public partial class MenuForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, // rect of corner
            int nWidthEllipse, int nHeightEllipse // dimension of ellipse
        );

        Boolean language;

        String[] list;

        int[] vertex, edge;

        public MenuForm()
        {
            InitializeComponent();
            language = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
            LInstruction.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LInstruction.Width, LInstruction.Height, 5, 5));
        }

        private void Pizza_Click(object sender, EventArgs e)
        {
            if (language) list = new String[12] { "mozzarella", "oregano", "dough", "bake", "cheese", "pepper", "tomatoe", "pepperoni", "salt", "mushroom", "onion", "olive" };
            else list = new String[12] { "mozzarella", "orégano", "masa", "hornear", "queso", "pimienta", "tomate", "pepperoni", "sal", "champiñón", "cebolla", "aceituna" };

            vertex = new int[12] { 0, 0, 1, 2, 4, 4, 5, 6, 7, 9, 10, 11 };
            edge = new int[12] { 7, 11, 3, 6, 0, 8, 10, 4, 9, 10, 1, 5 };

            DashboardForm dashboard = new DashboardForm();

            for (int z = 0; z < 12; z++)
            {
                dashboard.list[z] = list[z];
                dashboard.vertex[z] = vertex[z];
                dashboard.edge[z] = edge[z];
            }

            dashboard.Show();
            Close();
        }

        private void Wear_Click(object sender, EventArgs e)
        {
            if (language) list = new String[12] { "glasses", "socks", "shirt", "underpants", "watch", "pants", "waistcoat", "shoes", "belt", "coat", "tie", "briefcase" };
            else list = new String[12] { "gafas", "calcetines", "camisa", "calzoncillos", "reloj", "pantalones", "chaleco", "zapatos", "cinturón", "saco", "corbata", "maletín" };

            vertex = new int[12] { 0, 0, 1, 2, 2, 3, 5, 5, 6, 8, 9, 10 };
            edge = new int[12] { 1, 3, 7, 8, 10, 5, 7, 8, 9, 9, 11, 6 };

            DashboardForm dashboard = new DashboardForm();

            for (int z = 0; z < 12; z++)
            {
                dashboard.list[z] = list[z];
                dashboard.vertex[z] = vertex[z];
                dashboard.edge[z] = edge[z];
            }

            dashboard.Show();
            Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
