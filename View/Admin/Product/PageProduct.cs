using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class PageProduct : UserControl
    {
        ProductDAO productDAO = new ProductDAO();
        CategoryDAO categoryDAO = new CategoryDAO();
        public PageProduct()
        {
            InitializeComponent();
            populateProduct();
            populateCategory();
        }

        public void populateProduct()
        {
            flowLayoutPanelProduct.Controls.Clear();
            List<Product> productlist = productDAO.getProduct();
            ProductItem productitem;
            foreach(Product product in productlist)
            {
                productitem = new ProductItem(product);
                flowLayoutPanelProduct.Controls.Add(productitem);
            }
        }

        public void populateProduct(int category_id)
        {
            flowLayoutPanelProduct.Controls.Clear();
            List<Product> productlist = productDAO.getProduct(category_id);
            ProductItem productitem;
            foreach (Product product in productlist)
            {
                productitem = new ProductItem(product);
                flowLayoutPanelProduct.Controls.Add(productitem);
            }
        }

        public void populateCategory()
        {
            flowLayoutPanelCategory.Controls.Clear();
            List<Category> categorylist = categoryDAO.getCategories();
            CategoryItem categoryitem;
            foreach(Category category in categorylist)
            {
                categoryitem = new CategoryItem("admin")
                {
                    ID = category.ID,
                    CategoryName = category.Name
                };
                flowLayoutPanelCategory.Controls.Add(categoryitem);
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            new ProductAddForm().ShowDialog();
        }

        private void btnPanelAddCategory_Click(object sender, EventArgs e)
        {
            new CategoryAddFrom().ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateProduct();
        }
    }
}
