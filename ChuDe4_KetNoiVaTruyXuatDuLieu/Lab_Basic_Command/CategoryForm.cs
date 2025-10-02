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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        #region Phần mã xử lý khác
        private void DisplayCategory(SqlDataReader reader)//Hiển thị ds danh mục món ăn lên giao diện
        {
            lvCategory.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                lvCategory.Items.Add(item);
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }
        #endregion
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT ID, Name, Type FROM Category";
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            this.DisplayCategory(sqlDataReader);
            sqlConnection.Close();
        }       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";  
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            int typeInt = txtType.Text == "Thức uống" ? 0 : 1;
            sqlCommand.CommandText = "Insert into Category(Name, [Type])" + "Values(N'" + txtName.Text + "', " + typeInt + ")";
            sqlConnection.Open();
            int numOfRowEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(numOfRowEffected==1)
            {
                MessageBox.Show("Thêm nhóm món ăn thành công");
                btnLoad.PerformClick();
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";
            }
        }
        private void lvCategory_Click(object sender, EventArgs e)//Nhấn xem chi tiết nhóm món ăn
        {
            ListViewItem item = lvCategory.SelectedItems[0];
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[1].Text == "0" ? "Thức uống" : "Đồ ăn";//Loại 0 là đồ uống

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            int typeInt = txtType.Text == "Thức uống" ? 0 : 1;//Chuyển chuỗi thành int để lưu loại
            sqlCommand.CommandText = "Update Category Set Name = N'" + txtName.Text + "', [Type] = N'" + typeInt + "' "+ "Where ID = " + txtID.Text;
            sqlConnection.Open();
            int numOfRowEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(numOfRowEffected==1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = txtType.Text;
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                MessageBox.Show("Cập nhật nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Delete from Category where ID = " + txtID.Text;
            sqlConnection.Open();
            int numOfRowEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(numOfRowEffected==1)
            {                
                ListViewItem item = lvCategory.SelectedItems[0];
                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = txtType.Text;
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnLoad.PerformClick();
                MessageBox.Show("Xóa nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi, vui lòng thử lại sau");
            }
        }
        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if(lvCategory.SelectedItems.Count>0)
            {
                btnDelete.PerformClick();
            }
        }
        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int categoryID))
            {
                MessageBox.Show("ID nhóm món ăn không hợp lệ.");
                return;
            }
            FoodForm foodform = new FoodForm();
            foodform.LoadFood(categoryID);
            foodform.ShowDialog(this);            
        }
    }
}
