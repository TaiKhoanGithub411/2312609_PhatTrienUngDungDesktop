
namespace RestaurantManagementProject
{
    partial class frmFood
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
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.lsvFood = new System.Windows.Forms.ListView();
            this.clSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNameFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUnitFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPriceFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFoodCatID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNotesFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblStatistic = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.btnAddCate = new System.Windows.Forms.Button();
            this.grpLeft.SuspendLayout();
            this.grpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.btnAddCate);
            this.grpLeft.Controls.Add(this.cmdDelete);
            this.grpLeft.Controls.Add(this.cmdUpdate);
            this.grpLeft.Controls.Add(this.cmdAdd);
            this.grpLeft.Controls.Add(this.cmdClear);
            this.grpLeft.Controls.Add(this.txtNotes);
            this.grpLeft.Controls.Add(this.cbbCategory);
            this.grpLeft.Controls.Add(this.txtPrice);
            this.grpLeft.Controls.Add(this.txtUnit);
            this.grpLeft.Controls.Add(this.txtName);
            this.grpLeft.Controls.Add(this.label5);
            this.grpLeft.Controls.Add(this.label4);
            this.grpLeft.Controls.Add(this.label3);
            this.grpLeft.Controls.Add(this.label2);
            this.grpLeft.Controls.Add(this.label1);
            this.grpLeft.Location = new System.Drawing.Point(12, 12);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(331, 351);
            this.grpLeft.TabIndex = 0;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "Chức năng";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(249, 321);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 14;
            this.cmdDelete.Text = "Xóa";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(168, 321);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 13;
            this.cmdUpdate.Text = "Sửa";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(87, 321);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 12;
            this.cmdAdd.Text = "Thêm";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(6, 321);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 0;
            this.cmdClear.Text = "Nhập lại";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(101, 148);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(223, 161);
            this.txtNotes.TabIndex = 11;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(136, 111);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(107, 23);
            this.cbbCategory.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(174, 80);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 21);
            this.txtPrice.TabIndex = 9;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(174, 53);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(150, 21);
            this.txtUnit.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 21);
            this.txtName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại thực phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn vị tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên thực phẩm:";
            // 
            // grpRight
            // 
            this.grpRight.Controls.Add(this.lsvFood);
            this.grpRight.Location = new System.Drawing.Point(361, 12);
            this.grpRight.Name = "grpRight";
            this.grpRight.Size = new System.Drawing.Size(456, 309);
            this.grpRight.TabIndex = 1;
            this.grpRight.TabStop = false;
            this.grpRight.Text = "Danh mục thức ăn";
            // 
            // lsvFood
            // 
            this.lsvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clSTT,
            this.clNameFood,
            this.clUnitFood,
            this.clPriceFood,
            this.clFoodCatID,
            this.clNotesFood});
            this.lsvFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvFood.FullRowSelect = true;
            this.lsvFood.GridLines = true;
            this.lsvFood.HideSelection = false;
            this.lsvFood.Location = new System.Drawing.Point(3, 17);
            this.lsvFood.MultiSelect = false;
            this.lsvFood.Name = "lsvFood";
            this.lsvFood.Size = new System.Drawing.Size(450, 289);
            this.lsvFood.TabIndex = 0;
            this.lsvFood.UseCompatibleStateImageBehavior = false;
            this.lsvFood.View = System.Windows.Forms.View.Details;
            this.lsvFood.Click += new System.EventHandler(this.lsvFood_Click);
            // 
            // clSTT
            // 
            this.clSTT.Text = "STT";
            this.clSTT.Width = 40;
            // 
            // clNameFood
            // 
            this.clNameFood.Text = "Tên thực phẩm";
            this.clNameFood.Width = 100;
            // 
            // clUnitFood
            // 
            this.clUnitFood.Text = "ĐVT";
            // 
            // clPriceFood
            // 
            this.clPriceFood.Text = "Giá";
            // 
            // clFoodCatID
            // 
            this.clFoodCatID.Text = "Loại thực phẩm";
            this.clFoodCatID.Width = 100;
            // 
            // clNotesFood
            // 
            this.clNotesFood.Text = "Ghi chú";
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Location = new System.Drawing.Point(361, 337);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(52, 15);
            this.lblStatistic.TabIndex = 2;
            this.lblStatistic.Text = "Thống kê";
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(739, 333);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 15;
            this.cmdExit.Text = "Thoát";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // btnAddCate
            // 
            this.btnAddCate.Location = new System.Drawing.Point(249, 111);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(75, 23);
            this.btnAddCate.TabIndex = 15;
            this.btnAddCate.Text = "Thêm loại";
            this.btnAddCate.UseVisualStyleBackColor = true;
            this.btnAddCate.Click += new System.EventHandler(this.btnAddCate_Click);
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 374);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblStatistic);
            this.Controls.Add(this.grpRight);
            this.Controls.Add(this.grpLeft);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmFood";
            this.Text = "THÊM - XÓA - SỬA BẢNG FOOD";
            this.Load += new System.EventHandler(this.frmFood_Load);
            this.grpLeft.ResumeLayout(false);
            this.grpLeft.PerformLayout();
            this.grpRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.ListView lsvFood;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.ColumnHeader clSTT;
        private System.Windows.Forms.ColumnHeader clNameFood;
        private System.Windows.Forms.ColumnHeader clUnitFood;
        private System.Windows.Forms.ColumnHeader clPriceFood;
        private System.Windows.Forms.ColumnHeader clFoodCatID;
        private System.Windows.Forms.ColumnHeader clNotesFood;
        private System.Windows.Forms.Button btnAddCate;
    }
}

