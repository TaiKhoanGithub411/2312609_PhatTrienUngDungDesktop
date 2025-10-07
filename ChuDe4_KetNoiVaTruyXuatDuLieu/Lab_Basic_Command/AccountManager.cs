using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Basic_Command
{
    public partial class AccountManager : Form
    {
        private string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
        public AccountManager()
        {
            InitializeComponent();
            
        }
        #region Hàm xử lý khác
        //Hàm tải các vai trò vào ComboBox
        private void LoadRoleToComboBox()
        {
            using(SqlConnection sqlConnection=new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = "select ID, RoleName from Role";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    //Tạo datatable để truyền dữ liệu vào combobox
                    DataTable dtRole = new DataTable();
                    dtRole.Load(reader);
                    dtRole.Columns["ID"].AllowDBNull = true;

                    //Thêm dòng "Tất cả"
                    DataRow dtRowAll = dtRole.NewRow();
                    dtRowAll["ID"] = DBNull.Value;
                    dtRowAll["RoleName"] = "Tất cả";//thêm dòng tất cả chỉ để còn kết quả lọc là tất cả vai trò
                    dtRole.Rows.InsertAt(dtRowAll, 0);//thêm vào vị trí 0

                    //Bind vào combobox
                    cboNhomLoc.DataSource = dtRole;
                    cboNhomLoc.DisplayMember = "RoleName";
                    cboNhomLoc.ValueMember = "ID";
                    cboNhomLoc.SelectedIndex = 0;

                    // Clone DataTable cho cboNhomTK (trong GroupBox Thông tin)
                    DataTable dtRoleAccount = dtRole.Copy();
                    dtRoleAccount.Rows.RemoveAt(0); // Xóa dòng "Tất cả" vì một tài khoản phải thuộc một nhóm
                    cboNhomTK.DataSource = dtRoleAccount;
                    cboNhomTK.DisplayMember = "RoleName";
                    cboNhomTK.ValueMember = "ID";
                }
                catch(Exception e)
                {
                    MessageBox.Show($"Lỗi khi tải danh sách nhóm: {e.Message}", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Hàm tải trạng thái vào combobox
        private void LoadStatusToComboBox()
        {
            DataTable dtStatus = new DataTable();
            dtStatus.Columns.Add("Value", typeof(object));
            dtStatus.Columns.Add("Display", typeof(string));

            dtStatus.Rows.Add(DBNull.Value, "Tất cả");
            dtStatus.Rows.Add(1, "Kích hoạt");
            dtStatus.Rows.Add(0, "Vô hiệu hóa");

            cboTrangThai.DataSource = dtStatus;
            cboTrangThai.DisplayMember = "Display";
            cboTrangThai.ValueMember = "Value";
            cboTrangThai.SelectedIndex = 0;
        }
        //Hàm tải danh sách lên listview
        private void LoadAccountsToListView(int? roleID, int? actived)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query để lấy danh sách tài khoản kèm theo Role
                    string query = @"select a.AccountName, a.FullName, a.Email, a.[Password], b.ID as RoleID, b.RoleName, c.Actived from Account a, [Role] b, RoleAccount c where a.AccountName=c.AccountName and b.ID=c.RoleID";

                    // Thêm điều kiện lọc theo nhóm
                    if (roleID.HasValue)
                    {
                        query += " AND b.ID = @RoleID";
                    }

                    // Thêm điều kiện lọc theo trạng thái
                    if (actived.HasValue)
                    {
                        query += " AND c.Actived = @Actived";
                    }

                    query += " ORDER BY a.AccountName";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (roleID.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@RoleID", roleID.Value);
                    }

                    if (actived.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@Actived", actived.Value);
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Xóa dữ liệu cũ trong ListView
                    lvTaiKhoan.Items.Clear();

                    int stt = 1;
                    string lastAccountName = "";

                    while (reader.Read())
                    {
                        string accountName = reader["AccountName"].ToString();

                        // Tránh trùng lặp account (do JOIN với nhiều Role)
                        if (accountName == lastAccountName)
                            continue;

                        lastAccountName = accountName;

                        // Tạo ListViewItem
                        ListViewItem item = new ListViewItem(stt.ToString());
                        item.SubItems.Add(accountName);                    // Tên tài khoản
                        item.SubItems.Add(reader["FullName"].ToString()); // Họ tên
                        item.SubItems.Add(reader["Email"].ToString());    // Email
                        item.SubItems.Add(reader["RoleName"].ToString()); // Nhóm

                        // Xử lý trạng thái: 1 = "Kích hoạt", 0 = "Vô hiệu hóa"
                        int statusValue = reader["Actived"] != DBNull.Value
                            ? Convert.ToInt32(reader["Actived"])
                            : 0;
                        string statusDisplay = statusValue == 1 ? "Kích hoạt" : "Vô hiệu hóa";
                        item.SubItems.Add(statusDisplay);

                        // Lưu object AccountName vào Tag để dễ xử lý sau
                        item.Tag = accountName;

                        // Đổi màu dòng nếu vô hiệu hóa
                        if (statusValue == 0)
                        {
                            item.ForeColor = Color.Gray;
                        }
                        lvTaiKhoan.Items.Add(item);
                        stt++;
                    }

                    // Cập nhật StatusStrip
                    lblStripTongSo.Text = $"Tổng số: {lvTaiKhoan.Items.Count} tài khoản";
                    lblStripDangChon.Text = "Đang chọn: ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải danh sách tài khoản: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadComboBoxData()
        {
            // Load danh sách nhóm từ bảng Role
            LoadRoleToComboBox();

            // Load trạng thái
            LoadStatusToComboBox();
        }
        private void AccountManager_Load(object sender, EventArgs e)
        {
            try
            {
                // Load dữ liệu cho ComboBox
                LoadComboBoxData();

                // Load toàn bộ tài khoản lên ListView
                LoadAccountsToListView(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetComboBoxByText(ComboBox comboBox, string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                comboBox.SelectedIndex = -1;
                return;
            }

            // Tìm index của item có DisplayMember khớp với text
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                DataRowView item = comboBox.Items[i] as DataRowView;
                if (item != null && item["RoleName"].ToString() == text)
                {
                    comboBox.SelectedIndex = i;
                    return;
                }
            }

            // Nếu không tìm thấy, set về -1
            comboBox.SelectedIndex = -1;
        }
        private void ClearAccountInfo()
        {
            txtTenDN.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            cboNhomTK.SelectedIndex = -1;
            chkTrangThai.Checked = false;

            // Enable lại TextBox tên đăng nhập (cho phép thêm mới)
            txtTenDN.ReadOnly = false;
            txtTenDN.BackColor = SystemColors.Window;
            txtMatKhau.Text = "";
        }
        #endregion

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ ComboBox
                int? roleID = null;
                if (cboNhomLoc.SelectedValue != DBNull.Value && cboNhomLoc.SelectedIndex > 0)
                {
                    roleID = Convert.ToInt32(cboNhomLoc.SelectedValue);
                }

                int? actived = null;
                if (cboTrangThai.SelectedValue != DBNull.Value && cboTrangThai.SelectedIndex > 0)
                {
                    actived = Convert.ToInt32(cboTrangThai.SelectedValue);
                }

                // Load lại ListView với điều kiện lọc
                LoadAccountsToListView(roleID, actived);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvTaiKhoan.SelectedItems[0];
                txtTenDN.Text = selectedItem.SubItems[1].Text;
                txtHoTen.Text = selectedItem.SubItems[2].Text;
                txtEmail.Text = selectedItem.SubItems[3].Text;
                SetComboBoxByText(cboNhomTK, selectedItem.SubItems[4].Text);
                chkTrangThai.Checked = (selectedItem.SubItems[5].Text == "Kích hoạt");
                // Xóa mật khẩu (không hiển thị mật khẩu thật)
                txtMatKhau.Clear();
                txtMatKhau.Text = "Nhập mật khẩu mới nếu muốn thay đổi";
                lblStripDangChon.Text = $"Đang chọn: {selectedItem.SubItems[1].Text}";
                // Disable TextBox tên đăng nhập (không cho sửa primary key)
                txtTenDN.ReadOnly = true;
                txtTenDN.BackColor = SystemColors.Control;
            }
            else
            {
                lblStripDangChon.Text = "Đang chọn: ";
            }
        }
    }
}
