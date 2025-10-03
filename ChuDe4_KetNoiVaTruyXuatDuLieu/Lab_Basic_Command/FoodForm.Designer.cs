
namespace Lab_Basic_Command
{
    partial class FoodForm
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
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.btnSaveFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.clMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFood
            // 
            this.dgvFood.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaMon,
            this.clTenMon,
            this.clDVT,
            this.clMaNhom,
            this.clDonGia,
            this.clGhiChu});
            this.dgvFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFood.Location = new System.Drawing.Point(0, 0);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 62;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(643, 250);
            this.dgvFood.TabIndex = 0;
            // 
            // btnSaveFood
            // 
            this.btnSaveFood.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFood.ForeColor = System.Drawing.Color.Red;
            this.btnSaveFood.Location = new System.Drawing.Point(446, 258);
            this.btnSaveFood.Name = "btnSaveFood";
            this.btnSaveFood.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFood.TabIndex = 1;
            this.btnSaveFood.Text = "Lưu";
            this.btnSaveFood.UseVisualStyleBackColor = true;
            this.btnSaveFood.Click += new System.EventHandler(this.btnSaveFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteFood.Location = new System.Drawing.Point(542, 258);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // clMaMon
            // 
            this.clMaMon.DataPropertyName = "ID";
            this.clMaMon.HeaderText = "Mã món";
            this.clMaMon.MinimumWidth = 8;
            this.clMaMon.Name = "clMaMon";
            this.clMaMon.Width = 150;
            // 
            // clTenMon
            // 
            this.clTenMon.DataPropertyName = "Name";
            this.clTenMon.HeaderText = "Tên món";
            this.clTenMon.MinimumWidth = 8;
            this.clTenMon.Name = "clTenMon";
            this.clTenMon.Width = 150;
            // 
            // clDVT
            // 
            this.clDVT.DataPropertyName = "Unit";
            this.clDVT.HeaderText = "Đơn vị tính";
            this.clDVT.MinimumWidth = 8;
            this.clDVT.Name = "clDVT";
            this.clDVT.Width = 150;
            // 
            // clMaNhom
            // 
            this.clMaNhom.DataPropertyName = "FoodCategoryID";
            this.clMaNhom.HeaderText = "Mã nhóm";
            this.clMaNhom.MinimumWidth = 8;
            this.clMaNhom.Name = "clMaNhom";
            this.clMaNhom.Width = 150;
            // 
            // clDonGia
            // 
            this.clDonGia.DataPropertyName = "Price";
            this.clDonGia.HeaderText = "Đơn giá";
            this.clDonGia.MinimumWidth = 8;
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.Width = 150;
            // 
            // clGhiChu
            // 
            this.clGhiChu.DataPropertyName = "Note";
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.MinimumWidth = 8;
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.Width = 150;
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 293);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnSaveFood);
            this.Controls.Add(this.dgvFood);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FoodForm";
            this.Text = "Danh sách món ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button btnSaveFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
    }
}