using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowForm_Bai2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            int kq = 0;
            if (rdCong.Checked)
                kq = a + b;
            else if (rdTru.Checked)
                kq = a - b;
            else if (rdNhan.Checked)
                kq = a * b;
            else
                kq = a / b;                
            lblKetQua.Text = kq.ToString();
        }
    }
}
