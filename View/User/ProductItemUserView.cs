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
    public partial class ProductItemUserView : UserControl
    {
        private Product product;
        public ProductItemUserView(Product product)
        {
            InitializeComponent();
            this.product = product;
            lblName.Text = product.Name;
            lblPrice.Text = product.Price.ToString();
            refreshbtnBuy();
        }

        private void ProductItemUserView_Load(object sender, EventArgs e)
        {
            string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\img\" + product.Image;
            if (File.Exists(filePath))
            {
                pictureBox.Image = Image.FromFile(filePath);
            }
        }

        private void refreshbtnBuy()
        {
            if(product.Quantity < 5)
            {
                btnBuy.Enabled = false;
                btnBuy.Text = "Out of Stock";
                btnBuy.Font = new Font("Microsoft Sans Serif", 7);
                btnBuy.BackColor = Color.Red;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            ((UserView)(Login.userwindow)).flowLayoutPanelCart.Controls.Add(new CartItem(product,btnBuy));
            btnBuy.Enabled = false;
        }
    }
}
