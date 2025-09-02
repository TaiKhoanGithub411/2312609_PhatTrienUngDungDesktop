using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm_Bai3
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            if(rdTong.Checked)
            {
                int kqTong = 0;
                for (int i = 1; i <= n; i++)
                    kqTong += i;
                lblKQ.Text = kqTong.ToString();
            }
            else if(rdGiaiThua.Checked)
            {
                long kqGiaiThua = 1;
                for (int i = 1; i <= n; i++)
                    kqGiaiThua *= i;
                lblKQ.Text = kqGiaiThua.ToString();
            }
        }
    }
}
