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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNoiChuoi_Click(object sender, EventArgs e)
        {
            string kq;
            NoiChuoi_GiaiThua.NoiChuoi(txtHo.Text, txtTen.Text, out kq);
            lblKetQuaNoiChuoi.Text = kq;
        }

        private void btnTinhGiaiThua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            if (n < 0)
            {
                MessageBox.Show("Số phải là số nguyên không âm!",
                               "Lỗi tham số",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtSon.Focus();
                return;
            }
            else if (n > 20)
            {
                MessageBox.Show("Số quá lớn (tối đa 20)!",
                               "Lỗi tham số",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtSon.Focus();
                return;
            }
            long ketQua = NoiChuoi_GiaiThua.GiaiThuaDeQuy(int.Parse(txtSon.Text));
            lblKetQuaGiaiThua.Text = $"{n}! = {ketQua:N0}";
        }
    }
}
