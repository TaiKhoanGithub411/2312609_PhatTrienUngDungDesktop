using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_ThietKeFrom_Bai1._2
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void rdXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "22000";
        }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "21000";
        }

        private void rdTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "20000";
        }

        private void btnTInhTien_Click(object sender, EventArgs e)
        {
            int sotien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
            lblSotTien.Text = sotien.ToString();
        }
    }
}
