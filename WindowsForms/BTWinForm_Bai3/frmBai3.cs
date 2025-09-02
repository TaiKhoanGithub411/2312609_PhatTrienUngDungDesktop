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
    public partial class frmBai3 : Form
    {
        private XuLyChuoi xuLy = new XuLyChuoi();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnTachChuoi_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            string ho, ten;
            xuLy.TachChuoi(hoten, out ho, out ten);
            txtHo.Text = ho;
            txtTen.Text = ten;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtSo1.Text);
            int n2 = int.Parse(txtSo2.Text);
            bool ketQua = xuLy.ThuTu(n1, n2);
            lblKQ.Text = ketQua ? "Hai số liên tiếp" : "Không liên tiếp";
        }
    }
}
