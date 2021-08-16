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
    public partial class Invoice : Form
    {
        private int _invoice_id;
        ProductTransactionDAO producttransactiondao = new ProductTransactionDAO();
        InvoiceDAO invoicedao = new InvoiceDAO();
        public Invoice(int invoice_id)
        {
            InitializeComponent();
            this._invoice_id = invoice_id;
            populateTransaction();
            populateDateandTotalprice();
        }

        private void populateDateandTotalprice()
        {
            invoice invoice = invoicedao.getInvoicebyID(_invoice_id);
            lblDate.Text = invoice.Datetime;
            lblTotal.Text = invoice.Total_Price.ToString();
        }

        private void populateTransaction()
        {
            dataGridViewTransaction.AutoGenerateColumns = false;
            dataGridViewTransaction.DataSource = producttransactiondao.GetProductTransactionsByInvoiceID(_invoice_id);
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            ((UserView)(Login.userwindow)).flowLayoutPanelCart.Controls.Clear();
            ((UserView)(Login.userwindow)).populateProduct();
        }

        private void dataGridViewTransaction_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewTransaction.ClearSelection();
        }
    }
}
