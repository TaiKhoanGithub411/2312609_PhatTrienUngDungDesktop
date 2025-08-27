
namespace BTWindowForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupboxThanhToan = new System.Windows.Forms.GroupBox();
            this.rdChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.rdTienMat = new System.Windows.Forms.RadioButton();
            this.cboTenHang = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.groupboxThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng:";
            // 
            // groupboxThanhToan
            // 
            this.groupboxThanhToan.Controls.Add(this.rdTienMat);
            this.groupboxThanhToan.Controls.Add(this.rdChuyenKhoan);
            this.groupboxThanhToan.Location = new System.Drawing.Point(115, 184);
            this.groupboxThanhToan.Name = "groupboxThanhToan";
            this.groupboxThanhToan.Size = new System.Drawing.Size(200, 100);
            this.groupboxThanhToan.TabIndex = 2;
            this.groupboxThanhToan.TabStop = false;
            this.groupboxThanhToan.Text = "Hình thức thanh toán";
            // 
            // rdChuyenKhoan
            // 
            this.rdChuyenKhoan.AutoSize = true;
            this.rdChuyenKhoan.Checked = true;
            this.rdChuyenKhoan.Location = new System.Drawing.Point(25, 27);
            this.rdChuyenKhoan.Name = "rdChuyenKhoan";
            this.rdChuyenKhoan.Size = new System.Drawing.Size(139, 24);
            this.rdChuyenKhoan.TabIndex = 0;
            this.rdChuyenKhoan.TabStop = true;
            this.rdChuyenKhoan.Text = "Chuyển khoản";
            this.rdChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // rdTienMat
            // 
            this.rdTienMat.AutoSize = true;
            this.rdTienMat.Location = new System.Drawing.Point(25, 57);
            this.rdTienMat.Name = "rdTienMat";
            this.rdTienMat.Size = new System.Drawing.Size(99, 24);
            this.rdTienMat.TabIndex = 0;
            this.rdTienMat.Text = "Tiền mặt";
            this.rdTienMat.UseVisualStyleBackColor = true;
            // 
            // cboTenHang
            // 
            this.cboTenHang.FormattingEnabled = true;
            this.cboTenHang.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím"});
            this.cboTenHang.Location = new System.Drawing.Point(204, 27);
            this.cboTenHang.Name = "cboTenHang";
            this.cboTenHang.Size = new System.Drawing.Size(121, 28);
            this.cboTenHang.TabIndex = 3;
            this.cboTenHang.SelectedIndexChanged += new System.EventHandler(this.cboTenHang_SelectedIndexChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(204, 80);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(121, 28);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(204, 131);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 28);
            this.txtSoLuong.TabIndex = 4;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.Blue;
            this.btnTinhTien.Location = new System.Drawing.Point(160, 303);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(105, 44);
            this.btnTinhTien.TabIndex = 5;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số tiền thanh toán:";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.Location = new System.Drawing.Point(250, 379);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(23, 25);
            this.lblSoTien.TabIndex = 0;
            this.lblSoTien.Text = "0";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 424);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.cboTenHang);
            this.Controls.Add(this.groupboxThanhToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.groupboxThanhToan.ResumeLayout(false);
            this.groupboxThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupboxThanhToan;
        private System.Windows.Forms.RadioButton rdTienMat;
        private System.Windows.Forms.RadioButton rdChuyenKhoan;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoTien;
    }
}