using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly ICategoryService _categoryService;

        public CategoryForm(ICategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;

            LoadCategoriesData();
        }

        public void LoadCategoriesData()
        {
            categoriesDataGridView.DataSource = _categoryService.GetAllCategories();
        }
    }
}
