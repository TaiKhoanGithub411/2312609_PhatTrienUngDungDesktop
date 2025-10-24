using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AccountManager
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
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
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
                catch (Exception e)
                {
                    MessageBox.Show($"Lỗi khi tải danh sách nhóm: {e.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #region Phần sự kiện trên form
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra thông tin
            if (string.IsNullOrWhiteSpace(txtTenDN.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin (tên đăng nhập, mật khẩu, họ tên)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string accountname = txtTenDN.Text.Trim();
            string mk = txtMatKhau.Text.Trim();
            string name = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            int roleID = (int)cboNhomTK.SelectedValue;
            bool actived = chkTrangThai.Checked;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null; //Dùng Transaction để đảm bảo toàn vẹn dữ liệu - chỉ khi thêm dữ liệu vào cả hai bảng Account và RoleAccount thành công thì mới được coi là thành công.
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    //Thêm vào bảng Account
                    string queryAccount = "INSERT INTO Account (AccountName, Password, FullName, Email) VALUES (@AccountName, @Password, @FullName, @Email)";
                    SqlCommand cmdAccount = new SqlCommand(queryAccount, connection, transaction);
                    cmdAccount.Parameters.AddWithValue("@AccountName", accountname);
                    cmdAccount.Parameters.AddWithValue("@Password", mk); // Nên mã hóa mật khẩu
                    cmdAccount.Parameters.AddWithValue("@FullName", name);
                    cmdAccount.Parameters.AddWithValue("@Email", email);
                    cmdAccount.ExecuteNonQuery();

                    //Thêm vào bảng RoleAccount
                    string queryRoleAccount = "INSERT INTO RoleAccount (RoleID, AccountName, Actived, Notes) VALUES (@RoleID, @AccountName, @Actived, NULL)";
                    SqlCommand cmdRoleAccount = new SqlCommand(queryRoleAccount, connection, transaction);
                    cmdRoleAccount.Parameters.AddWithValue("@RoleID", roleID);
                    cmdRoleAccount.Parameters.AddWithValue("@AccountName", accountname);
                    cmdRoleAccount.Parameters.AddWithValue("@Actived", actived);
                    cmdRoleAccount.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Thêm tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại danh sách tài khoản và xóa thông tin trên các control
                    LoadAccountsToListView(null, null);
                    ClearAccountInfo();
                }
                catch (SqlException ex)
                {
                    // Nếu có lỗi, rollback lại giao dịch
                    if (transaction != null) transaction.Rollback();

                    // Kiểm tra lỗi trùng khóa chính (tên đăng nhập đã tồn tại)
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Lấy thông tin từ các control
            string accountName = txtTenDN.Text.Trim();
            string fullName = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            int roleID = (int)cboNhomTK.SelectedValue;
            bool actived = chkTrangThai.Checked;
            string newPassword = txtMatKhau.Text;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // Cập nhật bảng Account
                    // Kiểm tra xem người dùng có muốn đổi mật khẩu không
                    string queryAccount;
                    if (!string.IsNullOrWhiteSpace(newPassword) && newPassword != "Nhập mật khẩu mới nếu muốn thay đổi")
                    {
                        queryAccount = "UPDATE Account SET FullName = @FullName, Email = @Email, Password = @Password WHERE AccountName = @AccountName";
                    }
                    else
                    {
                        queryAccount = "UPDATE Account SET FullName = @FullName, Email = @Email WHERE AccountName = @AccountName";
                    }

                    SqlCommand cmdAccount = new SqlCommand(queryAccount, conn, transaction);
                    cmdAccount.Parameters.AddWithValue("@FullName", fullName);
                    cmdAccount.Parameters.AddWithValue("@Email", email);
                    cmdAccount.Parameters.AddWithValue("@AccountName", accountName);
                    if (!string.IsNullOrWhiteSpace(newPassword) && newPassword != "Nhập mật khẩu mới nếu muốn thay đổi")
                    {
                        cmdAccount.Parameters.AddWithValue("@Password", newPassword);
                    }
                    cmdAccount.ExecuteNonQuery();


                    // Cập nhật bảng RoleAccount
                    string queryRoleAccount = "UPDATE RoleAccount SET RoleID = @RoleID, Actived = @Actived WHERE AccountName = @AccountName";
                    SqlCommand cmdRoleAccount = new SqlCommand(queryRoleAccount, conn, transaction);
                    cmdRoleAccount.Parameters.AddWithValue("@RoleID", roleID);
                    cmdRoleAccount.Parameters.AddWithValue("@Actived", actived);
                    cmdRoleAccount.Parameters.AddWithValue("@AccountName", accountName);
                    cmdRoleAccount.ExecuteNonQuery();

                    // Hoàn tất giao dịch
                    transaction.Commit();

                    MessageBox.Show("Cập nhật tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại danh sách và xóa thông tin
                    LoadAccountsToListView(null, null);
                    ClearAccountInfo();
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show("Lỗi khi cập nhật tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để reset mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ListViewItem selectedItem = lvTaiKhoan.SelectedItems[0];
            // Lấy AccountName đã được lưu trong Tag khi load dữ liệu
            string accountName = selectedItem.Tag.ToString();
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn reset mật khẩu cho tài khoản '{accountName}' không?\nMật khẩu sẽ được đặt lại về mặc định là '2312609'.",
                                     "Xác nhận Reset Mật khẩu",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            string defaultPassword = "2312609";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE Account SET Password = @Password WHERE AccountName = @AccountName";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Luôn sử dụng parameters để tránh lỗi SQL Injection
                    cmd.Parameters.AddWithValue("@Password", defaultPassword); // Nên thay bằng mật khẩu đã được băm
                    cmd.Parameters.AddWithValue("@AccountName", accountName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reset mật khẩu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Xóa ô mật khẩu trên form để tránh nhầm lẫn
                        txtMatKhau.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản hoặc đã có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi reset mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ItemXoaTK_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string accountName = lvTaiKhoan.SelectedItems[0].Tag.ToString();
            // Xác nhận hành động từ người dùng
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn vô hiệu hóa tất cả vai trò của tài khoản '{accountName}' không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Câu lệnh cập nhật trạng thái Actived = 0 cho tất cả các vai trò của tài khoản
                    string query = "UPDATE RoleAccount SET Actived = 0 WHERE AccountName = @AccountName";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AccountName", accountName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã vô hiệu hóa thành công tất cả vai trò của tài khoản.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Tải lại danh sách để cập nhật giao diện
                        LoadAccountsToListView(null, null);
                        ClearAccountInfo();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản này không có vai trò nào được gán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ItemXemDSVaiTro_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xem danh sách vai trò.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Lấy tên tài khoản từ Tag
            string accountName = lvTaiKhoan.SelectedItems[0].Tag.ToString();
            // Tạo và hiển thị form RolesForm
            AccountRoleForm rolesForm = new AccountRoleForm(accountName);
            rolesForm.ShowDialog(this);
        }
        #endregion
    }
}
