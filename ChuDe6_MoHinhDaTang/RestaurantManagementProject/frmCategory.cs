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
    public partial class frmCategory : Form
    {
        List<Category> listcat = new List<Category>();
        CategoryBL categoryBL = new CategoryBL();
        Category selectedCategory = null;
        public frmCategory()
        {
            InitializeComponent();
        }
        #region Hàm xử lý khác
        private void LoadCategoryToList()
        {
            lvwCategory.Items.Clear();
            listcat = categoryBL.GetAll();
            foreach(var cat in listcat)
            {
                ListViewItem item = new ListViewItem(cat.ID.ToString());
                item.SubItems.Add(cat.Name);
                string typeText = cat.Type == 1 ? "Thức ăn" : "Đồ uống";
                item.SubItems.Add(typeText);
                item.Tag = cat;
                lvwCategory.Items.Add(item);
            }
        }
        private void ClearInputs()
        {
            txtNameCate.Clear();
            cbbCategoryType.SelectedIndex = -1;
            selectedCategory = null;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        public int InsertCategory()
        {
            Category category = new Category();
            category.ID = 0;

            if (String.IsNullOrWhiteSpace(txtNameCate.Text) || cbbCategoryType.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập đủ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                category.Name = txtNameCate.Text.Trim();
                category.Type = cbbCategoryType.SelectedIndex; // 0 = Đồ uống, 1 = Thức ăn
                return categoryBL.Insert(category);
            }
            return -1;
        }
        public int UpdateCategory()
        {
            if (selectedCategory == null)
            {
                MessageBox.Show("Chưa chọn loại thực phẩm cần cập nhật", "Thông báo", MessageBoxButtons.OK);
                return -1;
            }

            if (String.IsNullOrWhiteSpace(txtNameCate.Text) || cbbCategoryType.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập đủ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                selectedCategory.Name = txtNameCate.Text.Trim();
                selectedCategory.Type = cbbCategoryType.SelectedIndex;
                return categoryBL.Update(selectedCategory);
            }
            return -1;
        }
        public int DeleteCategory()
        {
            if (selectedCategory == null)
            {
                MessageBox.Show("Chưa chọn loại thực phẩm cần xóa", "Thông báo", MessageBoxButtons.OK);
                return -1;
            }

            DialogResult confirmResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa loại thực phẩm '{selectedCategory.Name}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                return categoryBL.Delete(selectedCategory);
            }
            return -1;
        }
        #endregion
        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadCategoryToList();
            ClearInputs();
        }

        private void lvwCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCategory.SelectedItems.Count > 0)
            {
                selectedCategory = (Category)lvwCategory.SelectedItems[0].Tag;
                txtNameCate.Text = selectedCategory.Name;
                cbbCategoryType.SelectedIndex = selectedCategory.Type;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = InsertCategory();
            if (result > 0)
            {
                MessageBox.Show("Thêm loại thực phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategoryToList();
                ClearInputs();
                this.DialogResult = DialogResult.OK;
            }
            else if (result == 0)
            {
                MessageBox.Show("Thêm loại thực phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int result = UpdateCategory();
            if (result > 0)
            {
                MessageBox.Show("Cập nhật loại thực phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategoryToList();
                ClearInputs();
                this.DialogResult = DialogResult.OK;
            }
            else if (result == 0)
            {
                MessageBox.Show("Cập nhật loại thực phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int result = DeleteCategory();
            if (result > 0)
            {
                MessageBox.Show("Xóa loại thực phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategoryToList();
                ClearInputs();
                this.DialogResult = DialogResult.OK;
            }
            else if (result == 0)
            {
                MessageBox.Show("Xóa loại thực phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
