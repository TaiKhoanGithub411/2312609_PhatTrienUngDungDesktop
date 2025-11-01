
namespace RestaurantManagementProject
{
    partial class frmCategory
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
            this.lvwCategory = new System.Windows.Forms.ListView();
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameCate = new System.Windows.Forms.TextBox();
            this.cbbCategoryType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwCategory
            // 
            this.lvwCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clName,
            this.clType});
            this.lvwCategory.FullRowSelect = true;
            this.lvwCategory.GridLines = true;
            this.lvwCategory.HideSelection = false;
            this.lvwCategory.Location = new System.Drawing.Point(12, 12);
            this.lvwCategory.MultiSelect = false;
            this.lvwCategory.Name = "lvwCategory";
            this.lvwCategory.Size = new System.Drawing.Size(312, 223);
            this.lvwCategory.TabIndex = 0;
            this.lvwCategory.UseCompatibleStateImageBehavior = false;
            this.lvwCategory.View = System.Windows.Forms.View.Details;
            this.lvwCategory.SelectedIndexChanged += new System.EventHandler(this.lvwCategory_SelectedIndexChanged);
            // 
            // clID
            // 
            this.clID.Text = "STT";
            this.clID.Width = 40;
            // 
            // clName
            // 
            this.clName.Text = "Tên loại thực phẩm";
            this.clName.Width = 150;
            // 
            // clType
            // 
            this.clType.Text = "Loại thực phẩm";
            this.clType.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại thực phẩm:";
            // 
            // txtNameCate
            // 
            this.txtNameCate.Location = new System.Drawing.Point(99, 246);
            this.txtNameCate.Name = "txtNameCate";
            this.txtNameCate.Size = new System.Drawing.Size(142, 21);
            this.txtNameCate.TabIndex = 3;
            // 
            // cbbCategoryType
            // 
            this.cbbCategoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoryType.FormattingEnabled = true;
            this.cbbCategoryType.Items.AddRange(new object[] {
            "Đồ uống",
            "Thức ăn"});
            this.cbbCategoryType.Location = new System.Drawing.Point(99, 273);
            this.cbbCategoryType.Name = "cbbCategoryType";
            this.cbbCategoryType.Size = new System.Drawing.Size(142, 23);
            this.cbbCategoryType.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(118, 310);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(208, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 348);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbCategoryType);
            this.Controls.Add(this.txtNameCate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwCategory);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCategory";
            this.Text = "Thêm/cập nhật loại thực phẩm";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwCategory;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameCate;
        private System.Windows.Forms.ComboBox cbbCategoryType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}