
namespace BTWinForm_Bai3
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
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupboxChon = new System.Windows.Forms.GroupBox();
            this.rdTong = new System.Windows.Forms.RadioButton();
            this.rdGiaiThua = new System.Windows.Forms.RadioButton();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.groupboxChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập một số nguyên dương N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết quả:";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(250, 19);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(131, 28);
            this.txtSoN.TabIndex = 2;
            // 
            // groupboxChon
            // 
            this.groupboxChon.Controls.Add(this.rdGiaiThua);
            this.groupboxChon.Controls.Add(this.rdTong);
            this.groupboxChon.Location = new System.Drawing.Point(44, 73);
            this.groupboxChon.Name = "groupboxChon";
            this.groupboxChon.Size = new System.Drawing.Size(288, 137);
            this.groupboxChon.TabIndex = 3;
            this.groupboxChon.TabStop = false;
            this.groupboxChon.Text = "Chọn công việc";
            // 
            // rdTong
            // 
            this.rdTong.AutoSize = true;
            this.rdTong.Location = new System.Drawing.Point(31, 34);
            this.rdTong.Name = "rdTong";
            this.rdTong.Size = new System.Drawing.Size(186, 24);
            this.rdTong.TabIndex = 0;
            this.rdTong.TabStop = true;
            this.rdTong.Text = "Tính tổng 1+2+...+N";
            this.rdTong.UseVisualStyleBackColor = true;
            // 
            // rdGiaiThua
            // 
            this.rdGiaiThua.AutoSize = true;
            this.rdGiaiThua.Location = new System.Drawing.Point(31, 79);
            this.rdGiaiThua.Name = "rdGiaiThua";
            this.rdGiaiThua.Size = new System.Drawing.Size(153, 24);
            this.rdGiaiThua.TabIndex = 0;
            this.rdGiaiThua.TabStop = true;
            this.rdGiaiThua.Text = "Tính N giai thừa";
            this.rdGiaiThua.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(109, 230);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(152, 52);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Xem kết quả";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(125, 322);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(18, 25);
            this.lblKQ.TabIndex = 1;
            this.lblKQ.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 382);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.groupboxChon);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBai2";
            this.Text = "Bài tập 2";
            this.groupboxChon.ResumeLayout(false);
            this.groupboxChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupboxChon;
        private System.Windows.Forms.RadioButton rdGiaiThua;
        private System.Windows.Forms.RadioButton rdTong;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lblKQ;
    }
}