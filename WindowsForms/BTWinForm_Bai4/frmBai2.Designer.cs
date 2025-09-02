
namespace BTWinForm_Bai4
{
    partial class frmBai2
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
            this.txtLyThuyet = new System.Windows.Forms.TextBox();
            this.txtThucHanh = new System.Windows.Forms.TextBox();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập điểm lý thuyết:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập điểm thực hành:";
            // 
            // txtLyThuyet
            // 
            this.txtLyThuyet.Location = new System.Drawing.Point(223, 26);
            this.txtLyThuyet.Name = "txtLyThuyet";
            this.txtLyThuyet.Size = new System.Drawing.Size(100, 28);
            this.txtLyThuyet.TabIndex = 1;
            // 
            // txtThucHanh
            // 
            this.txtThucHanh.Location = new System.Drawing.Point(223, 75);
            this.txtThucHanh.Name = "txtThucHanh";
            this.txtThucHanh.Size = new System.Drawing.Size(100, 28);
            this.txtThucHanh.TabIndex = 2;
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Location = new System.Drawing.Point(124, 136);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(125, 40);
            this.btnXepLoai.TabIndex = 3;
            this.btnXepLoai.Text = "Xếp loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả xếp loại:";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.ForeColor = System.Drawing.Color.Red;
            this.lblKQ.Location = new System.Drawing.Point(201, 218);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(18, 26);
            this.lblKQ.TabIndex = 3;
            this.lblKQ.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 369);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.txtThucHanh);
            this.Controls.Add(this.txtLyThuyet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLyThuyet;
        private System.Windows.Forms.TextBox txtThucHanh;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKQ;
    }
}