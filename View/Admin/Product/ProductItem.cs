using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class ProductItem : UserControl
    {
        private Product product;
        public ProductItem(Product product)
        {
            InitializeComponent();
            this.product = product;
            lblProductName.Text = product.Name;
            lblProductPrice.Text = product.Price.ToString();
            lblProductQuantity.Text = product.Quantity.ToString();
        }

        private void ProductItem_Load(object sender, EventArgs e)
        {
            string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\img\" + product.Image;
            if (File.Exists(filePath))
            {
                pictureBox.Image = Image.FromFile(filePath);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\img\" + product.Image;
            new ProductDAO().deleteProduct(product.ID);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            
            ((PageProduct)(Login.mainwindow.userControl)).populateProduct();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new ProductUpdateForm(product).ShowDialog();
        }
    }
}