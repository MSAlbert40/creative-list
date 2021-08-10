
namespace creative_list
{
    partial class TopologicalSortForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopologicalSortForm));
            this.PBViewGraph = new System.Windows.Forms.PictureBox();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.PBMinimize = new System.Windows.Forms.PictureBox();
            this.TDraw = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBViewGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // PBViewGraph
            // 
            this.PBViewGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PBViewGraph.Location = new System.Drawing.Point(25, 39);
            this.PBViewGraph.Name = "PBViewGraph";
            this.PBViewGraph.Size = new System.Drawing.Size(1220, 156);
            this.PBViewGraph.TabIndex = 0;
            this.PBViewGraph.TabStop = false;
            // 
            // PBClose
            // 
            this.PBClose.Image = ((System.Drawing.Image)(resources.GetObject("PBClose.Image")));
            this.PBClose.Location = new System.Drawing.Point(1224, 11);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(20, 20);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 1;
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // PBMinimize
            // 
            this.PBMinimize.Image = ((System.Drawing.Image)(resources.GetObject("PBMinimize.Image")));
            this.PBMinimize.Location = new System.Drawing.Point(1194, 10);
            this.PBMinimize.Name = "PBMinimize";
            this.PBMinimize.Size = new System.Drawing.Size(22, 22);
            this.PBMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMinimize.TabIndex = 4;
            this.PBMinimize.TabStop = false;
            this.PBMinimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // TDraw
            // 
            this.TDraw.Enabled = true;
            this.TDraw.Interval = 400;
            this.TDraw.Tick += new System.EventHandler(this.TopologicalSort_Time);
            // 
            // TopologicalSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1270, 224);
            this.Controls.Add(this.PBMinimize);
            this.Controls.Add(this.PBClose);
            this.Controls.Add(this.PBViewGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopologicalSortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopologicalSort";
            this.Load += new System.EventHandler(this.TopologicalSort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBViewGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBViewGraph;
        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.PictureBox PBMinimize;
        private System.Windows.Forms.Timer TDraw;
    }
}