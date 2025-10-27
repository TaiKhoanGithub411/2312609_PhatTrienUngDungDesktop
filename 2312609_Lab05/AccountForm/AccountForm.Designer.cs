
namespace AccountForm
{
    partial class AccountForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassTK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dptDateCreated = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtSDTTK = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTenTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSTK = new System.Windows.Forms.DataGridView();
            this.cmsAccountMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemViewRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).BeginInit();
            this.cmsAccountMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassTK);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAddRole);
            this.groupBox1.Controls.Add(this.btnResetPass);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dptDateCreated);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtxtSDTTK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmailTK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoTenTK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenTK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txtPassTK
            // 
            this.txtPassTK.Location = new System.Drawing.Point(331, 77);
            this.txtPassTK.Name = "txtPassTK";
            this.txtPassTK.PasswordChar = '*';
            this.txtPassTK.Size = new System.Drawing.Size(143, 21);
            this.txtPassTK.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mật khẩu:";
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(328, 110);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(79, 23);
            this.btnAddRole.TabIndex = 12;
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(230, 110);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(80, 23);
            this.btnResetPass.TabIndex = 11;
            this.btnResetPass.Text = "Reset Pass";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(156, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(54, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dptDateCreated
            // 
            this.dptDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptDateCreated.Location = new System.Drawing.Point(331, 50);
            this.dptDateCreated.Name = "dptDateCreated";
            this.dptDateCreated.Size = new System.Drawing.Size(143, 21);
            this.dptDateCreated.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày tạo:";
            // 
            // mtxtSDTTK
            // 
            this.mtxtSDTTK.Location = new System.Drawing.Point(331, 23);
            this.mtxtSDTTK.Mask = "00000000000";
            this.mtxtSDTTK.Name = "mtxtSDTTK";
            this.mtxtSDTTK.Size = new System.Drawing.Size(143, 21);
            this.mtxtSDTTK.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số ĐT:";
            // 
            // txtEmailTK
            // 
            this.txtEmailTK.Location = new System.Drawing.Point(87, 77);
            this.txtEmailTK.Name = "txtEmailTK";
            this.txtEmailTK.Size = new System.Drawing.Size(143, 21);
            this.txtEmailTK.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // txtHoTenTK
            // 
            this.txtHoTenTK.Location = new System.Drawing.Point(87, 50);
            this.txtHoTenTK.Name = "txtHoTenTK";
            this.txtHoTenTK.Size = new System.Drawing.Size(143, 21);
            this.txtHoTenTK.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và tên:";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(87, 23);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(143, 21);
            this.txtTenTK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tài khoản:";
            // 
            // dgvDSTK
            // 
            this.dgvDSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTK.ContextMenuStrip = this.cmsAccountMenu;
            this.dgvDSTK.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSTK.Location = new System.Drawing.Point(12, 168);
            this.dgvDSTK.Name = "dgvDSTK";
            this.dgvDSTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSTK.Size = new System.Drawing.Size(537, 244);
            this.dgvDSTK.TabIndex = 1;
            this.dgvDSTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTK_CellClick);
            // 
            // cmsAccountMenu
            // 
            this.cmsAccountMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsAccountMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemViewRoles,
            this.menuItemViewActivity});
            this.cmsAccountMenu.Name = "cmsAccountMenu";
            this.cmsAccountMenu.Size = new System.Drawing.Size(188, 70);
            // 
            // menuItemViewRoles
            // 
            this.menuItemViewRoles.Name = "menuItemViewRoles";
            this.menuItemViewRoles.Size = new System.Drawing.Size(187, 22);
            this.menuItemViewRoles.Text = "Xem danh sách vai trò";
            this.menuItemViewRoles.Click += new System.EventHandler(this.menuItemViewRoles_Click);
            // 
            // menuItemViewActivity
            // 
            this.menuItemViewActivity.Name = "menuItemViewActivity";
            this.menuItemViewActivity.Size = new System.Drawing.Size(187, 22);
            this.menuItemViewActivity.Text = "Xem nhật ký hoạt động";
            this.menuItemViewActivity.Click += new System.EventHandler(this.menuItemViewActivity_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 422);
            this.Controls.Add(this.dgvDSTK);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AccountForm";
            this.Text = "Quản lý tài khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).EndInit();
            this.cmsAccountMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtEmailTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTenTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtSDTTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dptDateCreated;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.DataGridView dgvDSTK;
        private System.Windows.Forms.ContextMenuStrip cmsAccountMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewRoles;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewActivity;
        private System.Windows.Forms.TextBox txtPassTK;
        private System.Windows.Forms.Label label6;
    }
}

