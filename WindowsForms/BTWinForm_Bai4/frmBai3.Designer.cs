
namespace BTWinForm_Bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.btnChao = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số m:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số n:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(101, 20);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(219, 28);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(101, 116);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(104, 28);
            this.txtM.TabIndex = 4;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(101, 160);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(104, 28);
            this.txtN.TabIndex = 5;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(107, 72);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(69, 24);
            this.rdNam.TabIndex = 2;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(198, 72);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(57, 24);
            this.rdNu.TabIndex = 3;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // btnChao
            // 
            this.btnChao.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChao.Location = new System.Drawing.Point(26, 218);
            this.btnChao.Name = "btnChao";
            this.btnChao.Size = new System.Drawing.Size(107, 45);
            this.btnChao.TabIndex = 6;
            this.btnChao.Text = "Chào hỏi";
            this.btnChao.UseVisualStyleBackColor = true;
            this.btnChao.Click += new System.EventHandler(this.btnChao_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(213, 218);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(107, 45);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính USLN";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kết quả:";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(102, 339);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(15, 23);
            this.lblKQ.TabIndex = 0;
            this.lblKQ.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 417);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnChao);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Button btnChao;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKQ;
    }
}