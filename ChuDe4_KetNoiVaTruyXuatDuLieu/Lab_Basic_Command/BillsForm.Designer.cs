
namespace Lab_Basic_Command
{
    partial class BillsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dptFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lvBills = new System.Windows.Forms.ListView();
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTables = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTongGiam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clThucThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCheckoutDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAcount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dptFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn thời gian xem hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày:";
            // 
            // dptFrom
            // 
            this.dptFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptFrom.Location = new System.Drawing.Point(94, 34);
            this.dptFrom.Name = "dptFrom";
            this.dptFrom.Size = new System.Drawing.Size(150, 29);
            this.dptFrom.TabIndex = 3;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(395, 35);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(150, 29);
            this.dtpTo.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(591, 37);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Chọn";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lvBills
            // 
            this.lvBills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clName,
            this.clTables,
            this.clAmount,
            this.clTongGiam,
            this.clThucThu,
            this.clCheckoutDate,
            this.clAcount});
            this.lvBills.FullRowSelect = true;
            this.lvBills.GridLines = true;
            this.lvBills.HideSelection = false;
            this.lvBills.Location = new System.Drawing.Point(12, 104);
            this.lvBills.Name = "lvBills";
            this.lvBills.Size = new System.Drawing.Size(865, 379);
            this.lvBills.TabIndex = 3;
            this.lvBills.UseCompatibleStateImageBehavior = false;
            this.lvBills.View = System.Windows.Forms.View.Details;
            this.lvBills.DoubleClick += new System.EventHandler(this.lvBills_DoubleClick);
            // 
            // clID
            // 
            this.clID.Text = "ID";
            this.clID.Width = 30;
            // 
            // clName
            // 
            this.clName.Text = "Tên hóa đơn";
            this.clName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clName.Width = 150;
            // 
            // clTables
            // 
            this.clTables.Text = "Bàn";
            this.clTables.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTables.Width = 50;
            // 
            // clAmount
            // 
            this.clAmount.Text = "Tổng tiền chưa giảm";
            this.clAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clAmount.Width = 180;
            // 
            // clTongGiam
            // 
            this.clTongGiam.Text = "Tổng giảm";
            this.clTongGiam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTongGiam.Width = 100;
            // 
            // clThucThu
            // 
            this.clThucThu.Text = "Thực thu";
            this.clThucThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clThucThu.Width = 100;
            // 
            // clCheckoutDate
            // 
            this.clCheckoutDate.Text = "Ngày thanh toán";
            this.clCheckoutDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clCheckoutDate.Width = 150;
            // 
            // clAcount
            // 
            this.clAcount.Text = "Tài khoản";
            this.clAcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clAcount.Width = 100;
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 495);
            this.Controls.Add(this.lvBills);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BillsForm";
            this.Text = "Hóa đơn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dptFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvBills;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clTables;
        private System.Windows.Forms.ColumnHeader clAmount;
        private System.Windows.Forms.ColumnHeader clTongGiam;
        private System.Windows.Forms.ColumnHeader clThucThu;
        private System.Windows.Forms.ColumnHeader clCheckoutDate;
        private System.Windows.Forms.ColumnHeader clAcount;
    }
}