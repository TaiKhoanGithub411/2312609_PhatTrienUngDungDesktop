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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }
        private string XepLoaiHocTap(float diemLyThuyet, float diemThucHanh)
        {
            float tb = (diemLyThuyet + diemThucHanh) / 2;
            if (diemLyThuyet < 5 || diemThucHanh < 5) 
                return "Yếu";
            else if (tb < 7) 
                return "Trung bình";
            else if (tb < 8) 
                return "Khá";
            else if (tb < 9) 
                return "Giỏi";
            else 
                return "Xuất sắc";
        }
        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            if (float.Parse(txtLyThuyet.Text) > 10 || float.Parse(txtThucHanh.Text) > 10)
            {
                MessageBox.Show("Điểm không được lớn hơn 10!",
                                "Lỗi nhập liệu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
                lblKQ.Text = XepLoaiHocTap(float.Parse(txtLyThuyet.Text), float.Parse(txtThucHanh.Text));
        }
    }
}
