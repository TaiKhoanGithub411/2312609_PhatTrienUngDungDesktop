using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccountManager
{
    public partial class AccountRoleForm : Form
    {
        private string accountName;
        private string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
        public AccountRoleForm(string account)
        {
            InitializeComponent();
            accountName = account;
            this.Text = "Các vai trò của tài khoản: " + accountName;
        }
        private void LoadRolesForAccount()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Truy vấn để lấy tất cả các vai trò được gán cho tài khoản
                    string query = @"SELECT r.RoleName, ra.Actived 
                                 FROM Role r
                                 JOIN RoleAccount ra ON r.ID = ra.RoleID
                                 WHERE ra.AccountName = @AccountName";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AccountName", this.accountName);

                    SqlDataReader reader = cmd.ExecuteReader();
                    lvRoles.Items.Clear();

                    while (reader.Read())
                    {
                        string roleName = reader["RoleName"].ToString();
                        string status = Convert.ToBoolean(reader["Actived"]) ? "Kích hoạt" : "Vô hiệu hóa";

                        ListViewItem item = new ListViewItem(roleName);
                        item.SubItems.Add(status);
                        lvRoles.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách vai trò: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AccountRoleForm_Load(object sender, EventArgs e)
        {
            LoadRolesForAccount();
        }
    }
}
