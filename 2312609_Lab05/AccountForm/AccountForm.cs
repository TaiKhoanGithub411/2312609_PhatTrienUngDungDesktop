using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccountForm
{
    public partial class AccountForm : Form
    {
        private string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
        public AccountForm()
        {
            InitializeComponent();
            LoadAccountsData();
        }
        #region Hàm xử lý khác
        private void LoadAccountsData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetAllAccounts";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDSTK.DataSource = dt;

                    // Ẩn cột Password
                    if (dgvDSTK.Columns["Password"] != null)
                        dgvDSTK.Columns["Password"].Visible = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            txtTenTK.Text = "";
            txtHoTenTK.Text = "";
            txtEmailTK.Text = "";
            txtPassTK.Text = "";
            mtxtSDTTK.Text = "";
        }
        #endregion

        private void dgvDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra click vào cell hợp lệ (không phải header)
            if (e.RowIndex >= 0)
            {
                // Hiển thị thông tin lên panel
                DataGridViewRow row = dgvDSTK.Rows[e.RowIndex];
                txtTenTK.Enabled = false;
                txtTenTK.Text = row.Cells["AccountName"].Value.ToString();
                txtHoTenTK.Text = row.Cells["FullName"].Value.ToString();
                txtEmailTK.Text = row.Cells["Email"].Value?.ToString() ?? "";
                mtxtSDTTK.Text = row.Cells["Tell"].Value?.ToString() ?? "";
                txtPassTK.Text = row.Cells["PassWord"].Value.ToString();
                dptDateCreated.Enabled = false;
                if (row.Cells["DateCreated"].Value != DBNull.Value)
                    dptDateCreated.Value = Convert.ToDateTime(row.Cells["DateCreated"].Value);
                else
                    dptDateCreated.Value = DateTime.Now;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtTenTK.Text)||String.IsNullOrWhiteSpace(txtHoTenTK.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản và họ tên", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                using(SqlConnection conn=new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertAccount";

                    cmd.Parameters.AddWithValue("@AccountName", txtTenTK.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassTK.Text); // Mật khẩu mặc định
                    cmd.Parameters.AddWithValue("@FullName", txtHoTenTK.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email",
                        string.IsNullOrWhiteSpace(txtEmailTK.Text) ? (object)DBNull.Value : txtEmailTK.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tell",
                        string.IsNullOrWhiteSpace(mtxtSDTTK.Text) ? (object)DBNull.Value : mtxtSDTTK.Text.Trim());
                    cmd.Parameters.AddWithValue("@DateCreated", dptDateCreated.Value);

                    SqlParameter returnValue = cmd.Parameters.Add("@ReturnValue", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    cmd.ExecuteNonQuery();

                    int result = (int)returnValue.Value;

                    if (result == 1)
                    {
                        MessageBox.Show("Thêm tài khoản thành công!",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccountsData();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm tài khoản!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi SQL");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtTenTK.Text))
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để cập nhật", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateAccount";

                    cmd.Parameters.AddWithValue("@AccountName", txtTenTK.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassTK.Text.Trim());
                    cmd.Parameters.AddWithValue("@FullName", txtHoTenTK.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email",
                        string.IsNullOrWhiteSpace(txtEmailTK.Text) ? (object)DBNull.Value : txtEmailTK.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tell",
                        string.IsNullOrWhiteSpace(mtxtSDTTK.Text) ? (object)DBNull.Value : mtxtSDTTK.Text.Trim());

                    SqlParameter returnValue = cmd.Parameters.Add("@ReturnValue", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    cmd.ExecuteNonQuery();

                    int result = (int)returnValue.Value;

                    if (result == 1)
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccountsData();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật tài khoản!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi SQL");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTK.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần reset mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK);
                return;
            }
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc muốn reset mật khẩu về '123456' cho tài khoản này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult==DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "ResetPassword";

                        cmd.Parameters.AddWithValue("@AccountName", txtTenTK.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewPassword", "123456");

                        SqlParameter returnValue = cmd.Parameters.Add("@ReturnValue", SqlDbType.Int);
                        returnValue.Direction = ParameterDirection.ReturnValue;

                        cmd.ExecuteNonQuery();

                        int result = (int)returnValue.Value;

                        if (result == 1)
                        {
                            MessageBox.Show("Reset mật khẩu thành công! Mật khẩu mới: 123456",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể reset mật khẩu!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi SQL");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                }
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            AddRoleForm addRoleForm = new AddRoleForm();
            if (addRoleForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Đã thêm vai trò mới thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuItemViewRoles_Click(object sender, EventArgs e)
        {
            if (dgvDSTK.CurrentRow != null)
            {
                string accountName = dgvDSTK.CurrentRow.Cells["AccountName"].Value.ToString();
                AccountRolesForm rolesForm = new AccountRolesForm(accountName);
                rolesForm.ShowDialog();
            }
        }

        private void menuItemViewActivity_Click(object sender, EventArgs e)
        {

        }
    }
}
