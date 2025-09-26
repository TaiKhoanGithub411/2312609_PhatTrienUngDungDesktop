
namespace ChuDe3_DocFileJSON
{
    partial class frmReadJSON
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
            this.btnReadJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadJson
            // 
            this.btnReadJson.Location = new System.Drawing.Point(113, 46);
            this.btnReadJson.Name = "btnReadJson";
            this.btnReadJson.Size = new System.Drawing.Size(157, 45);
            this.btnReadJson.TabIndex = 0;
            this.btnReadJson.Text = "Đọc file JSON";
            this.btnReadJson.UseVisualStyleBackColor = true;
            this.btnReadJson.Click += new System.EventHandler(this.btnReadJson_Click);
            // 
            // frmReadJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 150);
            this.Controls.Add(this.btnReadJson);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmReadJSON";
            this.Text = "frmReadJSONFile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadJson;
    }
}

