using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiuaKy_OnTap_De3
{
    public partial class MainForm : Form
    {
        private QLDocGia qLDocGia;
        public MainForm()
        {
            string projectPath = Path.Combine(Application.StartupPath, @"..\..\DSSV_Excel.xlsx");
            IDataSource dataSource = new ExcelData(projectPath);
            InitializeComponent();
            qLDocGia = new QLDocGia(dataSource);
            LoadDGV();
        }
        private void ThemDGVaoDGV(DocGia docGia)
        {
            DataGridViewRow row = (DataGridViewRow)dtagvDSDG.RowTemplate.Clone();
            row.CreateCells(dtagvDSDG);

            row.Cells[dtagvDSDG.Columns["clMaDocGia"].Index].Value = docGia.MaDocGia;
            row.Cells[dtagvDSDG.Columns["clTenDocGia"].Index].Value = docGia.TenDocGia;
            row.Cells[dtagvDSDG.Columns["clSDT"].Index].Value = docGia.SDT;
            row.Cells[dtagvDSDG.Columns["clDiaChi"].Index].Value = docGia.DiaChi;
            row.Tag = docGia;
            dtagvDSDG.Rows.Add(row);
        }
        private void LoadDGV()
        {
            dtagvDSDG.Rows.Clear();
            foreach(var dg in qLDocGia.DSDG)
            {
                ThemDGVaoDGV(dg);
            }
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaDocGia.Text = "";
            txtTenDocGia.Text = "";
            mtxtSDT.Text = "";
            txtDiaChi.Text = "";
            txtTimKiem.Text = "";
        }
        private void dtagvDSDG_SelectionChanged(object sender, EventArgs e)
        {
            if(dtagvDSDG.SelectedRows.Count>0)
            {
                var dg = dtagvDSDG.SelectedRows[0].Tag as DocGia;
                if(dg!=null)
                {
                    txtMaDocGia.Text = dg.MaDocGia;
                    txtTenDocGia.Text = dg.TenDocGia;
                    mtxtSDT.Text = dg.SDT;
                    txtDiaChi.Text = dg.DiaChi;
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtTenDocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập tên độc giả!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDocGia.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(mtxtSDT.Text) || mtxtSDT.Text.Replace(".", "").Trim().Length < 10)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số điện thoại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtSDT.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }

            // Kiểm tra: Thêm mới hay Cập nhật?
            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text))
            {
                // THÊM MỚI - Ô mã độc giả trống
                MessageBox.Show("Vui lòng nhập mã độc giả!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDocGia.Focus();
                return;
            }
            else
            {
                // Tạo đối tượng DocGia từ dữ liệu nhập
                var docGia = new DocGia
                {
                    MaDocGia = txtMaDocGia.Text.Trim(),
                    TenDocGia = txtTenDocGia.Text.Trim(),
                    SDT = mtxtSDT.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim()
                };

                // Kiểm tra mã độc giả có tồn tại không
                if (qLDocGia.KiemTraTonTai(docGia.MaDocGia))
                {
                    // CẬP NHẬT - Mã đã tồn tại
                    qLDocGia.CapNhat(docGia);
                    MessageBox.Show("Cập nhật thông tin độc giả thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // THÊM MỚI - Mã chưa tồn tại
                    qLDocGia.Them(docGia);
                    MessageBox.Show("Thêm độc giả mới thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Load lại toàn bộ DataGridView
                LoadDGV();

                // Xóa trắng các ô nhập sau khi lưu
                btnXoaTrang_Click(sender, e);
            }
        }

    }
}
