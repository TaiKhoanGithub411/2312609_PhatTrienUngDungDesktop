
namespace MainForm
{
    partial class BillCatalogForm
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
            this.lbDSNgay = new System.Windows.Forms.ListBox();
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblThue = new System.Windows.Forms.Label();
            this.lblThucThu = new System.Windows.Forms.Label();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.clIDSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSLSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGiaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTongTienSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDSNgay
            // 
            this.lbDSNgay.FormattingEnabled = true;
            this.lbDSNgay.ItemHeight = 15;
            this.lbDSNgay.Location = new System.Drawing.Point(12, 12);
            this.lbDSNgay.Name = "lbDSNgay";
            this.lbDSNgay.Size = new System.Drawing.Size(89, 334);
            this.lbDSNgay.TabIndex = 0;
            this.lbDSNgay.SelectedIndexChanged += new System.EventHandler(this.lbDSNgay_SelectedIndexChanged);
            // 
            // grbDetail
            // 
            this.grbDetail.Controls.Add(this.lvSanPham);
            this.grbDetail.Controls.Add(this.lblThucThu);
            this.grbDetail.Controls.Add(this.lblThue);
            this.grbDetail.Controls.Add(this.lblGiamGia);
            this.grbDetail.Controls.Add(this.lblTongTien);
            this.grbDetail.Controls.Add(this.lblNhanVien);
            this.grbDetail.Controls.Add(this.lblNgayLap);
            this.grbDetail.Controls.Add(this.lblSoHD);
            this.grbDetail.Controls.Add(this.label7);
            this.grbDetail.Controls.Add(this.label6);
            this.grbDetail.Controls.Add(this.label5);
            this.grbDetail.Controls.Add(this.label4);
            this.grbDetail.Controls.Add(this.label3);
            this.grbDetail.Controls.Add(this.label2);
            this.grbDetail.Controls.Add(this.label1);
            this.grbDetail.Location = new System.Drawing.Point(107, 12);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(363, 334);
            this.grbDetail.TabIndex = 1;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Thông tin chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giảm giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thực thu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thuế:";
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Location = new System.Drawing.Point(72, 26);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(73, 15);
            this.lblSoHD.TabIndex = 7;
            this.lblSoHD.Text = "___________";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(72, 58);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(73, 15);
            this.lblNgayLap.TabIndex = 8;
            this.lblNgayLap.Text = "___________";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(72, 91);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(73, 15);
            this.lblNhanVien.TabIndex = 9;
            this.lblNhanVien.Text = "___________";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(72, 127);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(73, 15);
            this.lblTongTien.TabIndex = 10;
            this.lblTongTien.Text = "___________";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(235, 26);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(73, 15);
            this.lblGiamGia.TabIndex = 11;
            this.lblGiamGia.Text = "___________";
            // 
            // lblThue
            // 
            this.lblThue.AutoSize = true;
            this.lblThue.Location = new System.Drawing.Point(235, 58);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(73, 15);
            this.lblThue.TabIndex = 12;
            this.lblThue.Text = "___________";
            // 
            // lblThucThu
            // 
            this.lblThucThu.AutoSize = true;
            this.lblThucThu.Location = new System.Drawing.Point(235, 92);
            this.lblThucThu.Name = "lblThucThu";
            this.lblThucThu.Size = new System.Drawing.Size(73, 15);
            this.lblThucThu.TabIndex = 13;
            this.lblThucThu.Text = "___________";
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clIDSanPham,
            this.clTenSP,
            this.clSLSP,
            this.clGiaSP,
            this.clTongTienSP});
            this.lvSanPham.GridLines = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(6, 157);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(351, 171);
            this.lvSanPham.TabIndex = 14;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // clIDSanPham
            // 
            this.clIDSanPham.Text = "ID";
            this.clIDSanPham.Width = 40;
            // 
            // clTenSP
            // 
            this.clTenSP.Text = "Tên SP";
            this.clTenSP.Width = 80;
            // 
            // clSLSP
            // 
            this.clSLSP.Text = "Số lượng";
            // 
            // clGiaSP
            // 
            this.clGiaSP.Text = "Giá";
            this.clGiaSP.Width = 70;
            // 
            // clTongTienSP
            // 
            this.clTongTienSP.Text = "Tổng tiền";
            this.clTongTienSP.Width = 80;
            // 
            // BillCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 355);
            this.Controls.Add(this.grbDetail);
            this.Controls.Add(this.lbDSNgay);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BillCatalogForm";
            this.Load += new System.EventHandler(this.BillCatalogForm_Load);
            this.grbDetail.ResumeLayout(false);
            this.grbDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDSNgay;
        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThucThu;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader clIDSanPham;
        private System.Windows.Forms.ColumnHeader clTenSP;
        private System.Windows.Forms.ColumnHeader clSLSP;
        private System.Windows.Forms.ColumnHeader clGiaSP;
        private System.Windows.Forms.ColumnHeader clTongTienSP;
    }
}