using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTKForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void rdXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "22000";
            pictureBox.Image = Image.FromFile("image/Xe-xanh.png");
        }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "21000";
            pictureBox.Image = Image.FromFile("image/Xe-do.png");
        }

        private void rdTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "20000";
            pictureBox.Image = Image.FromFile("image/Xe-trang.png");
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int sotien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
            lblSoTien.Text = sotien.ToString();
        }
    }
}
