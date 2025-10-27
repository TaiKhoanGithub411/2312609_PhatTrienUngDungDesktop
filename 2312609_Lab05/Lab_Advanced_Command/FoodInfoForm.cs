using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_Advanced_Command
{
    public partial class FoodInfoForm : Form
    {
        private string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
        public FoodInfoForm()
        {
            InitializeComponent();
        }
        #region Các hàm xử lý khác
        private void ResetText()
        {
            txtFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbCatName.ResetText();
            nubPrice.ResetText();
        }
        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                txtFoodID.Text = rowView["ID"].ToString();
                txtName.Text = rowView["Name"].ToString();
                txtUnit.Text = rowView["Unit"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nubPrice.Text = rowView["Price"].ToString();
                cbbCatName.SelectedIndex = -1;
                for (int index = 0; index <= cbbCatName.Items.Count; index++)
                {
                    DataRowView cat = cbbCatName.Items[index] as DataRowView;
                    if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cbbCatName.SelectedIndex = index;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                this.Close();
            }
        }
        private void InitValues()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select ID, Name from Category";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "Category");
            cbbCatName.DataSource = ds.Tables["Category"];
            cbbCatName.DisplayMember = "Name";
            cbbCatName.ValueMember = "ID";
            conn.Close();
            conn.Dispose();
        }
        #endregion
        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            this.InitValues();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Execute InsertFood @id output, @name, @unit, @foodCategoryID, @price, @notes";
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@notes"].Value = txtNotes.Text;
                cmd.Parameters["@price"].Value = nubPrice.Value;
                cmd.Parameters["@foodCategoryID"].Value = cbbCatName.SelectedValue;

                conn.Open();
                int numRowEffected = cmd.ExecuteNonQuery();

                if (numRowEffected > 0)
                {
                    string foodID = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Thêm món ăn thành công. Food ID = " + foodID, "Thông báo", MessageBoxButtons.OK);
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Thêm món ăn thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi Sql");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Lỗi");
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXEC UpdateFood @id, @name, @unit, @foodCategoryID, @price, @notes";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@notes"].Value = txtNotes.Text;
                cmd.Parameters["@price"].Value = nubPrice.Value;
                cmd.Parameters["@foodCategoryID"].Value = cbbCatName.SelectedValue;

                conn.Open();
                int numRowEffected = cmd.ExecuteNonQuery();

                if (numRowEffected > 0)
                {
                    MessageBox.Show("Cập nhật món ăn thành công", "Thông báo", MessageBoxButtons.OK);
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Cập nhật món ăn thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi Sql");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Lỗi");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                InsertCategory categoryForm = new InsertCategory();
                DialogResult result = categoryForm.ShowDialog();

                // Nếu thêm thành công
                if (result == DialogResult.OK && categoryForm.IsSuccess)
                {
                    // Load lại ComboBox để hiển thị nhóm món ăn mới
                    this.InitValues();
                    // Tự động chọn nhóm món ăn vừa thêm
                    cbbCatName.SelectedValue = categoryForm.NewCategoryID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
