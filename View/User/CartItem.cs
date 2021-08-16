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
    public partial class CartItem : UserControl
    {
        private Product product1;
        private int _quantity;
        private Button button;
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public CartItem(Product product, Button button)
        {
            InitializeComponent();
            Product = product;
            this.button = button;
            lblName.Text = product.Name;
            lblPrice.Text = product.Price.ToString();
            numericQuantity.Maximum = product.Quantity;
            numericQuantity.Minimum = 1;
        }

        public Product Product
        {
            get { return product1; }
            set { product1 = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            Quantity = (int) (numericQuantity.Value);
            Price = (int) numericQuantity.Value * Product.Price;
            lblPrice.Text = (numericQuantity.Value * Product.Price).ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ((UserView)(Login.userwindow)).flowLayoutPanelCart.Controls.Remove(this);
            this.button.Enabled = true;
        }
    }
}
