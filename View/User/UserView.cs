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
    public partial class UserView : Form
    {
        ProductDAO productDAO = new ProductDAO();
        CategoryDAO categoryDAO = new CategoryDAO();
        InvoiceDAO invoicedao = new InvoiceDAO();
        ProductTransactionDAO productTransactionDAO = new ProductTransactionDAO();

        public UserView()
        {
            InitializeComponent();
            populateCategory();
            populateProduct();
        }

        public void populateProduct()
        {
            flowLayoutPanelProduct.Controls.Clear();
            List<Product> productlist = productDAO.getProduct();
            ProductItemUserView productitem;
            foreach (Product product in productlist)
            {
                productitem = new ProductItemUserView(product);
                flowLayoutPanelProduct.Controls.Add(productitem);
            }
        }

        public void populateProduct(int category_id)
        {
            flowLayoutPanelProduct.Controls.Clear();
            List<Product> productlist = productDAO.getProduct(category_id);
            ProductItemUserView productitem;
            foreach (Product product in productlist)
            {
                productitem = new ProductItemUserView(product);
                flowLayoutPanelProduct.Controls.Add(productitem);
            }
        }

        public void populateCategory()
        {
            flowLayoutPanelCategory.Controls.Clear();
            List<Category> categorylist = categoryDAO.getCategories();
            CategoryItem categoryitem;
            foreach (Category category in categorylist)
            {
                categoryitem = new CategoryItem("user")
                {
                    ID = category.ID,
                    CategoryName = category.Name
                };
                flowLayoutPanelCategory.Controls.Add(categoryitem);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if(flowLayoutPanelCart.Controls.Count == 0)
            {
                MessageBox.Show("Cart is empty");
            }
            else
            {
                ProductTransaction productTransaction = new ProductTransaction();
                int invoice_id = invoicedao.createInvoice();
                int total_price = 0;
                foreach (CartItem cartitem in flowLayoutPanelCart.Controls)
                {
                    productTransaction.ProductID = cartitem.Product.ID;
                    productTransaction.InvoiceID = invoice_id;
                    productTransaction.Quantity = cartitem.Quantity;
                    productTransaction.Price = cartitem.Price;
                    int transactionid = productTransactionDAO.addTransaction(productTransaction);
                    productDAO.updateProductQuantity(cartitem.Product.ID, transactionid);
                    total_price += cartitem.Price;
                }
                invoicedao.addInvoice(invoice_id, total_price);
                new Invoice(invoice_id).ShowDialog();
            }
        }

        private void btnRefreshProduct_Click(object sender, EventArgs e)
        {
            populateProduct();
        }
    }
}
