﻿using System;
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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsbBai1_Click(object sender, EventArgs e)
        {
            var frm = new frmBai1();
            frm.ShowDialog();
        }

        private void tsbBai2_Click(object sender, EventArgs e)
        {
            var frm = new frmBai2();
            frm.ShowDialog();
        }
    }
}
