
namespace BTTKForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHangHoa = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKhachMua = new System.Windows.Forms.ListBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChon);
            this.panel1.Controls.Add(this.lbHangHoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 380);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hàng hóa:";
            // 
            // lbHangHoa
            // 
            this.lbHangHoa.FormattingEnabled = true;
            this.lbHangHoa.ItemHeight = 20;
            this.lbHangHoa.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USB Kingmax"});
            this.lbHangHoa.Location = new System.Drawing.Point(22, 52);
            this.lbHangHoa.Name = "lbHangHoa";
            this.lbHangHoa.Size = new System.Drawing.Size(253, 204);
            this.lbHangHoa.TabIndex = 1;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(326, 136);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(116, 37);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn hàng >";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTinhTien);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.lbKhachMua);
            this.panel2.Controls.Add(this.lblSoTien);
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(510, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 380);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Các mặt hàng khách mua:";
            // 
            // lbKhachMua
            // 
            this.lbKhachMua.FormattingEnabled = true;
            this.lbKhachMua.ItemHeight = 20;
            this.lbKhachMua.Location = new System.Drawing.Point(201, 52);
            this.lbKhachMua.Name = "lbKhachMua";
            this.lbKhachMua.Size = new System.Drawing.Size(253, 204);
            this.lbKhachMua.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(33, 136);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 37);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "< Bỏ hàng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.Blue;
            this.btnTinhTien.Location = new System.Drawing.Point(262, 281);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(116, 37);
            this.btnTinhTien.TabIndex = 2;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(5, 335);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(233, 26);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng tiền thanh toán:";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.ForeColor = System.Drawing.Color.Blue;
            this.lblSoTien.Location = new System.Drawing.Point(257, 335);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(18, 26);
            this.lblSoTien.TabIndex = 0;
            this.lblSoTien.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 409);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBai2";
            this.Text = "Bán hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ListBox lbHangHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox lbKhachMua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblSoTien;
    }
}