using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {
        private string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
        public MainForm()
        {
            InitializeComponent();
            
        }
        #region Các hàm hỗ trợ khác
        private void LoadTableToListView()
        {
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"select ID, Name, Status, Capacity from dbo.[Table] order by ID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    lvBan.Items.Clear();
                    while (reader.Read())
                    {
                        // Tạo một hàng mới cho ListView
                        ListViewItem item = new ListViewItem(reader["ID"].ToString());
                        item.SubItems.Add(reader["Name"].ToString());
                        // Chuyển đổi trạng thái từ số (0 hoặc 1) sang chữ
                        string status = Convert.ToInt32(reader["Status"]) == 1 ? "Có khách" : "Trống";
                        item.SubItems.Add(status);
                        item.SubItems.Add(reader["Capacity"].ToString());
                        // Lưu ID của bàn vào Tag để dễ dàng truy xuất khi cần
                        item.Tag = reader["ID"];
                        lvBan.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách bàn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Kiểm tra dữ liệu đầu vào
        private bool ValidateTableInput(out string errorMessage, out int sucChua)
        {
            sucChua = 0;
            errorMessage = String.Empty;
            if(string.IsNullOrWhiteSpace(txtTenBan.Text))
            {
                errorMessage = "Vui lòng nhập tên bàn!";
                txtTenBan.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtSucChua.Text))
            {
                errorMessage = "Vui lòng nhập sức chứa!";
                txtTenBan.Focus();
                return false;
            }
            if (!int.TryParse(txtSucChua.Text, out sucChua) || sucChua <= 0)
            {
                errorMessage = "Sức chứa phải là số nguyên dương (lớn hơn 0)!";
                txtSucChua.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboTrangThai.Text))
            {
                errorMessage = "Vui lòng chọn trạng thái!";
                cboTrangThai.Focus();
                return false;
            }
            if (cboTrangThai.Text != "Trống" && cboTrangThai.Text != "Có khách")
            {
                errorMessage = "Trạng thái không hợp lệ! Vui lòng chọn 'Trống' hoặc 'Có khách'.";
                cboTrangThai.Focus();
                return false;
            }

            return true;
        }
        //Xóa trắng ô nhập liệu
        private void ClearInputFields()
        {
            txtTenBan.Clear();
            txtSucChua.Clear();
            cboTrangThai.SelectedIndex = -1;
            lvBan.SelectedItems.Clear();
        }
        //Lấy trạng thái bàn
        private int GetStatusValue()
        {
            return cboTrangThai.Text == "Có khách" ? 1 : 0;
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTableToListView();
        }

        private void lvBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvBan.SelectedItems.Count>0)
            {
                ListViewItem selectItem = lvBan.SelectedItems[0];
                txtTenBan.Text = selectItem.SubItems[1].Text;
                txtSucChua.Text = selectItem.SubItems[3].Text;
                cboTrangThai.Text = selectItem.SubItems[2].Text;
            }
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            ItemDMHoaDon.PerformClick();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu đầu vào
            if (!ValidateTableInput(out string errorMessage, out int sucChua))
            {
                MessageBox.Show(errorMessage, "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Chuyển đổi trạng thái từ chữ sang số
            int status = GetStatusValue();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO dbo.[Table] (Name, Status, Capacity) 
                            VALUES (@Name, @Status, @Capacity)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtTenBan.Text.Trim();
                    cmd.Parameters.Add("@Status", SqlDbType.Int).Value = status;
                    cmd.Parameters.Add("@Capacity", SqlDbType.Int).Value = sucChua;

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm bàn thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearInputFields();
                        LoadTableToListView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm bàn: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có bàn nào được chọn không
            if (lvBan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn cần cập nhật!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate dữ liệu đầu vào
            if (!ValidateTableInput(out string errorMessage, out int sucChua))
            {
                MessageBox.Show(errorMessage, "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID của bàn được chọn
            ListViewItem selectedItem = lvBan.SelectedItems[0];
            int tableID = Convert.ToInt32(selectedItem.SubItems[0].Text);

            // Chuyển đổi trạng thái từ chữ sang số
            int status = cboTrangThai.Text == "Có khách" ? 1 : 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE dbo.[Table] 
                            SET Name = @Name, Status = @Status, Capacity = @Capacity 
                            WHERE ID = @ID";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtTenBan.Text.Trim();
                    cmd.Parameters.Add("@Status", SqlDbType.Int).Value = status;
                    cmd.Parameters.Add("@Capacity", SqlDbType.Int).Value = sucChua;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tableID;

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật bàn thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadTableToListView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật bàn: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có bàn nào được chọn không
            if (lvBan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn cần xóa!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin bàn được chọn
            ListViewItem selectedItem = lvBan.SelectedItems[0];
            int tableID = Convert.ToInt32(selectedItem.SubItems[0].Text);
            string tableName = selectedItem.SubItems[1].Text;

            // Xác nhận xóa
            DialogResult dialogResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa bàn '{tableName}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kiểm tra xem bàn có hóa đơn nào không
                    string checkQuery = "SELECT COUNT(*) FROM Bills WHERE TableID = @TableID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.Add("@TableID", SqlDbType.Int).Value = tableID;

                    int billCount = (int)checkCmd.ExecuteScalar();

                    if (billCount > 0)
                    {
                        MessageBox.Show("Không thể xóa bàn này vì đã có hóa đơn liên quan!",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }

                    // Thực hiện xóa bàn
                    string deleteQuery = "DELETE FROM dbo.[Table] WHERE ID = @ID";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection);
                    deleteCmd.Parameters.Add("@ID", SqlDbType.Int).Value = tableID;

                    int result = deleteCmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa bàn thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Xóa dữ liệu trong các textbox
                        ClearInputFields();
                        // Tải lại danh sách bàn
                        LoadTableToListView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa bàn: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ItemXoaBan_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        private void ItemDMHoaDon_Click(object sender, EventArgs e)
        {
            // Kiểm tra có bàn nào được chọn không
            if (lvBan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một bàn!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin bàn được chọn
            ListViewItem selectedItem = lvBan.SelectedItems[0];
            int tableID = Convert.ToInt32(selectedItem.SubItems[0].Text);
            string tableName = selectedItem.SubItems[1].Text;

            // Mở form danh mục hóa đơn
            BillCatalogForm catalogForm = new BillCatalogForm(tableID, tableName, connectionString);
            catalogForm.ShowDialog();
        }

        private void ItemNKHoaDon_Click(object sender, EventArgs e)
        {
            // Kiểm tra có bàn nào được chọn không
            if (lvBan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một bàn!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin bàn được chọn
            ListViewItem selectedItem = lvBan.SelectedItems[0];
            int tableID = Convert.ToInt32(selectedItem.SubItems[0].Text);
            string tableName = selectedItem.SubItems[1].Text;

            // Mở form nhật ký hóa đơn
            BillLogForm logForm = new BillLogForm(tableID, tableName, connectionString);
            logForm.ShowDialog();
        }
    }
}
