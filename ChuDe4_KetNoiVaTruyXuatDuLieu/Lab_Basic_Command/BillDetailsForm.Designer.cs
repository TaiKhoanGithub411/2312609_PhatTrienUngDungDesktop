
namespace Lab_Basic_Command
{
    partial class BillDetailsForm
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
            this.grboxCTHD = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvBillDetails = new System.Windows.Forms.ListView();
            this.lblBillID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.clNameFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grboxCTHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxCTHD
            // 
            this.grboxCTHD.Controls.Add(this.lblAccount);
            this.grboxCTHD.Controls.Add(this.lblDate);
            this.grboxCTHD.Controls.Add(this.lblBillID);
            this.grboxCTHD.Controls.Add(this.label3);
            this.grboxCTHD.Controls.Add(this.label2);
            this.grboxCTHD.Controls.Add(this.label1);
            this.grboxCTHD.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxCTHD.Location = new System.Drawing.Point(13, 13);
            this.grboxCTHD.Name = "grboxCTHD";
            this.grboxCTHD.Size = new System.Drawing.Size(567, 129);
            this.grboxCTHD.TabIndex = 0;
            this.grboxCTHD.TabStop = false;
            this.grboxCTHD.Text = "Thông tin hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài khoản:";
            // 
            // lvBillDetails
            // 
            this.lvBillDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNameFood,
            this.clPrice,
            this.clSoLuong,
            this.clThanhTien});
            this.lvBillDetails.FullRowSelect = true;
            this.lvBillDetails.GridLines = true;
            this.lvBillDetails.HideSelection = false;
            this.lvBillDetails.Location = new System.Drawing.Point(12, 148);
            this.lvBillDetails.Name = "lvBillDetails";
            this.lvBillDetails.Size = new System.Drawing.Size(568, 312);
            this.lvBillDetails.TabIndex = 1;
            this.lvBillDetails.UseCompatibleStateImageBehavior = false;
            this.lvBillDetails.View = System.Windows.Forms.View.Details;
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillID.Location = new System.Drawing.Point(121, 35);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(15, 22);
            this.lblBillID.TabIndex = 3;
            this.lblBillID.Text = ".";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(68, 87);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(15, 22);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = ".";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(379, 36);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(15, 22);
            this.lblAccount.TabIndex = 3;
            this.lblAccount.Text = ".";
            // 
            // clNameFood
            // 
            this.clNameFood.Text = "Tên món ăn";
            this.clNameFood.Width = 150;
            // 
            // clPrice
            // 
            this.clPrice.Text = "Đơn giá";
            this.clPrice.Width = 100;
            // 
            // clSoLuong
            // 
            this.clSoLuong.Text = "Số lượng";
            this.clSoLuong.Width = 90;
            // 
            // clThanhTien
            // 
            this.clThanhTien.Text = "Thành tiền";
            this.clThanhTien.Width = 100;
            // 
            // BillDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 495);
            this.Controls.Add(this.lvBillDetails);
            this.Controls.Add(this.grboxCTHD);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BillDetailsForm";
            this.Text = "BillDetailsForm";
            this.grboxCTHD.ResumeLayout(false);
            this.grboxCTHD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxCTHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.ListView lvBillDetails;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ColumnHeader clNameFood;
        private System.Windows.Forms.ColumnHeader clPrice;
        private System.Windows.Forms.ColumnHeader clSoLuong;
        private System.Windows.Forms.ColumnHeader clThanhTien;
    }
}