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
    public partial class ProductUpdateForm : Form
    {
        Product product;

        public ProductUpdateForm(Product product)
        {
            InitializeComponent();
            this.product = product;
            textBoxName.Text = product.Name;
            numericQuantity.Value = product.Quantity;
            numericPrice.Value = product.Price;
            comboBoxCategory.SelectedItem = product.Category_ID;
            populateComboBox();
        }

        private void populateComboBox()
        {
            List<Category> categorylist = new CategoryDAO().getCategories();
            comboBoxCategory.DataSource = categorylist;
            comboBoxCategory.ValueMember = "ID";
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.SelectedValue = product.Category_ID;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            product.Name = textBoxName.Text.Trim();
            product.Quantity = (int)numericQuantity.Value;
            product.Price = (int)numericPrice.Value;
            product.Category_ID = ((Category)comboBoxCategory.SelectedItem).ID;
            new ProductDAO().updateProduct(product);
            ((PageProduct)Login.mainwindow.userControl).populateProduct();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
