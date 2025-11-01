using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace RestaurantManagementProject
{
    public partial class frmFood : Form
    {
        List<Category> listcat = new List<Category>();
        List<Food> listfood = new List<Food>();
        Food foodcurrent = new Food();
        CategoryBL categoryDA = new CategoryBL();
        FoodBL foodBL = new FoodBL();
        public frmFood()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        #region Hàm xử lý khác
        private void LoadCategory()
        {
            listcat = categoryDA.GetAll();
            cbbCategory.DataSource = listcat;
            cbbCategory.ValueMember = "ID";
            cbbCategory.DisplayMember = "Name";
        }
        public void LoadFoodDataToListView()
        {
            listfood = foodBL.GetAll();
            int count = 1;
            lsvFood.Items.Clear();
            foreach(var food in listfood)
            {
                ListViewItem item = lsvFood.Items.Add(count.ToString());
                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);                
                item.SubItems.Add(food.Price.ToString());
                string foodName = listcat.Find(x => x.ID == food.FoodCategoryID).Name;
                item.SubItems.Add(foodName);
                item.SubItems.Add(food.Notes);
                count++;
            }
        }
        public int InsertFood()
        {
            Food food = new Food();
            food.ID = 0;
            if(String.IsNullOrWhiteSpace(txtName.Text) || String.IsNullOrWhiteSpace(txtUnit.Text) || String.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập đủ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;
                int price = 0;
                try
                {
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    price = 0;
                }
                food.Price = price;
                food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
                return foodBL.Insert(food);
            }
            return -1;
        }
        public int UpdateFood()
        {
            Food food = foodcurrent;
            if (String.IsNullOrWhiteSpace(txtName.Text) || String.IsNullOrWhiteSpace(txtUnit.Text) || String.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập đủ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;
                int price = 0;
                try
                {
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    price = 0;
                }
                food.Price = price;
                food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
                return foodBL.Update(food);
            }
            return -1;
        }
        #endregion
        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtUnit.Text = "";
            txtNotes.Text = "";
            txtPrice.Text = "";
            if (cbbCategory.Items.Count > 0)
                cbbCategory.SelectedIndex = 0;
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadFoodDataToListView();
        }

        private void lsvFood_Click(object sender, EventArgs e)
        {
            for(int i=0; i<lsvFood.Items.Count;i++)
            {
                if(lsvFood.Items[i].Selected)
                {
                    foodcurrent = listfood[i];
                    txtName.Text = foodcurrent.Name;
                    txtUnit.Text = foodcurrent.Unit;
                    txtPrice.Text = foodcurrent.Price.ToString();
                    txtNotes.Text = foodcurrent.Notes;
                    cbbCategory.SelectedIndex = listcat.FindIndex(x => x.ID == foodcurrent.FoodCategoryID);
                }
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            int result = InsertFood();
            if (result > 0)
            {
                MessageBox.Show("Thêm món ăn thành công", "Thông báo");
                LoadFoodDataToListView();
            }
            else
                MessageBox.Show("Thêm dữ liệu không thành công, vui lòng kiểm tra lại dữ liệu nhập");
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc chắn xóa món ăn này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                if (foodBL.Delete(foodcurrent)>0)
                {
                    MessageBox.Show("Xóa món ăn thành công", "Thông báo");
                    LoadFoodDataToListView();
                }
                else
                    MessageBox.Show("Xóa món ăn thất bại", "Thông báo");
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            int result = UpdateFood();
            if (result > 0)
            {
                MessageBox.Show("Cập nhật món ăn thành công", "Thông báo");
                LoadFoodDataToListView();
            }
            else
                MessageBox.Show("Cập nhật dữ liệu không thành công, vui lòng kiểm tra lại dữ liệu nhập");
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            var frm = new frmCategory();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadCategory();
            }
        }
    }
}
