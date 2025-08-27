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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }
                
        private void btnChon_Click(object sender, EventArgs e)
        {
            var item = lbHangHoa.SelectedItem;
            lbKhachMua.Items.Add(item);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            lbKhachMua.Items.Remove(lbKhachMua.SelectedItem);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach(string hang in lbKhachMua.Items)
            {
                switch(hang)
                {
                    case "Chuột":
                        s += 100000;
                        break;
                    case "Bàn phím":
                        s += 150000;
                        break;
                    case "Máy in":
                        s += 2000000;
                        break;
                    case "USB Kingmax":
                        s += 200000;
                        break;
                    default:
                        break;
                }
                lblSoTien.Text = s + " đồng";
            }
        }
    }
}
