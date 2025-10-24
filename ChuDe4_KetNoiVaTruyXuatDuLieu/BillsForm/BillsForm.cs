using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BillsForm
{
    public partial class BillsForm : Form
    {
        public BillsForm()
        {
            InitializeComponent();
        }
        private void LoadBills(DateTime datefrom, DateTime dateto)
        {
            string connectionString = "Server=DELL\\SQLEXPRESS;Database=RestaurantManagement;Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Select ID, Name, TableID, Amount, Discount, (Amount-Discount) as ThucThu, CheckoutDate, Account From Bills Where CheckoutDate between @datefrom and @dateto";
            sqlCommand.Parameters.Add("@datefrom", SqlDbType.DateTime).Value = datefrom;//Định dạng kiểu để truyền đúng kiểu vào database
            sqlCommand.Parameters.Add("@dateto", SqlDbType.DateTime).Value = dateto;

            double totalAmount = 0;
            double totalDiscount = 0;
            double totalThucThu = 0;
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                lvBills.Items.Clear();
                //Đọc dữ liệu
                while (sqlDataReader.Read())
                {
                    ListViewItem item = new ListViewItem(sqlDataReader["ID"].ToString());
                    item.SubItems.Add(sqlDataReader["Name"].ToString());
                    item.SubItems.Add(sqlDataReader["TableID"].ToString());

                    double amount = Convert.ToDouble(sqlDataReader["Amount"]);
                    double discount = Convert.ToDouble(sqlDataReader["Discount"]);
                    double thucthu = Convert.ToDouble(sqlDataReader["ThucThu"]);

                    // Thêm vào ListView với định dạng số
                    item.SubItems.Add(amount.ToString("N0"));
                    item.SubItems.Add(discount.ToString("N0"));
                    item.SubItems.Add(thucthu.ToString("N0"));

                    DateTime checkoutDate = (DateTime)sqlDataReader["CheckoutDate"];
                    item.SubItems.Add(checkoutDate.ToString("dd/MM/yyyy"));

                    item.SubItems.Add(sqlDataReader["Account"].ToString());
                    lvBills.Items.Add(item);

                    // Cộng dồn để tính tổng
                    totalAmount += amount;
                    totalDiscount += discount;
                    totalThucThu += thucthu;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
            }
            finally
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DateTime datefrom = dptFrom.Value.Date;
            DateTime dateto = dtpTo.Value.Date.AddDays(1).AddTicks(-1);// Lấy đến cuối ngày
            LoadBills(datefrom, dateto);
        }

        private void lvBills_DoubleClick(object sender, EventArgs e)
        {
            if (lvBills.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvBills.SelectedItems[0];
                int billID = int.Parse(selectedItem.SubItems[0].Text);

                BillDetailsForm billDetailsForm = new BillDetailsForm();
                billDetailsForm.SetBillID(billID);
                billDetailsForm.ShowDialog();
            }
        }
    }
}
