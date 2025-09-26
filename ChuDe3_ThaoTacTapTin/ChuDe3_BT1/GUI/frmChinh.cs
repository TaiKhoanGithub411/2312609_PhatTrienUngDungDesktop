using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ChuDe3_BT1.Models;
using ChuDe3_BT1.GUI;
namespace ChuDe3_BT1
{
    public partial class frmChinh : Form
    {
        private QLSinhVien qlsv;        
        public frmChinh()
        {
            //string projectPath = Path.Combine(Application.StartupPath, @"..\..\Data\DSSV_JSON.txt");
            //string projectPath = Path.Combine(Application.StartupPath, @"..\..\Data\DSSV_XML.xml");
            string projectPath = Path.Combine(Application.StartupPath, @"..\..\Data\DSSV_Text.txt");
            IDataSource dataSource = new TxtData(projectPath);
            InitializeComponent();
            qlsv = new QLSinhVien(dataSource);
            LoadMonHocFromFile();
            LoadListView();
        }
        #region  Xử lý load DS
        private void LoadListView()
        {
            lvDSSV.Items.Clear();
            foreach (var sv in qlsv.DSSV)
                ThemSVVaoLV(sv);
        }
        private void ThemSVVaoLV(SinhVien sv)
        {
            var item = new ListViewItem(sv.MSSV); // ListViewItem đại diện cho một dòng trên control ListView
            item.SubItems.Add(sv.HoTenLot);
            item.SubItems.Add(sv.Ten);
            item.SubItems.Add(sv.NgaySinh.ToShortDateString());
            item.SubItems.Add(sv.Lop);
            item.SubItems.Add(sv.SoCM);
            item.SubItems.Add(sv.SDT);
            item.SubItems.Add(sv.DiaChi);
            item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ"); // Thêm cột giới tính ở cuối, chuyển đổi bool sang text
            item.Tag = sv;
            lvDSSV.Items.Add(item);
        }
        #endregion
        #region Xử lý các sự kiện tương tác với giao diện
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có ít nhất một điều kiện được chọn hay không
                if (!chkMSSV.Checked && !chkTen.Checked && !chkLop.Checked)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một điều kiện tìm kiếm!",
                                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Lấy giá trị tìm kiếm từ các TextBox tương ứng với CheckBox được chọn
                string timMSSV = chkMSSV.Checked ? txtTimMSSV.Text.Trim() : string.Empty;
                string timTen = chkTen.Checked ? txtTimTen.Text.Trim() : string.Empty;
                string timLop = chkLop.Checked ? txtTimLop.Text.Trim() : string.Empty;
                List<SinhVien> ketQuaTimKiem = qlsv.TimKiem(timMSSV, timTen, timLop);
                lvDSSV.Items.Clear();
                if (ketQuaTimKiem.Count > 0)
                {
                    // Hiển thị kết quả tìm kiếm
                    foreach (var sv in ketQuaTimKiem)
                    {
                        ThemSVVaoLV(sv);
                    }
                }
                else
                {
                    // Không tìm thấy kết quả
                    MessageBox.Show("Không tìm thấy sinh viên nào phù hợp với điều kiện tìm kiếm.",
                                   "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn thoát chương trình?","Thoát chương trình",
        MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSSV.SelectedItems.Count > 0)
            {
                var sv = lvDSSV.SelectedItems[0].Tag as SinhVien;
                if (sv != null)
                {
                    HienThiThongTin(sv);
                }
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraInput()) return;

            var sv = GetSinhVienFromControls();            
            qlsv.CapNhat(sv);
            qlsv.LuuDuLieu();
            // Update ListView
            var item = lvDSSV.FindItemWithText(sv.MSSV);
            if (item != null)
            {
                item.SubItems[1].Text = sv.HoTenLot;
                item.SubItems[2].Text = sv.Ten;
                item.SubItems[3].Text = sv.NgaySinh.ToShortDateString();
                item.SubItems[4].Text = sv.Lop;
                item.SubItems[5].Text = sv.SoCM;
                item.SubItems[6].Text = sv.SDT;
                item.SubItems[7].Text = sv.DiaChi;
                item.Tag = sv;
            }
            XoaDuLieuTrenLV();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraInput()) return;

            var sv = GetSinhVienFromControls();

