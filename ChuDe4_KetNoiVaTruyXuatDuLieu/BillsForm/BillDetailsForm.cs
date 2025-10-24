using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BillsForm
{
    public partial class BillDetailsForm : Form
    {
        private int _billID;

        public BillDetailsForm()
        {
            InitializeComponent();
        }

        public void SetBillID(int billID)
        {
            _billID = billID;
            // Tải chi tiết hóa đơn sau khi nhận được ID
            LoadBillDetails();
        }

        private void LoadBillDetails()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);

            // Câu lệnh SQL để lấy thông tin chi tiết hóa đơn và thông tin chung
            SqlCommand command = connection.CreateCommand();
            command.CommandText = @"SELECT f.Name AS FoodName, bd.Quantity, f.Price, (bd.Quantity * f.Price) AS TotalPrice
                                    FROM BillDetails bd
                                    JOIN Food f ON bd.FoodID = f.ID
                                    WHERE bd.InvoiceID = @billID";

            // Thêm tham số BillID
            command.Parameters.Add("@billID", SqlDbType.Int).Value = _billID;

            // Câu lệnh để lấy thông tin chung của hóa đơn
            SqlCommand billInfoCommand = new SqlCommand("SELECT ID, CheckoutDate, Account FROM Bills WHERE ID = @billID", connection);
            billInfoCommand.Parameters.Add("@billID", SqlDbType.Int).Value = _billID;

            try
            {
                connection.Open();

                // Lấy và hiển thị thông tin chung của hóa đơn
                SqlDataReader billInfoReader = billInfoCommand.ExecuteReader();
                if (billInfoReader.Read())
                {
                    lblBillID.Text = billInfoReader["ID"].ToString();
                    lblDate.Text = ((DateTime)billInfoReader["CheckoutDate"]).ToString("dd/MM/yyyy HH:mm");
                    lblAccount.Text = billInfoReader["Account"].ToString();
                }
                billInfoReader.Close();

                // Lấy và hiển thị danh sách các món ăn
                SqlDataReader detailsReader = command.ExecuteReader();
                lvBillDetails.Items.Clear();

                while (detailsReader.Read())
                {
                    ListViewItem item = new ListViewItem(detailsReader["FoodName"].ToString());
                    item.SubItems.Add(detailsReader["Price"].ToString());
                    item.SubItems.Add(detailsReader["Quantity"].ToString());
                    item.SubItems.Add(detailsReader["TotalPrice"].ToString());

                    lvBillDetails.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
