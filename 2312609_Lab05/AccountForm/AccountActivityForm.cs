using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccountForm
{
    public partial class AccountActivityForm : Form
    {
        private string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
        private string accountName;
        private class BillItem
        {
            public int InvoiceID { get; set; }
            public string DisplayText { get; set; }
        }
        public AccountActivityForm(string accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
            this.Text = "Nhật ký hoạt động - " + accountName;
            LoadBillDates();
            LoadStatistics();
        }
        private void LoadBillDates()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetBillsByAccount";
                    cmd.Parameters.AddWithValue("@AccountName", accountName);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    lstBillDates.Items.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime checkoutDate = Convert.ToDateTime(row["CheckoutDate"]);
                        string displayText = string.Format("{0} - HĐ #{1} - {2:N0} VNĐ",
                            checkoutDate.ToString("dd/MM/yyyy"),
                            row["ID"],
                            Convert.ToInt32(row["Amount"]) * (1 - Convert.ToDouble(row["Discount"])));

                        lstBillDates.Items.Add(new BillItem
                        {
                            InvoiceID = Convert.ToInt32(row["ID"]),
                            DisplayText = displayText
                        });
                    }

                    lstBillDates.DisplayMember = "DisplayText";
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
        private void LoadBillDetails(int invoiceID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetBillDetailsWithFood";

                    cmd.Parameters.AddWithValue("@InvoiceID", invoiceID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvBillDetails.DataSource = dt;
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
        private void LoadStatistics()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetAccountBillStatistics";

                    cmd.Parameters.AddWithValue("@AccountName", accountName);

                    SqlParameter totalBills = new SqlParameter("@TotalBills", SqlDbType.Int);
                    totalBills.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(totalBills);

                    SqlParameter totalAmount = new SqlParameter("@TotalAmount", SqlDbType.BigInt);
                    totalAmount.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(totalAmount);

                    cmd.ExecuteNonQuery();

                    int billCount = Convert.ToInt32(totalBills.Value);
                    long amount = Convert.ToInt64(totalAmount.Value);

                    lblTotalBills.Text = string.Format("Tổng số hóa đơn: {0}", billCount);
                    lblTotalAmount.Text = string.Format("Tổng số tiền: {0:N0} VNĐ", amount);
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

        private void lstBillDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBillDates.SelectedItem != null)
            {
                BillItem selectedItem = (BillItem)lstBillDates.SelectedItem;
                LoadBillDetails(selectedItem.InvoiceID);
            }
        }
    }
}
