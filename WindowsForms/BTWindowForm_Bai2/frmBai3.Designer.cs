
namespace BTWindowForm_Bai2
{
    partial class frmBai3
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupboxNoiChuoi = new System.Windows.Forms.GroupBox();
            this.groupboxGiaiThua = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnNoiChuoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQuaNoiChuoi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSon = new System.Windows.Forms.TextBox();
            this.btnTinhGiaiThua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKetQuaGiaiThua = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupboxNoiChuoi.SuspendLayout();
            this.groupboxGiaiThua.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupboxNoiChuoi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupboxGiaiThua);
            this.splitContainer1.Size = new System.Drawing.Size(889, 353);
            this.splitContainer1.SplitterDistance = 437;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupboxNoiChuoi
            // 
            this.groupboxNoiChuoi.Controls.Add(this.lblKetQuaNoiChuoi);
            this.groupboxNoiChuoi.Controls.Add(this.label3);
            this.groupboxNoiChuoi.Controls.Add(this.btnNoiChuoi);
            this.groupboxNoiChuoi.Controls.Add(this.txtTen);
            this.groupboxNoiChuoi.Controls.Add(this.txtHo);
            this.groupboxNoiChuoi.Controls.Add(this.label2);
            this.groupboxNoiChuoi.Controls.Add(this.label1);
            this.groupboxNoiChuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupboxNoiChuoi.Location = new System.Drawing.Point(0, 0);
            this.groupboxNoiChuoi.Name = "groupboxNoiChuoi";
            this.groupboxNoiChuoi.Size = new System.Drawing.Size(437, 353);
            this.groupboxNoiChuoi.TabIndex = 0;
            this.groupboxNoiChuoi.TabStop = false;
            this.groupboxNoiChuoi.Text = "Nối chuỗi";
            // 
            // groupboxGiaiThua
            // 
            this.groupboxGiaiThua.Controls.Add(this.txtSon);
            this.groupboxGiaiThua.Controls.Add(this.lblKetQuaGiaiThua);
            this.groupboxGiaiThua.Controls.Add(this.label5);
            this.groupboxGiaiThua.Controls.Add(this.label4);
            this.groupboxGiaiThua.Controls.Add(this.btnTinhGiaiThua);
            this.groupboxGiaiThua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupboxGiaiThua.Location = new System.Drawing.Point(0, 0);
            this.groupboxGiaiThua.Name = "groupboxGiaiThua";
            this.groupboxGiaiThua.Size = new System.Drawing.Size(448, 353);
            this.groupboxGiaiThua.TabIndex = 0;
            this.groupboxGiaiThua.TabStop = false;
            this.groupboxGiaiThua.Text = "Tính giai thừa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập tên:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(118, 36);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(193, 28);
            this.txtHo.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(118, 89);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(193, 28);
            this.txtTen.TabIndex = 2;
            // 
            // btnNoiChuoi
            // 
            this.btnNoiChuoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoiChuoi.ForeColor = System.Drawing.Color.Blue;
            this.btnNoiChuoi.Location = new System.Drawing.Point(118, 150);
            this.btnNoiChuoi.Name = "btnNoiChuoi";
            this.btnNoiChuoi.Size = new System.Drawing.Size(142, 44);
            this.btnNoiChuoi.TabIndex = 3;
            this.btnNoiChuoi.Text = "Nối chuỗi";
            this.btnNoiChuoi.UseVisualStyleBackColor = true;
            this.btnNoiChuoi.Click += new System.EventHandler(this.btnNoiChuoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả:";
            // 
            // lblKetQuaNoiChuoi
            // 
            this.lblKetQuaNoiChuoi.AutoSize = true;
            this.lblKetQuaNoiChuoi.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaNoiChuoi.Location = new System.Drawing.Point(122, 271);
            this.lblKetQuaNoiChuoi.Name = "lblKetQuaNoiChuoi";
            this.lblKetQuaNoiChuoi.Size = new System.Drawing.Size(18, 25);
            this.lblKetQuaNoiChuoi.TabIndex = 4;
            this.lblKetQuaNoiChuoi.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập số n:";
            // 
            // txtSon
            // 
            this.txtSon.Location = new System.Drawing.Point(131, 36);
            this.txtSon.Name = "txtSon";
            this.txtSon.Size = new System.Drawing.Size(100, 28);
            this.txtSon.TabIndex = 1;
            // 
            // btnTinhGiaiThua
            // 
            this.btnTinhGiaiThua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhGiaiThua.ForeColor = System.Drawing.Color.Blue;
            this.btnTinhGiaiThua.Location = new System.Drawing.Point(107, 101);
            this.btnTinhGiaiThua.Name = "btnTinhGiaiThua";
            this.btnTinhGiaiThua.Size = new System.Drawing.Size(142, 44);
            this.btnTinhGiaiThua.TabIndex = 3;
            this.btnTinhGiaiThua.Text = "Tính giai thừa";
            this.btnTinhGiaiThua.UseVisualStyleBackColor = true;
            this.btnTinhGiaiThua.Click += new System.EventHandler(this.btnTinhGiaiThua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kết quả:";
            // 
            // lblKetQuaGiaiThua
            // 
            this.lblKetQuaGiaiThua.AutoSize = true;
            this.lblKetQuaGiaiThua.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaGiaiThua.Location = new System.Drawing.Point(136, 271);
            this.lblKetQuaGiaiThua.Name = "lblKetQuaGiaiThua";
            this.lblKetQuaGiaiThua.Size = new System.Drawing.Size(18, 25);
            this.lblKetQuaGiaiThua.TabIndex = 4;
            this.lblKetQuaGiaiThua.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 353);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBai3";
            this.Text = "Nối chuỗi - Tính giai thừa";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupboxNoiChuoi.ResumeLayout(false);
            this.groupboxNoiChuoi.PerformLayout();
            this.groupboxGiaiThua.ResumeLayout(false);
            this.groupboxGiaiThua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupboxNoiChuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupboxGiaiThua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKetQuaNoiChuoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNoiChuoi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtSon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQuaGiaiThua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTinhGiaiThua;
    }
}