
namespace HuongDanCoBan_Bai2
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
            this.gboChonGT = new System.Windows.Forms.GroupBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.gboChonMau = new System.Windows.Forms.GroupBox();
            this.rdMauXanh = new System.Windows.Forms.RadioButton();
            this.rdMauDo = new System.Windows.Forms.RadioButton();
            this.btnToMau = new System.Windows.Forms.Button();
            this.txtHopMau = new System.Windows.Forms.TextBox();
            this.gboChonGT.SuspendLayout();
            this.gboChonMau.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboChonGT
            // 
            this.gboChonGT.Controls.Add(this.rdNu);
            this.gboChonGT.Controls.Add(this.rdNam);
            this.gboChonGT.Location = new System.Drawing.Point(12, 12);
            this.gboChonGT.Name = "gboChonGT";
            this.gboChonGT.Size = new System.Drawing.Size(248, 144);
            this.gboChonGT.TabIndex = 0;
            this.gboChonGT.TabStop = false;
            this.gboChonGT.Text = "Chọn giới tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(34, 43);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(69, 24);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(34, 87);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(57, 24);
            this.rdNu.TabIndex = 1;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // gboChonMau
            // 
            this.gboChonMau.Controls.Add(this.txtHopMau);
            this.gboChonMau.Controls.Add(this.btnToMau);
            this.gboChonMau.Controls.Add(this.rdMauXanh);
            this.gboChonMau.Controls.Add(this.rdMauDo);
            this.gboChonMau.Location = new System.Drawing.Point(12, 162);
            this.gboChonMau.Name = "gboChonMau";
            this.gboChonMau.Size = new System.Drawing.Size(580, 144);
            this.gboChonMau.TabIndex = 2;
            this.gboChonMau.TabStop = false;
            this.gboChonMau.Text = "Chọn màu";
            // 
            // rdMauXanh
            // 
            this.rdMauXanh.AutoSize = true;
            this.rdMauXanh.Location = new System.Drawing.Point(34, 87);
            this.rdMauXanh.Name = "rdMauXanh";
            this.rdMauXanh.Size = new System.Drawing.Size(106, 24);
            this.rdMauXanh.TabIndex = 1;
            this.rdMauXanh.TabStop = true;
            this.rdMauXanh.Text = "Màu xanh";
            this.rdMauXanh.UseVisualStyleBackColor = true;
            // 
            // rdMauDo
            // 
            this.rdMauDo.AutoSize = true;
            this.rdMauDo.Checked = true;
            this.rdMauDo.Location = new System.Drawing.Point(34, 43);
            this.rdMauDo.Name = "rdMauDo";
            this.rdMauDo.Size = new System.Drawing.Size(90, 24);
            this.rdMauDo.TabIndex = 0;
            this.rdMauDo.TabStop = true;
            this.rdMauDo.Text = "Màu đỏ";
            this.rdMauDo.UseVisualStyleBackColor = true;
            // 
            // btnToMau
            // 
            this.btnToMau.Location = new System.Drawing.Point(166, 62);
            this.btnToMau.Name = "btnToMau";
            this.btnToMau.Size = new System.Drawing.Size(82, 33);
            this.btnToMau.TabIndex = 2;
            this.btnToMau.Text = "Tô màu";
            this.btnToMau.UseVisualStyleBackColor = true;
            this.btnToMau.Click += new System.EventHandler(this.btnToMau_Click);
            // 
            // txtHopMau
            // 
            this.txtHopMau.Location = new System.Drawing.Point(270, 42);
            this.txtHopMau.Multiline = true;
            this.txtHopMau.Name = "txtHopMau";
            this.txtHopMau.Size = new System.Drawing.Size(291, 69);
            this.txtHopMau.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 343);
            this.Controls.Add(this.gboChonMau);
            this.Controls.Add(this.gboChonGT);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "HDCB_BT2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gboChonGT.ResumeLayout(false);
            this.gboChonGT.PerformLayout();
            this.gboChonMau.ResumeLayout(false);
            this.gboChonMau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboChonGT;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.GroupBox gboChonMau;
        private System.Windows.Forms.RadioButton rdMauXanh;
        private System.Windows.Forms.RadioButton rdMauDo;
        private System.Windows.Forms.TextBox txtHopMau;
        private System.Windows.Forms.Button btnToMau;
    }
}

