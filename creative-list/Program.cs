using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_list
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm main = new MainForm();
            main.FormClosed += Form_Closed;
            main.Show();
            Application.Run();
        }

        private static void Form_Closed(Object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= Form_Closed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += Form_Closed;
        }
    }
}
