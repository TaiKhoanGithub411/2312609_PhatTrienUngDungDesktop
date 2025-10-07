
namespace Lab_Basic_Command
{
    partial class UserRoles
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
            this.lvDSVaiTro = new System.Windows.Forms.ListView();
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenVaiTro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTrangThaiVaiTro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvDSVaiTro
            // 
            this.lvDSVaiTro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clTenVaiTro,
            this.clTrangThaiVaiTro});
            this.lvDSVaiTro.GridLines = true;
            this.lvDSVaiTro.HideSelection = false;
            this.lvDSVaiTro.Location = new System.Drawing.Point(12, 12);
            this.lvDSVaiTro.Name = "lvDSVaiTro";
            this.lvDSVaiTro.Size = new System.Drawing.Size(430, 219);
            this.lvDSVaiTro.TabIndex = 0;
            this.lvDSVaiTro.UseCompatibleStateImageBehavior = false;
            this.lvDSVaiTro.View = System.Windows.Forms.View.Details;
            // 
            // clID
            // 
            this.clID.Text = "ID";
            this.clID.Width = 40;
            // 
            // clTenVaiTro
            // 
            this.clTenVaiTro.Text = "Tên vai trò";
            this.clTenVaiTro.Width = 100;
            // 
            // clTrangThaiVaiTro
            // 
            this.clTrangThaiVaiTro.Text = "Trạng thái";
            this.clTrangThaiVaiTro.Width = 70;
            // 
            // UserRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 242);
            this.Controls.Add(this.lvDSVaiTro);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserRoles";
            this.Text = "Danh sách vai trò tài khoản";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDSVaiTro;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.ColumnHeader clTenVaiTro;
        private System.Windows.Forms.ColumnHeader clTrangThaiVaiTro;
    }
}