
namespace GiuaKy_OnTap_De3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grbDSDocGia = new System.Windows.Forms.GroupBox();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdSDT = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtagvDSDG = new System.Windows.Forms.DataGridView();
            this.clMaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDSDocGia.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtagvDSDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên độc giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(96, 16);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(153, 22);
            this.txtMaDocGia.TabIndex = 4;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(96, 51);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(153, 22);
            this.txtTenDocGia.TabIndex = 5;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(96, 85);
            this.mtxtSDT.Mask = "0000.000.000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(153, 22);
            this.mtxtSDT.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(307, 16);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(202, 91);
            this.txtDiaChi.TabIndex = 7;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Location = new System.Drawing.Point(174, 125);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTrang.TabIndex = 8;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(307, 125);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // grbDSDocGia
            // 
            this.grbDSDocGia.Controls.Add(this.dtagvDSDG);
            this.grbDSDocGia.Controls.Add(this.grbTimKiem);
            this.grbDSDocGia.Location = new System.Drawing.Point(17, 152);
            this.grbDSDocGia.Name = "grbDSDocGia";
            this.grbDSDocGia.Size = new System.Drawing.Size(532, 289);
            this.grbDSDocGia.TabIndex = 10;
            this.grbDSDocGia.TabStop = false;
            this.grbDSDocGia.Text = "Danh sách độc giả";
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.rdTen);
            this.grbTimKiem.Controls.Add(this.rdSDT);
            this.grbTimKiem.Controls.Add(this.txtTimKiem);
            this.grbTimKiem.Location = new System.Drawing.Point(6, 21);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(480, 52);
            this.grbTimKiem.TabIndex = 0;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Location = new System.Drawing.Point(370, 22);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(68, 18);
            this.rdTen.TabIndex = 2;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Theo tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // rdSDT
            // 
            this.rdSDT.AutoSize = true;
            this.rdSDT.Location = new System.Drawing.Point(284, 22);
            this.rdSDT.Name = "rdSDT";
            this.rdSDT.Size = new System.Drawing.Size(71, 18);
            this.rdSDT.TabIndex = 1;
            this.rdSDT.TabStop = true;
            this.rdSDT.Text = "Theo SĐT";
            this.rdSDT.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(40, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(237, 22);
            this.txtTimKiem.TabIndex = 0;
            // 
            // dtagvDSDG
            // 
            this.dtagvDSDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtagvDSDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagvDSDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaDocGia,
            this.clTenDocGia,
            this.clSDT,
            this.clDiaChi});
            this.dtagvDSDG.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dtagvDSDG.Location = new System.Drawing.Point(6, 79);
            this.dtagvDSDG.Name = "dtagvDSDG";
            this.dtagvDSDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtagvDSDG.Size = new System.Drawing.Size(520, 204);
            this.dtagvDSDG.TabIndex = 1;
            this.dtagvDSDG.SelectionChanged += new System.EventHandler(this.dtagvDSDG_SelectionChanged);
            // 
            // clMaDocGia
            // 
            this.clMaDocGia.HeaderText = "Mã độc giả";
            this.clMaDocGia.Name = "clMaDocGia";
            // 
            // clTenDocGia
            // 
            this.clTenDocGia.HeaderText = "Tên độc giả";
            this.clTenDocGia.Name = "clTenDocGia";
            // 
            // clSDT
            // 
            this.clSDT.HeaderText = "Số điện thoại";
            this.clSDT.Name = "clSDT";
            // 
            // clDiaChi
            // 
            this.clDiaChi.HeaderText = "Địa chỉ";
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.Width = 250;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 453);
            this.Controls.Add(this.grbDSDocGia);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.txtTenDocGia);
            this.Controls.Add(this.txtMaDocGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "Quản lý độc giả";
            this.grbDSDocGia.ResumeLayout(false);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtagvDSDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox grbDSDocGia;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.RadioButton rdSDT;
        private System.Windows.Forms.DataGridView dtagvDSDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
    }
}

