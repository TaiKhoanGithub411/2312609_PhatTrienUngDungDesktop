using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainForm
{
    public partial class BillLogForm : Form
    {
        private int tableID;
        private string tableName;
        private string connectionString;

        public BillLogForm(int tableID, string tableName, string connectionString)
        {
            InitializeComponent();
            this.tableID = tableID;
            this.tableName = tableName;
            this.connectionString = connectionString;
            this.Text = $"Nhật ký hóa đơn - {tableName}";

            // Đăng ký sự kiện
            this.Load += BillLogForm_Load;
        }

        private void BillLogForm_Load(object sender, EventArgs e)
        {
            LoadBillLog();
        }

        private void LoadBillLog()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Lấy thống kê tổng quan
                    string statsQuery = @"SELECT COUNT(*) as TongHD,
                                         ISNULL(SUM(Amount), 0) as TongTien,
                                         ISNULL(SUM(Tax), 0) as TongThue,
                                         ISNULL(SUM(Discount), 0) as TongGiamGia,
                                         ISNULL(SUM(Amount - Discount + ISNULL(Tax, 0)), 0) as TongThucThu
                                        FROM Bills 
                                        WHERE TableID = @TableID
                                        AND CheckoutDate IS NOT NULL";

                    SqlCommand statsCmd = new SqlCommand(statsQuery, connection);
                    statsCmd.Parameters.Add("@TableID", SqlDbType.Int).Value = tableID;
                    SqlDataReader statsReader = statsCmd.ExecuteReader();

                    if (statsReader.Read())
                    {
                        // Hiển thị thống kê lên các label (sử dụng tên đúng từ Designer)
                        lblTongHD.Text = statsReader["TongHD"].ToString();
                        lblTongTien.Text = Convert.ToDouble(statsReader["TongTien"]).ToString("N0") + " VNĐ";
                        lblTongThue.Text = Convert.ToDouble(statsReader["TongThue"]).ToString("N0") + " VNĐ";
                        lblTongGiam.Text = Convert.ToDouble(statsReader["TongGiamGia"]).ToString("N0") + " VNĐ";
                        lblTongThu.Text = Convert.ToDouble(statsReader["TongThucThu"]).ToString("N0") + " VNĐ";
                    }

                    statsReader.Close();

                    // Load danh sách hóa đơn vào ListView
                    LoadBillsList(connection);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải nhật ký: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadBillsList(SqlConnection connection)
        {
            try
            {
                string billQuery = @"SELECT ID, 
                                    CheckoutDate,
                                    Account,
                                    Amount,
                                    Discount,
                                    ISNULL(Tax, 0) as Tax,
                                    (Amount - Discount + ISNULL(Tax, 0)) as ThucThu
                                   FROM Bills 
                                   WHERE TableID = @TableID 
                                   AND CheckoutDate IS NOT NULL
                                   ORDER BY CheckoutDate DESC";

                SqlCommand billCmd = new SqlCommand(billQuery, connection);
                billCmd.Parameters.Add("@TableID", SqlDbType.Int).Value = tableID;

                SqlDataReader reader = billCmd.ExecuteReader();
                lvDSHD.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID"].ToString());

                    // Ngày lập
                    DateTime checkoutDate = Convert.ToDateTime(reader["CheckoutDate"]);
                    item.SubItems.Add(checkoutDate.ToString("dd/MM/yyyy"));

                    // Nhân viên
                    item.SubItems.Add(reader["Account"].ToString());

                    // Tổng tiền
                    double amount = Convert.ToDouble(reader["Amount"]);
                    item.SubItems.Add(amount.ToString("N0"));

                    // Giảm giá
                    double discount = Convert.ToDouble(reader["Discount"]);
                    item.SubItems.Add(discount.ToString("N0"));

                    // Thuế
                    double tax = Convert.ToDouble(reader["Tax"]);
                    item.SubItems.Add(tax.ToString("N0"));

                    // Thực thu
                    double thucThu = Convert.ToDouble(reader["ThucThu"]);
                    item.SubItems.Add(thucThu.ToString("N0"));

                    lvDSHD.Items.Add(item);
                }

                reader.Close();

                if (lvDSHD.Items.Count == 0)
                {
                    MessageBox.Show("Bàn này chưa có hóa đơn nào!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách hóa đơn: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
