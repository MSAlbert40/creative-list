
namespace creative_list
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.PInfo = new System.Windows.Forms.Panel();
            this.LEdge = new System.Windows.Forms.Label();
            this.LVertex = new System.Windows.Forms.Label();
            this.LBEdge = new System.Windows.Forms.ListBox();
            this.LBVertex = new System.Windows.Forms.ListBox();
            this.LBelongs = new System.Windows.Forms.Label();
            this.LMaximum = new System.Windows.Forms.Label();
            this.LMinimum = new System.Windows.Forms.Label();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.TBMinimum = new System.Windows.Forms.TextBox();
            this.TBMaximum = new System.Windows.Forms.TextBox();
            this.TBBelongs = new System.Windows.Forms.TextBox();
            this.BGenerate = new System.Windows.Forms.Button();
            this.PBViewGraph = new System.Windows.Forms.PictureBox();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.PBMinimize = new System.Windows.Forms.PictureBox();
            this.PBBack = new System.Windows.Forms.PictureBox();
            this.LBTopologicalSorting = new System.Windows.Forms.ListBox();
            this.BView = new System.Windows.Forms.Button();
            this.PInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBViewGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBack)).BeginInit();
            this.SuspendLayout();
            // 
            // PInfo
            // 
            this.PInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(224)))), ((int)(((byte)(196)))));
            this.PInfo.Controls.Add(this.LEdge);
            this.PInfo.Controls.Add(this.LVertex);
            this.PInfo.Controls.Add(this.LBEdge);
            this.PInfo.Controls.Add(this.LBVertex);
            this.PInfo.Controls.Add(this.LBelongs);
            this.PInfo.Controls.Add(this.LMaximum);
            this.PInfo.Controls.Add(this.LMinimum);
            this.PInfo.Controls.Add(this.PBLogo);
            this.PInfo.Controls.Add(this.TBMinimum);
            this.PInfo.Controls.Add(this.TBMaximum);
            this.PInfo.Controls.Add(this.TBBelongs);
            this.PInfo.Controls.Add(this.BGenerate);
            this.PInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PInfo.Location = new System.Drawing.Point(0, 0);
            this.PInfo.Margin = new System.Windows.Forms.Padding(0);
            this.PInfo.Name = "PInfo";
            this.PInfo.Size = new System.Drawing.Size(304, 540);
            this.PInfo.TabIndex = 0;
            // 
            // LEdge
            // 
            this.LEdge.AutoSize = true;
            this.LEdge.Font = new System.Drawing.Font("Bebas Neue", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LEdge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LEdge.Location = new System.Drawing.Point(192, 353);
            this.LEdge.Name = "LEdge";
            this.LEdge.Size = new System.Drawing.Size(39, 23);
            this.LEdge.TabIndex = 11;
            this.LEdge.Text = "Edge";
            // 
            // LVertex
            // 
            this.LVertex.AutoSize = true;
            this.LVertex.Font = new System.Drawing.Font("Bebas Neue", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LVertex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LVertex.Location = new System.Drawing.Point(64, 353);
            this.LVertex.Name = "LVertex";
            this.LVertex.Size = new System.Drawing.Size(54, 23);
            this.LVertex.TabIndex = 10;
            this.LVertex.Text = "Vertex";
            // 
            // LBEdge
            // 
            this.LBEdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(195)))), ((int)(((byte)(170)))));
            this.LBEdge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBEdge.Font = new System.Drawing.Font("Economica", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBEdge.FormattingEnabled = true;
            this.LBEdge.ItemHeight = 17;
            this.LBEdge.Location = new System.Drawing.Point(162, 143);
            this.LBEdge.Name = "LBEdge";
            this.LBEdge.Size = new System.Drawing.Size(100, 221);
            this.LBEdge.TabIndex = 9;
            // 
            // LBVertex
            // 
            this.LBVertex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(195)))), ((int)(((byte)(170)))));
            this.LBVertex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBVertex.Font = new System.Drawing.Font("Economica", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBVertex.FormattingEnabled = true;
            this.LBVertex.ItemHeight = 17;
            this.LBVertex.Location = new System.Drawing.Point(42, 143);
            this.LBVertex.Name = "LBVertex";
            this.LBVertex.Size = new System.Drawing.Size(100, 221);
            this.LBVertex.TabIndex = 8;
            // 
            // LBelongs
            // 
            this.LBelongs.AutoSize = true;
            this.LBelongs.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBelongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LBelongs.Location = new System.Drawing.Point(69, 447);
            this.LBelongs.Name = "LBelongs";
            this.LBelongs.Size = new System.Drawing.Size(171, 19);
            this.LBelongs.TabIndex = 7;
            this.LBelongs.Text = "Minimum < Belongs < Maximum";
            this.LBelongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LMaximum
            // 
            this.LMaximum.AutoSize = true;
            this.LMaximum.Font = new System.Drawing.Font("Bebas Neue", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LMaximum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LMaximum.Location = new System.Drawing.Point(225, 391);
            this.LMaximum.Name = "LMaximum";
            this.LMaximum.Size = new System.Drawing.Size(64, 21);
            this.LMaximum.TabIndex = 6;
            this.LMaximum.Text = "Maximum";
            this.LMaximum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LMinimum
            // 
            this.LMinimum.AutoSize = true;
            this.LMinimum.Font = new System.Drawing.Font("Bebas Neue", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LMinimum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LMinimum.Location = new System.Drawing.Point(22, 391);
            this.LMinimum.Name = "LMinimum";
            this.LMinimum.Size = new System.Drawing.Size(61, 21);
            this.LMinimum.TabIndex = 5;
            this.LMinimum.Text = "Minimum";
            this.LMinimum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBLogo
            // 
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(69, 29);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(171, 84);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 4;
            this.PBLogo.TabStop = false;
            // 
            // TBMinimum
            // 
            this.TBMinimum.BackColor = System.Drawing.Color.White;
            this.TBMinimum.Font = new System.Drawing.Font("Economica", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBMinimum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TBMinimum.Location = new System.Drawing.Point(24, 414);
            this.TBMinimum.Name = "TBMinimum";
            this.TBMinimum.Size = new System.Drawing.Size(55, 29);
            this.TBMinimum.TabIndex = 3;
            this.TBMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBMaximum
            // 
            this.TBMaximum.BackColor = System.Drawing.Color.White;
            this.TBMaximum.Font = new System.Drawing.Font("Economica", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBMaximum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TBMaximum.Location = new System.Drawing.Point(229, 414);
            this.TBMaximum.Name = "TBMaximum";
            this.TBMaximum.Size = new System.Drawing.Size(55, 29);
            this.TBMaximum.TabIndex = 2;
            this.TBMaximum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBBelongs
            // 
            this.TBBelongs.BackColor = System.Drawing.Color.White;
            this.TBBelongs.Font = new System.Drawing.Font("Economica", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBBelongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TBBelongs.Location = new System.Drawing.Point(95, 414);
            this.TBBelongs.Name = "TBBelongs";
            this.TBBelongs.Size = new System.Drawing.Size(118, 29);
            this.TBBelongs.TabIndex = 1;
            this.TBBelongs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBelongs.TextChanged += new System.EventHandler(this.Belongs_Valid);
            this.TBBelongs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Belongs_Text);
            // 
            // BGenerate
            // 
            this.BGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGenerate.Font = new System.Drawing.Font("Economica", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BGenerate.Location = new System.Drawing.Point(24, 482);
            this.BGenerate.Name = "BGenerate";
            this.BGenerate.Size = new System.Drawing.Size(260, 35);
            this.BGenerate.TabIndex = 0;
            this.BGenerate.Text = "Build";
            this.BGenerate.UseVisualStyleBackColor = true;
            this.BGenerate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // PBViewGraph
            // 
            this.PBViewGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PBViewGraph.Location = new System.Drawing.Point(476, 46);
            this.PBViewGraph.Name = "PBViewGraph";
            this.PBViewGraph.Size = new System.Drawing.Size(797, 460);
            this.PBViewGraph.TabIndex = 1;
            this.PBViewGraph.TabStop = false;
            // 
            // PBClose
            // 
            this.PBClose.Image = ((System.Drawing.Image)(resources.GetObject("PBClose.Image")));
            this.PBClose.Location = new System.Drawing.Point(1250, 13);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(21, 21);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 2;
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // PBMinimize
            // 
            this.PBMinimize.Image = ((System.Drawing.Image)(resources.GetObject("PBMinimize.Image")));
            this.PBMinimize.Location = new System.Drawing.Point(1218, 12);
            this.PBMinimize.Name = "PBMinimize";
            this.PBMinimize.Size = new System.Drawing.Size(23, 23);
            this.PBMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMinimize.TabIndex = 3;
            this.PBMinimize.TabStop = false;
            this.PBMinimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // PBBack
            // 
            this.PBBack.Image = ((System.Drawing.Image)(resources.GetObject("PBBack.Image")));
            this.PBBack.Location = new System.Drawing.Point(1189, 13);
            this.PBBack.Name = "PBBack";
            this.PBBack.Size = new System.Drawing.Size(21, 21);
            this.PBBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBBack.TabIndex = 4;
            this.PBBack.TabStop = false;
            this.PBBack.Click += new System.EventHandler(this.Back_Click);
            // 
            // LBTopologicalSorting
            // 
            this.LBTopologicalSorting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LBTopologicalSorting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBTopologicalSorting.Font = new System.Drawing.Font("Economica", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBTopologicalSorting.ForeColor = System.Drawing.Color.White;
            this.LBTopologicalSorting.FormattingEnabled = true;
            this.LBTopologicalSorting.ItemHeight = 23;
            this.LBTopologicalSorting.Location = new System.Drawing.Point(334, 46);
            this.LBTopologicalSorting.Name = "LBTopologicalSorting";
            this.LBTopologicalSorting.Size = new System.Drawing.Size(119, 460);
            this.LBTopologicalSorting.TabIndex = 5;
            // 
            // BView
            // 
            this.BView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BView.FlatAppearance.BorderSize = 0;
            this.BView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BView.Font = new System.Drawing.Font("Economica", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BView.ForeColor = System.Drawing.Color.White;
            this.BView.Location = new System.Drawing.Point(334, 471);
            this.BView.Name = "BView";
            this.BView.Size = new System.Drawing.Size(119, 35);
            this.BView.TabIndex = 6;
            this.BView.Text = "View";
            this.BView.UseVisualStyleBackColor = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1300, 540);
            this.Controls.Add(this.BView);
            this.Controls.Add(this.LBTopologicalSorting);
            this.Controls.Add(this.PBBack);
            this.Controls.Add(this.PBMinimize);
            this.Controls.Add(this.PBClose);
            this.Controls.Add(this.PBViewGraph);
            this.Controls.Add(this.PInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.PInfo.ResumeLayout(false);
            this.PInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBViewGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PInfo;
        private System.Windows.Forms.PictureBox PBViewGraph;
        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.PictureBox PBMinimize;
        private System.Windows.Forms.PictureBox PBBack;
        private System.Windows.Forms.ListBox LBTopologicalSorting;
        private System.Windows.Forms.Button BView;
        private System.Windows.Forms.Button BGenerate;
        private System.Windows.Forms.TextBox TBBelongs;
        private System.Windows.Forms.TextBox TBMaximum;
        private System.Windows.Forms.TextBox TBMinimum;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label LMinimum;
        private System.Windows.Forms.Label LMaximum;
        private System.Windows.Forms.Label LBelongs;
        private System.Windows.Forms.ListBox LBEdge;
        private System.Windows.Forms.ListBox LBVertex;
        private System.Windows.Forms.Label LVertex;
        private System.Windows.Forms.Label LEdge;
    }
}