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
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
            //LoadFood();
        }
        #region Phần hàm xử lý khác
        public void LoadFood(int categoryID)
        {
            string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Select Name from Category where ID = " + categoryID;
            sqlConnection.Open();
            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;
            sqlCommand.CommandText = "Select * from Food where FoodCategoryID =" + categoryID;
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Food");
            da.Fill(dt);
            dgvFood.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }
        #endregion
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count < 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))//Sử dụng using để tự động đóng sau khi dùng xong
            {
                sqlConnection.Open();
                foreach (DataGridViewRow row in dgvFood.SelectedRows)
                {
                    object idValue = row.Cells["clMaMon"].Value;//Lấy giá trị của cột mã món
                    if (idValue == null) continue;
                    if (!int.TryParse(idValue.ToString(), out int id)) continue;
                    using (SqlCommand cmdDelete = new SqlCommand("Delete from Food where ID = @ID", sqlConnection))
                    {
                        cmdDelete.Parameters.AddWithValue("@ID", id);
                        cmdDelete.ExecuteNonQuery();
                    }
                    dgvFood.Rows.Remove(row);
                }
            }
            MessageBox.Show("Xóa món ăn thành công");
        }
        private void btnSaveFood_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                foreach (DataGridViewRow row in dgvFood.Rows)
                {
                    if (row.IsNewRow) continue;//Bỏ qua dòng chưa nhập
                    object idValue = row.Cells["clMaMon"].Value;
                    string name = Convert.ToString(row.Cells["clTenMon"].Value);
                    string dvt = Convert.ToString(row.Cells["clDVT"].Value);
                    object foodCateID = row.Cells["clMaNhom"].Value;
                    object priceValues = row.Cells["clDonGia"].Value;
                    string note = Convert.ToString(row.Cells["clGhiChu"].Value);

                    if (string.IsNullOrEmpty(name) || foodCateID == null) continue;
                    int price = 0;
                    int.TryParse(priceValues?.ToString() ?? "0", out price);
                    int categoryID = Convert.ToInt32(foodCateID);

                    if (idValue == null || idValue == DBNull.Value || idValue.ToString() == "0")
                    {
                        //Thêm mới
                        string insert = "Insert into Food(Name, DVT, FoodCategoryID, Price, Note) values(@Name, @DVT, @FoodCategoryID, @Price, @Note)";
                        SqlCommand cmdInsert = new SqlCommand(insert, sqlConnection);
                        cmdInsert.Parameters.AddWithValue("@Name", name);
                        cmdInsert.Parameters.AddWithValue("@DVT", dvt ?? "");
                        cmdInsert.Parameters.AddWithValue("@FoodCategoryID", categoryID);
                        cmdInsert.Parameters.AddWithValue("@Price", price);
                        cmdInsert.Parameters.AddWithValue("@Note", note);
                        cmdInsert.ExecuteNonQuery();
                    }
                    else
                    {
                        //Cập nhật món ăn đã có
                        int id = Convert.ToInt32(idValue);
                        string update = @"Update Food set Name=@Name, DVT=@DVT, FoodCategoryID=@FoodCategoryID, Price=@Price, Note=@Note where ID=@ID";
                        SqlCommand cmdUpdate = new SqlCommand(update, sqlConnection);
                        cmdUpdate.Parameters.AddWithValue("@Name", name);
                        cmdUpdate.Parameters.AddWithValue("@DVT", dvt ?? "");
                        cmdUpdate.Parameters.AddWithValue("@FoodCategoryID", categoryID);
                        cmdUpdate.Parameters.AddWithValue("@Price", price);
                        cmdUpdate.Parameters.AddWithValue("@Note", note);
                        cmdUpdate.Parameters.AddWithValue("@ID", id);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
                sqlConnection.Close();
            }
            MessageBox.Show("Lưu dữ liệu thành công!");
        }
    }
}
