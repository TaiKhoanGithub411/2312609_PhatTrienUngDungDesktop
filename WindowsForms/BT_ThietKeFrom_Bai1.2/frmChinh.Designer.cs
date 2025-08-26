
namespace BT_ThietKeFrom_Bai1._2
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.ptbAnhXe = new System.Windows.Forms.PictureBox();
            this.groupboxChonMau = new System.Windows.Forms.GroupBox();
            this.rdTrang = new System.Windows.Forms.RadioButton();
            this.rdDo = new System.Windows.Forms.RadioButton();
            this.rdXanh = new System.Windows.Forms.RadioButton();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblDonViTien = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblSotTien = new System.Windows.Forms.Label();
            this.lblDonViTien2 = new System.Windows.Forms.Label();
            this.btnTInhTien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhXe)).BeginInit();
            this.groupboxChonMau.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbAnhXe
            // 
            this.ptbAnhXe.Image = ((System.Drawing.Image)(resources.GetObject("ptbAnhXe.Image")));
            this.ptbAnhXe.Location = new System.Drawing.Point(12, 12);
            this.ptbAnhXe.Margin = new System.Windows.Forms.Padding(2);
            this.ptbAnhXe.Name = "ptbAnhXe";
            this.ptbAnhXe.Size = new System.Drawing.Size(314, 300);
            this.ptbAnhXe.TabIndex = 0;
            this.ptbAnhXe.TabStop = false;
            // 
            // groupboxChonMau
            // 
            this.groupboxChonMau.Controls.Add(this.rdTrang);
            this.groupboxChonMau.Controls.Add(this.rdDo);
            this.groupboxChonMau.Controls.Add(this.rdXanh);
            this.groupboxChonMau.Location = new System.Drawing.Point(349, 12);
            this.groupboxChonMau.Margin = new System.Windows.Forms.Padding(2);
            this.groupboxChonMau.Name = "groupboxChonMau";
            this.groupboxChonMau.Padding = new System.Windows.Forms.Padding(2);
            this.groupboxChonMau.Size = new System.Drawing.Size(200, 164);
            this.groupboxChonMau.TabIndex = 1;
            this.groupboxChonMau.TabStop = false;
            this.groupboxChonMau.Text = "Chọn màu xe";
            // 
            // rdTrang
            // 
            this.rdTrang.AutoSize = true;
            this.rdTrang.Location = new System.Drawing.Point(22, 122);
            this.rdTrang.Margin = new System.Windows.Forms.Padding(2);
            this.rdTrang.Name = "rdTrang";
            this.rdTrang.Size = new System.Drawing.Size(108, 24);
            this.rdTrang.TabIndex = 0;
            this.rdTrang.Text = "Màu trắng";
            this.rdTrang.UseVisualStyleBackColor = true;
            this.rdTrang.CheckedChanged += new System.EventHandler(this.rdTrang_CheckedChanged);
            // 
            // rdDo
            // 
            this.rdDo.AutoSize = true;
            this.rdDo.Location = new System.Drawing.Point(22, 79);
            this.rdDo.Margin = new System.Windows.Forms.Padding(2);
            this.rdDo.Name = "rdDo";
            this.rdDo.Size = new System.Drawing.Size(90, 24);
            this.rdDo.TabIndex = 0;
            this.rdDo.Text = "Màu đỏ";
            this.rdDo.UseVisualStyleBackColor = true;
            this.rdDo.CheckedChanged += new System.EventHandler(this.rdDo_CheckedChanged);
            // 
            // rdXanh
            // 
            this.rdXanh.AutoSize = true;
            this.rdXanh.Checked = true;
            this.rdXanh.Location = new System.Drawing.Point(22, 39);
            this.rdXanh.Margin = new System.Windows.Forms.Padding(2);
            this.rdXanh.Name = "rdXanh";
            this.rdXanh.Size = new System.Drawing.Size(106, 24);
            this.rdXanh.TabIndex = 0;
            this.rdXanh.TabStop = true;
            this.rdXanh.Text = "Màu xanh";
            this.rdXanh.UseVisualStyleBackColor = true;
            this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(344, 205);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(70, 20);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(344, 252);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(83, 20);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng: ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(449, 202);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 28);
            this.txtDonGia.TabIndex = 3;
            this.txtDonGia.Text = "22000";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(449, 249);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 28);
            this.txtSoLuong.TabIndex = 3;
            // 
            // lblDonViTien
            // 
            this.lblDonViTien.AutoSize = true;
            this.lblDonViTien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTien.Location = new System.Drawing.Point(554, 205);
            this.lblDonViTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonViTien.Name = "lblDonViTien";
            this.lblDonViTien.Size = new System.Drawing.Size(20, 23);
            this.lblDonViTien.TabIndex = 4;
            this.lblDonViTien.Text = "$";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(92, 362);
            this.lblThanhTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(221, 25);
            this.lblThanhTien.TabIndex = 5;
            this.lblThanhTien.Text = "Tổng số tiền phải trả: ";
            // 
            // lblSotTien
            // 
            this.lblSotTien.AutoSize = true;
            this.lblSotTien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSotTien.Location = new System.Drawing.Point(319, 364);
            this.lblSotTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSotTien.Name = "lblSotTien";
            this.lblSotTien.Size = new System.Drawing.Size(20, 23);
            this.lblSotTien.TabIndex = 6;
            this.lblSotTien.Text = "0";
            // 
            // lblDonViTien2
            // 
            this.lblDonViTien2.AutoSize = true;
            this.lblDonViTien2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTien2.Location = new System.Drawing.Point(444, 364);
            this.lblDonViTien2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonViTien2.Name = "lblDonViTien2";
            this.lblDonViTien2.Size = new System.Drawing.Size(20, 23);
            this.lblDonViTien2.TabIndex = 7;
            this.lblDonViTien2.Text = "$";
            // 
            // btnTInhTien
            // 
            this.btnTInhTien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTInhTien.ForeColor = System.Drawing.Color.Red;
            this.btnTInhTien.Location = new System.Drawing.Point(448, 294);
            this.btnTInhTien.Margin = new System.Windows.Forms.Padding(2);
            this.btnTInhTien.Name = "btnTInhTien";
            this.btnTInhTien.Size = new System.Drawing.Size(102, 40);
            this.btnTInhTien.TabIndex = 8;
            this.btnTInhTien.Text = "Tính tiền";
            this.btnTInhTien.UseVisualStyleBackColor = true;
            this.btnTInhTien.Click += new System.EventHandler(this.btnTInhTien_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 408);
            this.Controls.Add(this.btnTInhTien);
            this.Controls.Add(this.lblDonViTien2);
            this.Controls.Add(this.lblSotTien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblDonViTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.groupboxChonMau);
            this.Controls.Add(this.ptbAnhXe);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChinh";
            this.Text = "Mua bán xe";
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhXe)).EndInit();
            this.groupboxChonMau.ResumeLayout(false);
            this.groupboxChonMau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAnhXe;
        private System.Windows.Forms.GroupBox groupboxChonMau;
        private System.Windows.Forms.RadioButton rdTrang;
        private System.Windows.Forms.RadioButton rdDo;
        private System.Windows.Forms.RadioButton rdXanh;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblDonViTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblSotTien;
        private System.Windows.Forms.Label lblDonViTien2;
        private System.Windows.Forms.Button btnTInhTien;
    }
}

