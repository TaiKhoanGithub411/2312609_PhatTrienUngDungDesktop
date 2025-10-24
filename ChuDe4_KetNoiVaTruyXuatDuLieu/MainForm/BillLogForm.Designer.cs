
namespace MainForm
{
    partial class BillLogForm
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
            this.grbTongQuan = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongHD = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongThue = new System.Windows.Forms.Label();
            this.lblTongGiam = new System.Windows.Forms.Label();
            this.lblTongThu = new System.Windows.Forms.Label();
            this.grbDSHD = new System.Windows.Forms.GroupBox();
            this.lvDSHD = new System.Windows.Forms.ListView();
            this.clIDHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNgayLap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGiamGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTongQuan.SuspendLayout();
            this.grbDSHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTongQuan
            // 
            this.grbTongQuan.Controls.Add(this.lblTongThu);
            this.grbTongQuan.Controls.Add(this.lblTongGiam);
            this.grbTongQuan.Controls.Add(this.lblTongThue);
            this.grbTongQuan.Controls.Add(this.lblTongTien);
            this.grbTongQuan.Controls.Add(this.lblTongHD);
            this.grbTongQuan.Controls.Add(this.label5);
            this.grbTongQuan.Controls.Add(this.label4);
            this.grbTongQuan.Controls.Add(this.label3);
            this.grbTongQuan.Controls.Add(this.label2);
            this.grbTongQuan.Controls.Add(this.label1);
            this.grbTongQuan.Location = new System.Drawing.Point(12, 12);
            this.grbTongQuan.Name = "grbTongQuan";
            this.grbTongQuan.Size = new System.Drawing.Size(461, 124);
            this.grbTongQuan.TabIndex = 0;
            this.grbTongQuan.TabStop = false;
            this.grbTongQuan.Text = "Tổng quan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số HĐ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng thuế:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng giảm giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng thực thu:";
            // 
            // lblTongHD
            // 
            this.lblTongHD.AutoSize = true;
            this.lblTongHD.Location = new System.Drawing.Point(81, 22);
            this.lblTongHD.Name = "lblTongHD";
            this.lblTongHD.Size = new System.Drawing.Size(73, 15);
            this.lblTongHD.TabIndex = 5;
            this.lblTongHD.Text = "___________";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(81, 52);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(73, 15);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "___________";
            // 
            // lblTongThue
            // 
            this.lblTongThue.AutoSize = true;
            this.lblTongThue.Location = new System.Drawing.Point(81, 85);
            this.lblTongThue.Name = "lblTongThue";
            this.lblTongThue.Size = new System.Drawing.Size(73, 15);
            this.lblTongThue.TabIndex = 7;
            this.lblTongThue.Text = "___________";
            // 
            // lblTongGiam
            // 
            this.lblTongGiam.AutoSize = true;
            this.lblTongGiam.Location = new System.Drawing.Point(271, 22);
            this.lblTongGiam.Name = "lblTongGiam";
            this.lblTongGiam.Size = new System.Drawing.Size(73, 15);
            this.lblTongGiam.TabIndex = 8;
            this.lblTongGiam.Text = "___________";
            // 
            // lblTongThu
            // 
            this.lblTongThu.AutoSize = true;
            this.lblTongThu.Location = new System.Drawing.Point(271, 53);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(73, 15);
            this.lblTongThu.TabIndex = 9;
            this.lblTongThu.Text = "___________";
            // 
            // grbDSHD
            // 
            this.grbDSHD.Controls.Add(this.lvDSHD);
            this.grbDSHD.Location = new System.Drawing.Point(12, 142);
            this.grbDSHD.Name = "grbDSHD";
            this.grbDSHD.Size = new System.Drawing.Size(461, 180);
            this.grbDSHD.TabIndex = 1;
            this.grbDSHD.TabStop = false;
            this.grbDSHD.Text = "Danh sách hóa đơn";
            // 
            // lvDSHD
            // 
            this.lvDSHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clIDHD,
            this.clNgayLap,
            this.clNhanVien,
            this.clTien,
            this.clGiamGia,
            this.clThue,
            this.clThu});
            this.lvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDSHD.FullRowSelect = true;
            this.lvDSHD.GridLines = true;
            this.lvDSHD.HideSelection = false;
            this.lvDSHD.Location = new System.Drawing.Point(3, 17);
            this.lvDSHD.Name = "lvDSHD";
            this.lvDSHD.Size = new System.Drawing.Size(455, 160);
            this.lvDSHD.TabIndex = 0;
            this.lvDSHD.UseCompatibleStateImageBehavior = false;
            this.lvDSHD.View = System.Windows.Forms.View.Details;
            // 
            // clIDHD
            // 
            this.clIDHD.Text = "ID";
            this.clIDHD.Width = 30;
            // 
            // clNgayLap
            // 
            this.clNgayLap.Text = "Ngày lập";
            this.clNgayLap.Width = 80;
            // 
            // clNhanVien
            // 
            this.clNhanVien.Text = "Nhân viên";
            this.clNhanVien.Width = 70;
            // 
            // clTien
            // 
            this.clTien.Text = "Tổng tiền";
            this.clTien.Width = 80;
            // 
            // clGiamGia
            // 
            this.clGiamGia.Text = "Giảm giá";
            this.clGiamGia.Width = 70;
            // 
            // clThue
            // 
            this.clThue.Text = "Thuế";
            // 
            // clThu
            // 
            this.clThu.Text = "Thực thu";
            // 
            // BillLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 329);
            this.Controls.Add(this.grbDSHD);
            this.Controls.Add(this.grbTongQuan);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BillLogForm";
            this.grbTongQuan.ResumeLayout(false);
            this.grbTongQuan.PerformLayout();
            this.grbDSHD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTongQuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongThu;
        private System.Windows.Forms.Label lblTongGiam;
        private System.Windows.Forms.Label lblTongThue;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongHD;
        private System.Windows.Forms.GroupBox grbDSHD;
        private System.Windows.Forms.ListView lvDSHD;
        private System.Windows.Forms.ColumnHeader clIDHD;
        private System.Windows.Forms.ColumnHeader clNgayLap;
        private System.Windows.Forms.ColumnHeader clNhanVien;
        private System.Windows.Forms.ColumnHeader clTien;
        private System.Windows.Forms.ColumnHeader clGiamGia;
        private System.Windows.Forms.ColumnHeader clThue;
        private System.Windows.Forms.ColumnHeader clThu;
    }
}