
namespace AccountManager
{
    partial class AccountRoleForm
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
            this.lvRoles = new System.Windows.Forms.ListView();
            this.clRolesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvRoles
            // 
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clRolesName,
            this.clTrangThai});
            this.lvRoles.FullRowSelect = true;
            this.lvRoles.GridLines = true;
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(12, 12);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(397, 173);
            this.lvRoles.TabIndex = 0;
            this.lvRoles.UseCompatibleStateImageBehavior = false;
            this.lvRoles.View = System.Windows.Forms.View.Details;
            // 
            // clRolesName
            // 
            this.clRolesName.Text = "Tên vai trò";
            this.clRolesName.Width = 150;
            // 
            // clTrangThai
            // 
            this.clTrangThai.Text = "Trạng thái";
            // 
            // AccountRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 198);
            this.Controls.Add(this.lvRoles);
            this.Name = "AccountRoleForm";
            this.Load += new System.EventHandler(this.AccountRoleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRoles;
        private System.Windows.Forms.ColumnHeader clRolesName;
        private System.Windows.Forms.ColumnHeader clTrangThai;
    }
}