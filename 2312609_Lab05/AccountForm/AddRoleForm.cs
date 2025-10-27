using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccountForm
{
    public partial class AddRoleForm : Form
    {
        private string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
        public AddRoleForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVaiTro.Text))
            {
                MessageBox.Show("Vui lòng nhập tên vai trò!", "Thông báo",
                    MessageBoxButtons.OK);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertRole";

                    cmd.Parameters.AddWithValue("@RoleName", txtVaiTro.Text.Trim());
                    cmd.Parameters.AddWithValue("@Path",
                        string.IsNullOrWhiteSpace(txtPath.Text) ? (object)DBNull.Value : txtPath.Text.Trim());
                    cmd.Parameters.AddWithValue("@Notes",
                        string.IsNullOrWhiteSpace(txtNotes.Text) ? (object)DBNull.Value : txtNotes.Text.Trim());

                    SqlParameter newRoleID = new SqlParameter("@NewRoleID", SqlDbType.Int);
                    newRoleID.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(newRoleID);

                    SqlParameter returnValue = cmd.Parameters.Add("@ReturnValue", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    cmd.ExecuteNonQuery();

                    int result = (int)returnValue.Value;

                    if (result == 1)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm vai trò!", "Lỗi",
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
