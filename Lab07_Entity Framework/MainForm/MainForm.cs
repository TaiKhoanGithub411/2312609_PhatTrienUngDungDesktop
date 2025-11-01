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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region Hàm xử lý khác
        private List<Category> GetCategories()
        {
            var dbContext = new RestaurantContext();
            return dbContext.Categories.OrderBy(x => x.Name).ToList();
        }
        private void ShowAllCategory()
        {
            tvwCategory.Nodes.Clear();
            var cateMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Food] = "Đồ ăn",
                [CategoryType.Drink] = "Thức uống"
            };
            var rootNodes = tvwCategory.Nodes.Add("Tất cả");
            var categories = GetCategories();
            foreach(var cateType in cateMap)
            {
                var childNodes = rootNodes.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNodes.Tag = cateType.Key;
                foreach(var category in categories)
                {
                    if (category.Type != cateType.Key) continue;

                    var grantChildNodes = childNodes.Nodes.Add(category.ID.ToString(), category.Name);
                    grantChildNodes.Tag = category;
                }
            }
            tvwCategory.ExpandAll();
            tvwCategory.SelectedNode = rootNodes;
        }
        private List<FoodModel> GetFoodByCategory(int? categoryId)
        {
            var dbContext = new RestaurantContext();
            var foods = dbContext.Foods.AsQueryable();
            if (categoryId != null && categoryId > 0)
            {
                foods = foods.Where(x => x.FoodCategoryID == categoryId);
            }
            return foods
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    ID = x.ID,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }
        private List<FoodModel> GetFoodByCategoryType(CategoryType cateType)
        {
            var dbContext = new RestaurantContext();
            return dbContext.Foods
                .Where(x => x.Category.Type == cateType)
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    ID = x.ID,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }
        private void ShowFoodsForNode(TreeNode node)
        {
            lvwFood.Items.Clear();
            if (node == null) return;
            List<FoodModel> foods = null;
            if (node.Level == 1)
            {
                var categoryType = (CategoryType)node.Tag;
                foods = GetFoodByCategoryType(categoryType);
            }
            else
            {
                var category = node.Tag as Category;
                foods = GetFoodByCategory(category?.ID);
            }
            ShowFoodsOnListView(foods);
        }
        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            foreach (var foodItem in foods)
            {
                var item = lvwFood.Items.Add(foodItem.ID.ToString());
                item.SubItems.Add(foodItem.Name);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
            }
        }

        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowAllCategory();
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowAllCategory();
        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNode(e.Node);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateCategoryForm();
            if(dialog.ShowDialog(this)==DialogResult.OK)
            {
                ShowAllCategory();
            }
        }

        private void tvwCategory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Level < 2 || e.Node.Tag == null) return;
            var category = e.Node.Tag as Category;
            var dialog = new UpdateCategoryForm(category?.ID);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowAllCategory();
            }
        }

        private void btnReloadFood_Click(object sender, EventArgs e)
        {
            ShowFoodsForNode(tvwCategory.SelectedNode);
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0) return;
            var dbContext = new RestaurantContext();
            var selectFoodID = int.Parse(lvwFood.SelectedItems[0].Text);
            var selectFood = dbContext.Foods.Find(selectFoodID);
            if(selectFood!=null)
            {
                dbContext.Foods.Remove(selectFood);
                dbContext.SaveChanges();
                lvwFood.Items.Remove(lvwFood.SelectedItems[0]);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateFoodForm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowFoodsForNode(tvwCategory.SelectedNode);
            }
        }

        private void lvwFood_DoubleClick(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0) return;
            var foodId = int.Parse(lvwFood.SelectedItems[0].Text);
            var dialog = new UpdateFoodForm(foodId);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowFoodsForNode(tvwCategory.SelectedNode);
            }
        }
    }
}
