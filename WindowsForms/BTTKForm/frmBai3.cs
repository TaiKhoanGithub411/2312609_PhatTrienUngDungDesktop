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
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            var nghia = txtNghiaTu.Text;
            lbDSTu.Items.Add(tu);
            list.Add(nghia);
            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghiaTu.Text = "";
            lbDSTu.SelectedIndex = lbDSTu.Items.Count - 1;
            txtHienNghiaTu.Text = nghia;
        }

        private void lbDSTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = lbDSTu.SelectedIndex;
            txtHienNghiaTu.Text = list[stt];
        }
    }
}
