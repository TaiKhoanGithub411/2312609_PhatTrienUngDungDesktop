
namespace MainForm
{
    partial class MainForm
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
            this.lvBan = new System.Windows.Forms.ListView();
            this.clIDBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSucChua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemXoaBan = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDMHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemNKHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.gbThongTinBan = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemHD = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.txtSucChua = new System.Windows.Forms.TextBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenu.SuspendLayout();
            this.gbThongTinBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvBan
            // 
            this.lvBan.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lvBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clIDBan,
            this.clTenBan,
            this.clSucChua,
            this.clTrangThai});
            this.lvBan.ContextMenuStrip = this.contextMenu;
            this.lvBan.FullRowSelect = true;
            this.lvBan.GridLines = true;
            this.lvBan.HideSelection = false;
            this.lvBan.Location = new System.Drawing.Point(322, 12);
            this.lvBan.Name = "lvBan";
            this.lvBan.Size = new System.Drawing.Size(302, 216);
            this.lvBan.TabIndex = 0;
            this.lvBan.UseCompatibleStateImageBehavior = false;
            this.lvBan.View = System.Windows.Forms.View.Details;
            this.lvBan.SelectedIndexChanged += new System.EventHandler(this.lvBan_SelectedIndexChanged);
            // 
            // clIDBan
            // 
            this.clIDBan.Text = "ID";
            this.clIDBan.Width = 40;
            // 
            // clTenBan
            // 
            this.clTenBan.Text = "Tên bàn";
            this.clTenBan.Width = 70;
            // 
            // clSucChua
            // 
            this.clSucChua.DisplayIndex = 3;
            this.clSucChua.Text = "Sức chứa";
            // 
            // clTrangThai
            // 
            this.clTrangThai.DisplayIndex = 2;
            this.clTrangThai.Text = "Trạng thái";
            this.clTrangThai.Width = 100;
            // 
            // contextMenu
            // 
            this.contextMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemXoaBan,
            this.ItemDMHoaDon,
            this.ItemNKHoaDon});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(188, 92);
            // 
            // ItemXoaBan
            // 
            this.ItemXoaBan.Name = "ItemXoaBan";
            this.ItemXoaBan.Size = new System.Drawing.Size(187, 22);
            this.ItemXoaBan.Text = "Xóa bàn";
            this.ItemXoaBan.Click += new System.EventHandler(this.ItemXoaBan_Click);
            // 
            // ItemDMHoaDon
            // 
            this.ItemDMHoaDon.Name = "ItemDMHoaDon";
            this.ItemDMHoaDon.Size = new System.Drawing.Size(187, 22);
            this.ItemDMHoaDon.Text = "Xem danh mục hóa đơn";
            this.ItemDMHoaDon.Click += new System.EventHandler(this.ItemDMHoaDon_Click);
            // 
            // ItemNKHoaDon
            // 
            this.ItemNKHoaDon.Name = "ItemNKHoaDon";
            this.ItemNKHoaDon.Size = new System.Drawing.Size(187, 22);
            this.ItemNKHoaDon.Text = "Xem nhật ký hóa đơn";
            this.ItemNKHoaDon.Click += new System.EventHandler(this.ItemNKHoaDon_Click);
            // 
            // gbThongTinBan
            // 
            this.gbThongTinBan.Controls.Add(this.btnThoat);
            this.gbThongTinBan.Controls.Add(this.btnXemHD);
            this.gbThongTinBan.Controls.Add(this.btnXoa);
            this.gbThongTinBan.Controls.Add(this.btnCapNhat);
            this.gbThongTinBan.Controls.Add(this.btnThem);
            this.gbThongTinBan.Controls.Add(this.cboTrangThai);
            this.gbThongTinBan.Controls.Add(this.txtSucChua);
            this.gbThongTinBan.Controls.Add(this.txtTenBan);
            this.gbThongTinBan.Controls.Add(this.label3);
            this.gbThongTinBan.Controls.Add(this.label2);
            this.gbThongTinBan.Controls.Add(this.label1);
            this.gbThongTinBan.Location = new System.Drawing.Point(12, 12);
            this.gbThongTinBan.Name = "gbThongTinBan";
            this.gbThongTinBan.Size = new System.Drawing.Size(302, 144);
            this.gbThongTinBan.TabIndex = 1;
            this.gbThongTinBan.TabStop = false;
            this.gbThongTinBan.Text = "Thông tin bàn";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(157, 111);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(58, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemHD
            // 
            this.btnXemHD.Location = new System.Drawing.Point(72, 111);
            this.btnXemHD.Name = "btnXemHD";
            this.btnXemHD.Size = new System.Drawing.Size(75, 23);
            this.btnXemHD.TabIndex = 9;
            this.btnXemHD.Text = "Xem HĐ";
            this.btnXemHD.UseVisualStyleBackColor = true;
            this.btnXemHD.Click += new System.EventHandler(this.btnXemHD_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(224, 81);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(224, 50);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(224, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Có khách"});
            this.cboTrangThai.Location = new System.Drawing.Point(73, 81);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(141, 21);
            this.cboTrangThai.TabIndex = 5;
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(73, 51);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(141, 21);
            this.txtSucChua.TabIndex = 4;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(73, 20);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(141, 21);
            this.txtTenBan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sức chứa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bàn:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 237);
            this.Controls.Add(this.gbThongTinBan);
            this.Controls.Add(this.lvBan);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Quản lý Nhà hàng";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenu.ResumeLayout(false);
            this.gbThongTinBan.ResumeLayout(false);
            this.gbThongTinBan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvBan;
        private System.Windows.Forms.ColumnHeader clIDBan;
        private System.Windows.Forms.ColumnHeader clTenBan;
        private System.Windows.Forms.ColumnHeader clSucChua;
        private System.Windows.Forms.ColumnHeader clTrangThai;
        private System.Windows.Forms.GroupBox gbThongTinBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXemHD;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ItemXoaBan;
        private System.Windows.Forms.ToolStripMenuItem ItemDMHoaDon;
        private System.Windows.Forms.ToolStripMenuItem ItemNKHoaDon;
    }
}

