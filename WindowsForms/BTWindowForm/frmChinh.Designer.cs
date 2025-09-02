
namespace BTWindowForm
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.tsbMenu = new System.Windows.Forms.ToolStrip();
            this.tsbBai1 = new System.Windows.Forms.ToolStripButton();
            this.tsbBai2 = new System.Windows.Forms.ToolStripButton();
            this.tsbBai3 = new System.Windows.Forms.ToolStripButton();
            this.tsbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbMenu
            // 
            this.tsbMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsbMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBai1,
            this.tsbBai2,
            this.tsbBai3});
            this.tsbMenu.Location = new System.Drawing.Point(0, 0);
            this.tsbMenu.Name = "tsbMenu";
            this.tsbMenu.Size = new System.Drawing.Size(467, 34);
            this.tsbMenu.TabIndex = 0;
            this.tsbMenu.Text = "toolStrip1";
            // 
            // tsbBai1
            // 
            this.tsbBai1.Image = ((System.Drawing.Image)(resources.GetObject("tsbBai1.Image")));
            this.tsbBai1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBai1.Name = "tsbBai1";
            this.tsbBai1.Size = new System.Drawing.Size(78, 29);
            this.tsbBai1.Text = "Bài 1";
            this.tsbBai1.Click += new System.EventHandler(this.tsbBai1_Click);
            // 
            // tsbBai2
            // 
            this.tsbBai2.Image = ((System.Drawing.Image)(resources.GetObject("tsbBai2.Image")));
            this.tsbBai2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBai2.Name = "tsbBai2";
            this.tsbBai2.Size = new System.Drawing.Size(78, 29);
            this.tsbBai2.Text = "Bài 2";
            this.tsbBai2.Click += new System.EventHandler(this.tsbBai2_Click);
            // 
            // tsbBai3
            // 
            this.tsbBai3.Image = ((System.Drawing.Image)(resources.GetObject("tsbBai3.Image")));
            this.tsbBai3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBai3.Name = "tsbBai3";
            this.tsbBai3.Size = new System.Drawing.Size(78, 29);
            this.tsbBai3.Text = "Bài 3";
            this.tsbBai3.Click += new System.EventHandler(this.tsbBai3_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 284);
            this.Controls.Add(this.tsbMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmChinh";
            this.Text = "Chương trình chính";
            this.tsbMenu.ResumeLayout(false);
            this.tsbMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsbMenu;
        private System.Windows.Forms.ToolStripButton tsbBai1;
        private System.Windows.Forms.ToolStripButton tsbBai2;
        private System.Windows.Forms.ToolStripButton tsbBai3;
    }
}

