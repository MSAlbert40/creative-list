
namespace creative_list
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.PBMinimize = new System.Windows.Forms.PictureBox();
            this.PBSecond = new System.Windows.Forms.PictureBox();
            this.PBFirst = new System.Windows.Forms.PictureBox();
            this.PBThird = new System.Windows.Forms.PictureBox();
            this.PBBanner = new System.Windows.Forms.PictureBox();
            this.LInstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // PBClose
            // 
            this.PBClose.Image = ((System.Drawing.Image)(resources.GetObject("PBClose.Image")));
            this.PBClose.Location = new System.Drawing.Point(1250, 13);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(21, 21);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 3;
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
            this.PBMinimize.TabIndex = 4;
            this.PBMinimize.TabStop = false;
            this.PBMinimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // PBSecond
            // 
            this.PBSecond.Image = ((System.Drawing.Image)(resources.GetObject("PBSecond.Image")));
            this.PBSecond.Location = new System.Drawing.Point(543, 124);
            this.PBSecond.Name = "PBSecond";
            this.PBSecond.Size = new System.Drawing.Size(240, 256);
            this.PBSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSecond.TabIndex = 6;
            this.PBSecond.TabStop = false;
            this.PBSecond.Click += new System.EventHandler(this.Wear_Click);
            // 
            // PBFirst
            // 
            this.PBFirst.Image = ((System.Drawing.Image)(resources.GetObject("PBFirst.Image")));
            this.PBFirst.Location = new System.Drawing.Point(217, 124);
            this.PBFirst.Name = "PBFirst";
            this.PBFirst.Size = new System.Drawing.Size(240, 256);
            this.PBFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBFirst.TabIndex = 11;
            this.PBFirst.TabStop = false;
            this.PBFirst.Click += new System.EventHandler(this.Pizza_Click);
            // 
            // PBThird
            // 
            this.PBThird.Image = ((System.Drawing.Image)(resources.GetObject("PBThird.Image")));
            this.PBThird.Location = new System.Drawing.Point(869, 124);
            this.PBThird.Name = "PBThird";
            this.PBThird.Size = new System.Drawing.Size(240, 256);
            this.PBThird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBThird.TabIndex = 12;
            this.PBThird.TabStop = false;
            // 
            // PBBanner
            // 
            this.PBBanner.Image = ((System.Drawing.Image)(resources.GetObject("PBBanner.Image")));
            this.PBBanner.Location = new System.Drawing.Point(336, 0);
            this.PBBanner.Name = "PBBanner";
            this.PBBanner.Size = new System.Drawing.Size(628, 68);
            this.PBBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBBanner.TabIndex = 13;
            this.PBBanner.TabStop = false;
            // 
            // LInstruction
            // 
            this.LInstruction.AutoSize = true;
            this.LInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(224)))), ((int)(((byte)(196)))));
            this.LInstruction.Font = new System.Drawing.Font("Economica", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.LInstruction.Location = new System.Drawing.Point(494, 439);
            this.LInstruction.Name = "LInstruction";
            this.LInstruction.Size = new System.Drawing.Size(312, 25);
            this.LInstruction.TabIndex = 14;
            this.LInstruction.Text = "Choose an option from the center buttons";
            this.LInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1300, 540);
            this.Controls.Add(this.LInstruction);
            this.Controls.Add(this.PBBanner);
            this.Controls.Add(this.PBThird);
            this.Controls.Add(this.PBFirst);
            this.Controls.Add(this.PBSecond);
            this.Controls.Add(this.PBMinimize);
            this.Controls.Add(this.PBClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.PictureBox PBMinimize;
        private System.Windows.Forms.PictureBox PBSecond;
        private System.Windows.Forms.PictureBox PBFirst;
        private System.Windows.Forms.PictureBox PBThird;
        private System.Windows.Forms.PictureBox PBBanner;
        private System.Windows.Forms.Label LInstruction;
    }
}