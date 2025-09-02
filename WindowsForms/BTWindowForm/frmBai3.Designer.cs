
namespace BTWindowForm
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
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.txtSon = new System.Windows.Forms.TextBox();
            this.groupboxChon = new System.Windows.Forms.GroupBox();
            this.rdTongDaySo = new System.Windows.Forms.RadioButton();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupboxChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số n =";
            // 
            // txtSoa
            // 
            this.txtSoa.Location = new System.Drawing.Point(132, 27);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(100, 28);
            this.txtSoa.TabIndex = 1;
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(132, 79);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(100, 28);
            this.txtSob.TabIndex = 2;
            this.txtSob.TextChanged += new System.EventHandler(this.txtSoa_TextChanged);
            // 
            // txtSon
            // 
            this.txtSon.Location = new System.Drawing.Point(132, 130);
            this.txtSon.Name = "txtSon";
            this.txtSon.Size = new System.Drawing.Size(100, 28);
            this.txtSon.TabIndex = 3;
            this.txtSon.TextChanged += new System.EventHandler(this.txtSoa_TextChanged);
            // 
            // groupboxChon
            // 
            this.groupboxChon.Controls.Add(this.rdTongDaySo);
            this.groupboxChon.Controls.Add(this.rdCong);
            this.groupboxChon.Location = new System.Drawing.Point(48, 189);
            this.groupboxChon.Name = "groupboxChon";
            this.groupboxChon.Size = new System.Drawing.Size(200, 125);
            this.groupboxChon.TabIndex = 2;
            this.groupboxChon.TabStop = false;
            this.groupboxChon.Text = "Chọn phép tính";
            // 
            // rdTongDaySo
            // 
            this.rdTongDaySo.AutoSize = true;
            this.rdTongDaySo.Location = new System.Drawing.Point(19, 70);
            this.rdTongDaySo.Name = "rdTongDaySo";
            this.rdTongDaySo.Size = new System.Drawing.Size(151, 24);
            this.rdTongDaySo.TabIndex = 5;
            this.rdTongDaySo.Text = "Tổng từ 1 đến n";
            this.rdTongDaySo.UseVisualStyleBackColor = true;
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Checked = true;
            this.rdCong.Location = new System.Drawing.Point(19, 32);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(104, 24);
            this.rdCong.TabIndex = 4;
            this.rdCong.TabStop = true;
            this.rdCong.Text = "Cộng a, b";
            this.rdCong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả:";
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Location = new System.Drawing.Point(81, 332);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(137, 37);
            this.btnXemKQ.TabIndex = 6;
            this.btnXemKQ.Text = "Xem kết quả";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(110, 398);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(15, 23);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 458);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupboxChon);
            this.Controls.Add(this.txtSon);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupboxChon.ResumeLayout(false);
            this.groupboxChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.TextBox txtSon;
        private System.Windows.Forms.GroupBox groupboxChon;
        private System.Windows.Forms.RadioButton rdTongDaySo;
        private System.Windows.Forms.RadioButton rdCong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.Label lblKetQua;
    }
}