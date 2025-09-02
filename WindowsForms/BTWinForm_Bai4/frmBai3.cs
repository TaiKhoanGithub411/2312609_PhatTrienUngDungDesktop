using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm_Bai4
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnChao_Click(object sender, EventArgs e)
        {
            bool gioiTinhNam = rdNam.Checked;
            XuLy_Bai4.ChaoHoi(txtHoTen.Text, gioiTinhNam);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            lblKQ.Text=$"{XuLy_Bai4.USCLN(int.Parse(txtM.Text),int.Parse(txtN.Text))}";
        }
    }
}
