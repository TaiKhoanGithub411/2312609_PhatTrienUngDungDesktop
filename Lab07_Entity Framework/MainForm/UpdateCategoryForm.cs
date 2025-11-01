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
    public partial class UpdateCategoryForm : Form
    {
        private RestaurantContext _dbContext;
        private int _categoryID;
        public UpdateCategoryForm(int? categoryID = null)
        {
            InitializeComponent();
            _dbContext = new RestaurantContext();
            _categoryID = categoryID ?? 0;
        }
        #region Hàm xử lý khác
        private Category GetCategoryById(int categoryId)
        {
            return categoryId > 0 ? _dbContext.Categories.Find(categoryId) : null;
        }
        private void ShowCategory()
        {
            var category = GetCategoryById(_categoryID);
            if (category == null) return;
            txtCategoryID.Text = category.ID.ToString();
            txtCategoryName.Text = category.Name;
            cbbCategoryType.SelectedIndex = (int)category.Type;
        }
        private Category GetUpdatedCategory()
        {
            var category = new Category()
            {
                Name = txtCategoryName.Text.Trim(),
                Type = (CategoryType)cbbCategoryType.SelectedIndex
            };
            if (_categoryID > 0)
            {
                category.ID = _categoryID;
            }
            return category;
        }
        private bool ValidateUserInput()
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Tên nhóm thức ăn không được để trống", "Thông báo");
                return false;
            }
            if (cbbCategoryType.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn loại nhóm thức ăn", "Thông báo");
                return false;
            }
            return true;
        }

        #endregion
        private void UpdateCategoryForm_Load(object sender, EventArgs e)
        {
            ShowCategory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                var newCategory = GetUpdatedCategory();
                var oldCategory = GetCategoryById(_categoryID);
                if (oldCategory == null)
                {
                    _dbContext.Categories.Add(newCategory);
                }
                else
                {
                    oldCategory.Name = newCategory.Name;
                    oldCategory.Type = newCategory.Type;
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
