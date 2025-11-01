
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnReloadCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnReloadFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tvwCategory = new System.Windows.Forms.TreeView();
            this.lvwFood = new System.Windows.Forms.ListView();
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFoodCate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReloadCategory
            // 
            this.btnReloadCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnReloadCategory.Location = new System.Drawing.Point(126, 12);
            this.btnReloadCategory.Name = "btnReloadCategory";
            this.btnReloadCategory.Size = new System.Drawing.Size(25, 23);
            this.btnReloadCategory.TabIndex = 1;
            this.btnReloadCategory.Text = "R";
            this.toolTip1.SetToolTip(this.btnReloadCategory, "Tải lại danh mục");
            this.btnReloadCategory.UseVisualStyleBackColor = true;
            this.btnReloadCategory.Click += new System.EventHandler(this.btnReloadCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnAddCategory.Location = new System.Drawing.Point(153, 12);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(25, 23);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "+";
            this.toolTip1.SetToolTip(this.btnAddCategory, "Thêm danh mục mới");
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnAddFood.Location = new System.Drawing.Point(699, 12);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(25, 23);
            this.btnAddFood.TabIndex = 7;
            this.btnAddFood.Text = "+";
            this.toolTip1.SetToolTip(this.btnAddFood, "Thêm món ăn mới");
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnReloadFood
            // 
            this.btnReloadFood.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnReloadFood.Location = new System.Drawing.Point(668, 12);
            this.btnReloadFood.Name = "btnReloadFood";
            this.btnReloadFood.Size = new System.Drawing.Size(25, 23);
            this.btnReloadFood.TabIndex = 6;
            this.btnReloadFood.Text = "R";
            this.toolTip1.SetToolTip(this.btnReloadFood, "Tải lại thực đơn");
            this.btnReloadFood.UseVisualStyleBackColor = true;
            this.btnReloadFood.Click += new System.EventHandler(this.btnReloadFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnDeleteFood.Location = new System.Drawing.Point(730, 12);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(25, 23);
            this.btnDeleteFood.TabIndex = 8;
            this.btnDeleteFood.Text = "-";
            this.toolTip1.SetToolTip(this.btnDeleteFood, "Xóa món ăn được chọn");
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục";
            // 
            // tvwCategory
            // 
            this.tvwCategory.Location = new System.Drawing.Point(12, 38);
            this.tvwCategory.Name = "tvwCategory";
            this.tvwCategory.Size = new System.Drawing.Size(166, 300);
            this.tvwCategory.TabIndex = 2;
            this.tvwCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCategory_AfterSelect);
            this.tvwCategory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwCategory_NodeMouseDoubleClick);
            // 
            // lvwFood
            // 
            this.lvwFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clName,
            this.clUnit,
            this.clPrice,
            this.clFoodCate,
            this.clNotes});
            this.lvwFood.FullRowSelect = true;
            this.lvwFood.GridLines = true;
            this.lvwFood.HideSelection = false;
            this.lvwFood.Location = new System.Drawing.Point(184, 38);
            this.lvwFood.MultiSelect = false;
            this.lvwFood.Name = "lvwFood";
            this.lvwFood.Size = new System.Drawing.Size(571, 300);
            this.lvwFood.TabIndex = 4;
            this.lvwFood.UseCompatibleStateImageBehavior = false;
            this.lvwFood.View = System.Windows.Forms.View.Details;
            this.lvwFood.DoubleClick += new System.EventHandler(this.lvwFood_DoubleClick);
            // 
            // clID
            // 
            this.clID.Text = "Mã số";
            this.clID.Width = 50;
            // 
            // clName
            // 
            this.clName.Text = "Tên đồ ăn/thức uống";
            this.clName.Width = 155;
            // 
            // clUnit
            // 
            this.clUnit.Text = "ĐVT";
            // 
            // clPrice
            // 
            this.clPrice.Text = "Giá bán";
            // 
            // clFoodCate
            // 
            this.clFoodCate.Text = "Nhóm mặt hàng";
            this.clFoodCate.Width = 100;
            // 
            // clNotes
            // 
            this.clNotes.Text = "Ghi chú";
            this.clNotes.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thực đơn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 350);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnReloadFood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvwFood);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.tvwCategory);
            this.Controls.Add(this.btnReloadCategory);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Quản lý nhà hàng";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReloadCategory;
        private System.Windows.Forms.TreeView tvwCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ListView lvwFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnReloadFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clUnit;
        private System.Windows.Forms.ColumnHeader clPrice;
        private System.Windows.Forms.ColumnHeader clFoodCate;
        private System.Windows.Forms.ColumnHeader clNotes;
    }
}