            if (qlsv.KiemTraTonTai(sv.MSSV))
            {
                MessageBox.Show("MSSV đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            qlsv.Them(sv);
            qlsv.LuuDuLieu();
            ThemSVVaoLV(sv);
            XoaDuLieuTrenLV();
        }
        private void ItemXoaSV_Click(object sender, EventArgs e)
        {
            if(lvDSSV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            var result = MessageBox.Show("Chắn chắn xóa sinh viên đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes) 
            {
                var mssvList=new List<string>();
                foreach(ListViewItem item in lvDSSV.SelectedItems)
                {
                    mssvList.Add(item.Text);
                }
                qlsv.Xoa(mssvList);
                qlsv.LuuDuLieu();
                XoaDuLieuTrenLV();
                LoadListView();
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadListView();
            // Xóa các điều kiện tìm kiếm
            chkMSSV.Checked = false;
            chkTen.Checked = false;
            chkLop.Checked = false;
            txtTimMSSV.Text = "";
            txtTimTen.Text = "";
            txtTimLop.Text = "";
        }
        #endregion
        #region Hàm xử lý các tác vụ khác
        private void HienThiThongTin(SinhVien sv)
        {
            txtMSSV.Text = sv.MSSV;
            txtHoTenLot.Text = sv.HoTenLot;
            dtpNgaySinh.Value = sv.NgaySinh;
            txtSoCM.Text = sv.SoCM;
            rdNam.Checked = sv.GioiTinh;
            rdNu.Checked = !sv.GioiTinh;
            txtTen.Text = sv.Ten;
            mtxtSDT.Text = sv.SDT;
            cboLop.Text = sv.Lop;
            txtDiaChi.Text = sv.DiaChi;
            for(int i=0; i<chlMonHoc.Items.Count; i++)
            {
                chlMonHoc.SetItemChecked(i, sv.MonHocDangKy.Contains(chlMonHoc.Items[i].ToString()));
            }
        }
        private void XoaDuLieuTrenLV()
        {
            txtMSSV.Text = "";
            txtHoTenLot.Text = "";
            txtTen.Text = "";
            rdNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            cboLop.Text = "";
            txtSoCM.Text = "";
            mtxtSDT.Text = "";
            txtDiaChi.Text = "";
            for (int i = 0; i < chlMonHoc.Items.Count; i++)
            {
                chlMonHoc.SetItemChecked(i, false);
            }
            txtMSSV.Focus();
        }
        private SinhVien GetSinhVienFromControls()
        {
            var monHoc = new List<string>();
            foreach (var item in chlMonHoc.CheckedItems)
            {
                monHoc.Add(item.ToString());
            }
            return new SinhVien
            {
                MSSV = txtMSSV.Text,
                HoTenLot = txtHoTenLot.Text,
                Ten = txtTen.Text,
                GioiTinh = rdNam.Checked,
                NgaySinh = dtpNgaySinh.Value,
                Lop = cboLop.Text,
                SoCM = txtSoCM.Text,
                SDT = mtxtSDT.Text,
                DiaChi = txtDiaChi.Text,
                MonHocDangKy = monHoc
            };
        }
        private bool KiemTraInput()
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTenLot.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(cboLop.Text) ||
                string.IsNullOrWhiteSpace(txtSoCM.Text) ||
                !mtxtSDT.MaskCompleted ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Lấy 2 chữ số cuối cùng từ năm
            var namNhapHoc = "20" + cboLop.Text.Substring(2, 2); // Lấy "23" từ "DH23IT"
            var mssvPattern = $"^{namNhapHoc.Substring(2)}10[0-9]{{3}}$"; // "2310XXX"

            if (!Regex.IsMatch(txtMSSV.Text, mssvPattern))
            {
                MessageBox.Show($"MSSV không hợp lệ cho lớp {cboLop.Text}. Định dạng phải là {namNhapHoc.Substring(2)}10CCC.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion
        #region Xử lý danh sách môn học
        private void LoadMonHocFromFile()
        {
            try
            {
                var danhSachMonHoc = QLMonHoc.LoadMonHoc();
                chlMonHoc.Items.Clear();
                foreach (var monHoc in danhSachMonHoc)
                {
                    chlMonHoc.Items.Add(monHoc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveMonHocToFile()
        {
            try
            {
                var danhSachMonHoc = new List<string>();

                for (int i = 0; i < chlMonHoc.Items.Count; i++)
                {
                    danhSachMonHoc.Add(chlMonHoc.Items[i].ToString());
                }

                QLMonHoc.SaveMonHoc(danhSachMonHoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu danh sách môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ItemXoaMon_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có môn nào được chọn không
                if (chlMonHoc.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn một môn học để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string tenMonHoc = chlMonHoc.SelectedItem.ToString();
                // Xác nhận xóa
                var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa môn '{tenMonHoc}' không?",
                                           "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Xóa khỏi CheckedListBox
                    chlMonHoc.Items.RemoveAt(chlMonHoc.SelectedIndex);
                    // Lưu vào file
                    SaveMonHocToFile();
                    MessageBox.Show($"Đã xóa môn '{tenMonHoc}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ItemThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                var frmNhapMon = new frmNhapMonHoc();
                if (frmNhapMon.ShowDialog() == DialogResult.OK)
                {
                    string tenMonHocMoi = frmNhapMon.TenMonHoc;
                    // Kiểm tra trùng lặp
                    bool daTonTai = false;
                    for (int i = 0; i < chlMonHoc.Items.Count; i++)
                    {
                        if (chlMonHoc.Items[i].ToString().Equals(tenMonHocMoi, StringComparison.OrdinalIgnoreCase))
                        {
                            daTonTai = true;
                            break;
                        }
                    }
                    if (daTonTai)
                    {
                        MessageBox.Show("Môn học này đã tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // Thêm vào CheckedListBox
                    chlMonHoc.Items.Add(tenMonHocMoi);
                    // Lưu vào file
                    SaveMonHocToFile();
                    MessageBox.Show($"Đã thêm môn '{tenMonHocMoi}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
