using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrdersForm
{
    public partial class OrdersForm : Form
    {
        private string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
        public OrdersForm()
        {
            InitializeComponent();
        }
        #region Hàm xử lý khác
        private void LoadBillsData()
        {
            try
            {
                using(SqlConnection conn=new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetBillsByDateRange";
                    cmd.Parameters.AddWithValue("@FromDate", dtpDateFrom.Value.Date);
                    cmd.Parameters.AddWithValue("@ToDate", dtpDateTo.Value.Date);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvDSHĐ.DataSource = dt;
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
        private void CalculateRevenueSummary()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("GetRevenueSummary", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm input parameters
                        cmd.Parameters.AddWithValue("@FromDate", dtpDateFrom.Value.Date);
                        cmd.Parameters.AddWithValue("@ToDate", dtpDateTo.Value.Date);

                        // Thêm output parameters
                        SqlParameter totalAmountParam = new SqlParameter("@TotalAmount", SqlDbType.BigInt);
                        totalAmountParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(totalAmountParam);

                        SqlParameter totalDiscountParam = new SqlParameter("@TotalDiscount", SqlDbType.BigInt);
                        totalDiscountParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(totalDiscountParam);

                        SqlParameter totalRevenueParam = new SqlParameter("@TotalRevenue", SqlDbType.BigInt);
                        totalRevenueParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(totalRevenueParam);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        // Lấy giá trị output
                        long totalAmount = Convert.ToInt64(totalAmountParam.Value);
                        long totalDiscount = Convert.ToInt64(totalDiscountParam.Value);
                        long totalRevenue = Convert.ToInt64(totalRevenueParam.Value);

                        // Hiển thị kết quả
                        txtChuaGiam.Text = totalAmount.ToString("N0") + " VNĐ";
                        txtGiamGia.Text = totalDiscount.ToString("N0") + " VNĐ";
                        txtTongThu.Text = totalRevenue.ToString("N0") + " VNĐ";
                    }
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
        #endregion

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadBillsData();
            CalculateRevenueSummary();
        }

        private void dgvDSHĐ_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy ID của hóa đơn được chọn
                int invoiceID = Convert.ToInt32(dgvDSHĐ.Rows[e.RowIndex].Cells["ID"].Value);

                // Mở form chi tiết
                OrderDetailsForm detailsForm = new OrderDetailsForm(invoiceID);
                detailsForm.ShowDialog();
            }
        }
    }
}
