
namespace Lab_Basic_Command
{
    partial class AccountManager
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
            this.components = new System.ComponentModel.Container();
            this.grbLoc = new System.Windows.Forms.GroupBox();
            this.cboNhomLoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboNhomTK = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lvTaiKhoan = new System.Windows.Forms.ListView();
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenTaiKhoan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNhom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemXoaTK = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemXemDSVaiTro = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStripTongSo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStripDangChon = new System.Windows.Forms.ToolStripStatusLabel();
            this.grbLoc.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLoc
            // 
            this.grbLoc.Controls.Add(this.btnLoc);
            this.grbLoc.Controls.Add(this.cboTrangThai);
            this.grbLoc.Controls.Add(this.label2);
            this.grbLoc.Controls.Add(this.label1);
            this.grbLoc.Controls.Add(this.cboNhomLoc);
            this.grbLoc.Location = new System.Drawing.Point(14, 13);
            this.grbLoc.Name = "grbLoc";
            this.grbLoc.Size = new System.Drawing.Size(647, 64);
            this.grbLoc.TabIndex = 0;
            this.grbLoc.TabStop = false;
            this.grbLoc.Text = "Bộ lọc";
            // 
            // cboNhomLoc
            // 
            this.cboNhomLoc.FormattingEnabled = true;
            this.cboNhomLoc.Location = new System.Drawing.Point(73, 22);
            this.cboNhomLoc.Name = "cboNhomLoc";
            this.cboNhomLoc.Size = new System.Drawing.Size(126, 22);
            this.cboNhomLoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhóm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(287, 22);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(126, 22);
            this.cboTrangThai.TabIndex = 3;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(425, 21);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(80, 25);
            this.btnLoc.TabIndex = 1;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnLamMoi);
            this.grbThongTin.Controls.Add(this.btnReset);
            this.grbThongTin.Controls.Add(this.btnCapNhat);
            this.grbThongTin.Controls.Add(this.btnThem);
            this.grbThongTin.Controls.Add(this.cboNhomTK);
            this.grbThongTin.Controls.Add(this.txtEmail);
            this.grbThongTin.Controls.Add(this.txtHoTen);
            this.grbThongTin.Controls.Add(this.txtMatKhau);
            this.grbThongTin.Controls.Add(this.txtTenDN);
            this.grbThongTin.Controls.Add(this.chkTrangThai);
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.label6);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Location = new System.Drawing.Point(14, 83);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(647, 123);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Họ tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nhóm:";
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Location = new System.Drawing.Point(287, 91);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(82, 18);
            this.chkTrangThai.TabIndex = 5;
            this.chkTrangThai.Text = "Trạng thái";
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(103, 23);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(162, 22);
            this.txtTenDN.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(103, 55);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(162, 22);
            this.txtMatKhau.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(337, 21);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(162, 22);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(337, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // cboNhomTK
            // 
            this.cboNhomTK.FormattingEnabled = true;
            this.cboNhomTK.Location = new System.Drawing.Point(103, 91);
            this.cboNhomTK.Name = "cboNhomTK";
            this.cboNhomTK.Size = new System.Drawing.Size(126, 22);
            this.cboNhomTK.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(524, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 25);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(524, 54);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(68, 25);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(400, 88);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 25);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset mật khẩu";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(524, 88);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(68, 25);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // lvTaiKhoan
            // 
            this.lvTaiKhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clTenTaiKhoan,
            this.clHoTen,
            this.clEmail,
            this.clNhom,
            this.clTrangThai});
            this.lvTaiKhoan.ContextMenuStrip = this.contextMenu;
            this.lvTaiKhoan.FullRowSelect = true;
            this.lvTaiKhoan.GridLines = true;
            this.lvTaiKhoan.HideSelection = false;
            this.lvTaiKhoan.Location = new System.Drawing.Point(12, 212);
            this.lvTaiKhoan.Name = "lvTaiKhoan";
            this.lvTaiKhoan.Size = new System.Drawing.Size(649, 267);
            this.lvTaiKhoan.TabIndex = 2;
            this.lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            this.lvTaiKhoan.View = System.Windows.Forms.View.Details;
            this.lvTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.lvTaiKhoan_SelectedIndexChanged);
            // 
            // clID
            // 
            this.clID.Text = "ID";
            this.clID.Width = 40;
            // 
            // clTenTaiKhoan
            // 
            this.clTenTaiKhoan.Text = "Tên tài khoản";
            this.clTenTaiKhoan.Width = 100;
            // 
            // clHoTen
            // 
            this.clHoTen.Text = "Họ và tên";
            this.clHoTen.Width = 150;
            // 
            // clEmail
            // 
            this.clEmail.Text = "Email";
            this.clEmail.Width = 100;
            // 
            // clNhom
            // 
            this.clNhom.Text = "Nhóm";
            // 
            // clTrangThai
            // 
            this.clTrangThai.Text = "Trạng thái";
            this.clTrangThai.Width = 70;
            // 
            // contextMenu
            // 
            this.contextMenu.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemXoaTK,
            this.ItemXemDSVaiTro});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(197, 48);
            // 
            // ItemXoaTK
            // 
            this.ItemXoaTK.Name = "ItemXoaTK";
            this.ItemXoaTK.Size = new System.Drawing.Size(196, 22);
            this.ItemXoaTK.Text = "Xóa tài khoản";
            // 
            // ItemXemDSVaiTro
            // 
            this.ItemXemDSVaiTro.Name = "ItemXemDSVaiTro";
            this.ItemXemDSVaiTro.Size = new System.Drawing.Size(196, 22);
            this.ItemXemDSVaiTro.Text = "Xem danh sách vai trò";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStripTongSo,
            this.lblStripDangChon});
            this.statusStrip.Location = new System.Drawing.Point(0, 482);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(675, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStripTongSo
            // 
            this.lblStripTongSo.Name = "lblStripTongSo";
            this.lblStripTongSo.Size = new System.Drawing.Size(52, 17);
            this.lblStripTongSo.Text = "Tổng số:";
            // 
            // lblStripDangChon
            // 
            this.lblStripDangChon.Name = "lblStripDangChon";
            this.lblStripDangChon.Size = new System.Drawing.Size(68, 17);
            this.lblStripDangChon.Text = "Đang chọn:";
            this.lblStripDangChon.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 504);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lvTaiKhoan);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grbLoc);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AccountManager";
            this.Text = "Danh sách tài khoản";
            this.Load += new System.EventHandler(this.AccountManager_Load);
            this.grbLoc.ResumeLayout(false);
            this.grbLoc.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLoc;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNhomLoc;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNhomTK;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView lvTaiKhoan;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.ColumnHeader clTenTaiKhoan;
        private System.Windows.Forms.ColumnHeader clHoTen;
        private System.Windows.Forms.ColumnHeader clEmail;
        private System.Windows.Forms.ColumnHeader clNhom;
        private System.Windows.Forms.ColumnHeader clTrangThai;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ItemXoaTK;
        private System.Windows.Forms.ToolStripMenuItem ItemXemDSVaiTro;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStripTongSo;
        private System.Windows.Forms.ToolStripStatusLabel lblStripDangChon;
    }
}