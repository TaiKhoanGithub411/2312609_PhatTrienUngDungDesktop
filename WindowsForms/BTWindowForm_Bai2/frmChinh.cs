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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void bàiSố2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmBai2();
            frm.ShowDialog();
        }

        private void bàiSố1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmBai1();
            frm.ShowDialog();
        }

        private void bàiSố3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmBai3();
            frm.ShowDialog();
        }
    }
}
