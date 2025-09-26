using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDe3_BT1.GUI
{
    public partial class frmNhapMonHoc : Form
    {
        public string TenMonHoc { get; private set; }
        public frmNhapMonHoc()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMonHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMonHoc.Focus();
                return;
            }

            TenMonHoc = txtTenMonHoc.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
