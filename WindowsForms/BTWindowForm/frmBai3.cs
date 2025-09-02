using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowForm
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void txtSoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoa.Text);
            int b = int.Parse(txtSob.Text);
            int n = int.Parse(txtSon.Text);
            int kq = 0;
            if (rdCong.Checked)
                TinhToan.CongHaiSo(a, b, ref kq);
            else
                kq = TinhToan.TongDaySo(n);
            lblKetQua.Text = kq.ToString();
        }
    }
}
