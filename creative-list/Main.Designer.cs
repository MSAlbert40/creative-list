
namespace creative_list
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BMenu
            // 
            this.BMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.BMenu.Location = new System.Drawing.Point(593, 422);
            this.BMenu.Name = "BMenu";
            this.BMenu.Size = new System.Drawing.Size(121, 28);
            this.BMenu.TabIndex = 0;
            this.BMenu.Text = "Start";
            this.BMenu.UseVisualStyleBackColor = true;
            this.BMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 540);
            this.Controls.Add(this.BMenu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BMenu;
    }
}