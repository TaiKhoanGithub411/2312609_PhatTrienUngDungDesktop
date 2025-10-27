using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccountForm
{
    public partial class AccountRolesForm : Form
    {
        private string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
        private string accountName;
        public AccountRolesForm(string accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
            this.Text = "Danh sách vai trò - " + accountName;
            LoadRolesData();
        }
        private void LoadRolesData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetRolesByAccount";

                    cmd.Parameters.AddWithValue("@AccountName", accountName);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvRoles.DataSource = dt;

                    if (dgvRoles.Columns["IsAssigned"] != null)
                    {
                        //dgvRoles.Columns["IsAssigned"].HeaderText = "Được gán";
                        dgvRoles.Columns["IsAssigned"].Width = 80;
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateAccountRoles";
                    foreach (DataGridViewRow row in dgvRoles.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int roleID = Convert.ToInt32(row.Cells["ID"].Value);
                        bool isAssigned = Convert.ToBoolean(row.Cells["IsAssigned"].Value);

                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@AccountName", accountName);
                        cmd.Parameters.AddWithValue("@RoleID", roleID);
                        cmd.Parameters.AddWithValue("@Actived", isAssigned);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật vai trò thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            AddRoleForm addRoleForm = new AddRoleForm();
            if (addRoleForm.ShowDialog() == DialogResult.OK)
            {
                LoadRolesData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
