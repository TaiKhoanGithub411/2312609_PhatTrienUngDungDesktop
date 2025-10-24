using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainForm
{
    public partial class BillCatalogForm : Form
    {
        private int tableID;
        private string tableName;
        private string connectionString;

        public BillCatalogForm(int tableID, string tableName, string connectionString)
        {
            InitializeComponent();
            this.tableID = tableID;
            this.tableName = tableName;
            this.connectionString = connectionString;
            this.Text = $"Danh mục hóa đơn - {tableName}";
        }

        private void BillCatalogForm_Load(object sender, EventArgs e)
        {
            LoadBillDates();
        }

        // Load danh sách ngày lập hóa đơn
        private void LoadBillDates()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT DISTINCT CAST(CheckoutDate AS DATE) as BillDate 
                                   FROM Bills 
                                   WHERE TableID = @TableID 
                                   ORDER BY BillDate DESC";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@TableID", SqlDbType.Int).Value = tableID;

                    SqlDataReader reader = cmd.ExecuteReader();
                    lbDSNgay.Items.Clear();

                    while (reader.Read())
                    {
                        DateTime date = Convert.ToDateTime(reader["BillDate"]);
                        lbDSNgay.Items.Add(date.ToString("dd/MM/yyyy"));
                    }

                    if (lbDSNgay.Items.Count == 0)
                    {
                        MessageBox.Show("Bàn này chưa có hóa đơn nào!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Khi chọn ngày trong ListBox
        private void lbDSNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDSNgay.SelectedItem == null) return;

            string selectedDate = lbDSNgay.SelectedItem.ToString();
            LoadBillDetails(selectedDate);
        }

        // Load thông tin chi tiết hóa đơn
        private void LoadBillDetails(string date)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Lấy thông tin hóa đơn
                    string billQuery = @"SELECT ID, Name, CheckoutDate, Account, Amount, 
                                        Discount, (Amount * 0.1) as Tax, 
                                        (Amount - Discount + (Amount * 0.1)) as Total
                                       FROM Bills 
                                       WHERE TableID = @TableID 
                                       AND CAST(CheckoutDate AS DATE) = @Date";

                    SqlCommand billCmd = new SqlCommand(billQuery, connection);
                    billCmd.Parameters.Add("@TableID", SqlDbType.Int).Value = tableID;
                    billCmd.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.ParseExact(date, "dd/MM/yyyy", null);

                    SqlDataReader billReader = billCmd.ExecuteReader();

                    if (billReader.Read())
                    {
                        int billID = Convert.ToInt32(billReader["ID"]);

                        // Hiển thị thông tin lên các Label (sử dụng tên đúng từ Designer)
                        lblSoHD.Text = billReader["ID"].ToString();
                        lblNgayLap.Text = Convert.ToDateTime(billReader["CheckoutDate"]).ToString("dd/MM/yyyy HH:mm");
                        lblNhanVien.Text = billReader["Account"].ToString();
                        lblTongTien.Text = Convert.ToDouble(billReader["Amount"]).ToString("N0") + " VNĐ";
                        lblGiamGia.Text = Convert.ToDouble(billReader["Discount"]).ToString("N0") + " VNĐ";
                        lblThue.Text = Convert.ToDouble(billReader["Tax"]).ToString("N0") + " VNĐ";
                        lblThucThu.Text = Convert.ToDouble(billReader["Total"]).ToString("N0") + " VNĐ";

                        billReader.Close();
                        // Load chi tiết sản phẩm
                        LoadBillProducts(billID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải chi tiết: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Load danh sách sản phẩm của hóa đơn
        private void LoadBillProducts(int billID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT bd.ID, f.Name, bd.Quantity, f.Price, 
                                    (bd.Quantity * f.Price) as Total
                                   FROM BillDetails bd
                                   INNER JOIN Food f ON bd.FoodID = f.ID
                                   WHERE bd.InvoiceID = @BillID";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@BillID", SqlDbType.Int).Value = billID;

                    SqlDataReader reader = cmd.ExecuteReader();
                    lvSanPham.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ID"].ToString());
                        item.SubItems.Add(reader["Name"].ToString());
                        item.SubItems.Add(reader["Quantity"].ToString());
                        item.SubItems.Add(Convert.ToInt32(reader["Price"]).ToString("N0"));
                        item.SubItems.Add(Convert.ToInt32(reader["Total"]).ToString("N0"));
                        lvSanPham.Items.Add(item);
                    }

                    if (lvSanPham.Items.Count == 0)
                    {
                        MessageBox.Show("Hóa đơn này chưa có món ăn nào!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải món ăn: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
