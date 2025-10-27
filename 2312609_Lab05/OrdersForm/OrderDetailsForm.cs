using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrdersForm
{
    public partial class OrderDetailsForm : Form
    {
        private string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
        private int invoiceID;
        public OrderDetailsForm(int invoiceID)
        {
            InitializeComponent();
            this.invoiceID = invoiceID;
            LoadBillDetails();
        }
        private void LoadBillDetails()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("GetBillDetails", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm parameter
                        cmd.Parameters.AddWithValue("@InvoiceID", invoiceID);

                        // Đổ dữ liệu vào DataGridView
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvHDDetails.DataSource = dt;
                       

                        // Tính tổng tiền
                        long totalAmount = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            totalAmount += Convert.ToInt64(row["TotalPrice"]);
                        }

                        lblTongTien.Text = "Tổng tiền: " + totalAmount.ToString("N0") + " VNĐ";
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
    }
}
