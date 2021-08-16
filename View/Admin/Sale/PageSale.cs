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
    public partial class PageSale : UserControl
    {
        SaleDAO saledao = new SaleDAO();
        public PageSale()
        {
            InitializeComponent();
            populateTodaySale();
        }

        private void populateTodaySale()
        {
            if(saledao.getTodaySaleCount() == 0)
            {
                lblTodaySale.Text = 0.ToString();
                panelDisplaySale.BackColor = Color.Red;
            }
            else
            {
                lblTodaySale.Text = saledao.getTodaySale().ToString();
                panelDisplaySale.BackColor = Color.Green;
            }
        }

        private void btnSaleDetail_Click(object sender, EventArgs e)
        {
            new SaleDetail(DateTime.Today.ToString("yyyy-MM-dd")).ShowDialog();
        }
    }
}
