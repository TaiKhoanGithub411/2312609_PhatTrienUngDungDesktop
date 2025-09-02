
namespace BTWinForm_Bai4
{
    partial class frmBai1
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
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.btnTinhHSD = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên SP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại SP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày SX:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(117, 24);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 28);
            this.txtMa.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(117, 69);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 28);
            this.txtTen.TabIndex = 2;
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(117, 115);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(100, 28);
            this.txtLoai.TabIndex = 3;
            // 
            // dtpNgaySX
            // 
            this.dtpNgaySX.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySX.Location = new System.Drawing.Point(117, 164);
            this.dtpNgaySX.Name = "dtpNgaySX";
            this.dtpNgaySX.Size = new System.Drawing.Size(123, 28);
            this.dtpNgaySX.TabIndex = 4;
            // 
            // btnTinhHSD
            // 
            this.btnTinhHSD.Location = new System.Drawing.Point(42, 240);
            this.btnTinhHSD.Name = "btnTinhHSD";
            this.btnTinhHSD.Size = new System.Drawing.Size(97, 42);
            this.btnTinhHSD.TabIndex = 5;
            this.btnTinhHSD.Text = "Tính HSD";
            this.btnTinhHSD.UseVisualStyleBackColor = true;
            this.btnTinhHSD.Click += new System.EventHandler(this.btnTinhHSD_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(160, 240);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(97, 42);
            this.btnHienThi.TabIndex = 6;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kết quả:";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(28, 357);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(15, 23);
            this.lblKQ.TabIndex = 7;
            this.lblKQ.Text = ".";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 536);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnTinhHSD);
            this.Controls.Add(this.dtpNgaySX);
            this.Controls.Add(this.txtLoai);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBai1";
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.Button btnTinhHSD;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKQ;
    }
}