using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForm.Models;

namespace MainForm
{
    public partial class UpdateFoodForm : Form
    {
        private RestaurantContext _dbContext;
        private int _foodID;
        public UpdateFoodForm(int? foodid =null)
        {
            InitializeComponent();
            _dbContext = new RestaurantContext();
            _foodID = foodid ?? 0;
        }
        #region Hàm xử lý khác
        private Food GetFoodById(int foodId)
        {
            return foodId > 0 ? _dbContext.Foods.Find(foodId) : null;
        }
        private void LoadCategoriesToCombobox()
        {
            var categories = _dbContext.Categories
                .OrderBy(x => x.Name).ToList();
            cbbFoodCategory.DisplayMember = "Name";
            cbbFoodCategory.ValueMember = "Id";
            cbbFoodCategory.DataSource = categories;
        }
        private void ShowFoodInformation()
        {
            var food = GetFoodById(_foodID);
            if (food == null) return;
            txtFoodID.Text = food.ID.ToString();
            txtFoodName.Text = food.Name;
            cbbFoodCategory.SelectedValue = food.FoodCategoryID;
            txtFoodUnit.Text = food.Unit;
            nudFoodPrice.Value = food.Price;
            txtFoodNotes.Text = food.Notes;
        }
        private Food GetUpdatedFood()
        {
            var food = new Food()
            {
                Name = txtFoodName.Text.Trim(),
                FoodCategoryID = (int)cbbFoodCategory.SelectedValue,
                Unit = txtFoodUnit.Text,
                Price = (int)nudFoodPrice.Value,
                Notes = txtFoodNotes.Text
            };
            if (_foodID > 0)
            {
                food.ID = _foodID;
            }
            return food;
        }
        private bool ValidateUserInput()
        {
            if (string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Tên món ăn, đồ uống không được để trống", "Thông báo");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFoodUnit.Text))
            {
                MessageBox.Show("Đơn vị tính không được để trống", "Thông báo");
                return false;
            }
            if (nudFoodPrice.Value.Equals(0))
            {
                MessageBox.Show("Giá của thức ăn phải lớn hơn 0", "Thông báo");
                return false;
            }
            if (cbbFoodCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn nhóm thức ăn", "Thông báo");
                return false;
            }
            return true;
        }
        #endregion

        private void UpdateFoodForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToCombobox();
            ShowFoodInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                var newFood = GetUpdatedFood();
                var oldFood = GetFoodById(_foodID);
                if (oldFood == null)
                {
                    _dbContext.Foods.Add(newFood);
                }
                else
                {
                    oldFood.Name = newFood.Name;
                    oldFood.FoodCategoryID = newFood.FoodCategoryID;
                    oldFood.Unit = newFood.Unit;
                    oldFood.Price = newFood.Price;
                    oldFood.Notes = newFood.Notes;
                }
                _dbContext.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
