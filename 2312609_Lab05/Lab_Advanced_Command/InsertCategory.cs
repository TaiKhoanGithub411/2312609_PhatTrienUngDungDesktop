using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_Advanced_Command
{
    public partial class InsertCategory : Form
    {
        private string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
        public int NewCategoryID { get; private set; }//ID Category vừa thêm
        public bool IsSuccess { get; private set; }//Kiểm tra việc thêm có thành công

        public InsertCategory()
        {
            InitializeComponent();
            NewCategoryID = -1;
            IsSuccess = false;
        }

        private void InsertCategory_Load(object sender, EventArgs e)
        {
            //Tải loại nhóm món ăn vào combo box
            cbbTypeCat.Items.Add("Thức ăn"); // Index 0 → Type = 1
            cbbTypeCat.Items.Add("Đồ uống"); // Index 1 → Type = 0
            cbbTypeCat.SelectedIndex = 0; //Mặc định "Thức ăn"
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = txtNameCat.Text.Trim();

                // Validate input
                if (string.IsNullOrEmpty(categoryName))
                {
                    MessageBox.Show("Vui lòng nhập tên nhóm món ăn!",
                                  "Thông báo",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    txtNameCat.Focus();
                    return;
                }

                // Chuyển đổi lựa chọn thành Type
                int type = (cbbTypeCat.SelectedIndex == 0) ? 1 : 0;

                // Gọi Stored Procedure để thêm
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertCategory";

                // Thêm tham số
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@type", SqlDbType.Int);

                // Đặt hướng OUTPUT cho @id
                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                // Gán giá trị
                cmd.Parameters["@name"].Value = categoryName;
                cmd.Parameters["@type"].Value = type;

                conn.Open();
                int returnValue = cmd.ExecuteNonQuery();

                if (returnValue > 0)
                {
                    NewCategoryID = (int)cmd.Parameters["@id"].Value;
                    IsSuccess = true;

                    MessageBox.Show($"Thêm nhóm món ăn '{categoryName}' thành công!",
                                  "Thông báo",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                    // Đóng form với kết quả OK
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhóm món ăn thất bại!",
                                  "Lỗi",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }

                conn.Close();
                conn.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi SQL",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
