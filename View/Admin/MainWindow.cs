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
    public partial class MainWindow : Form
    {
        public UserControl userControl;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            userControl = Utlitity.showPage(PanelMain, new PageSale());
        }

        public void btnProduct_Click(object sender, EventArgs e)
        {
            userControl = Utlitity.showPage(PanelMain, new PageProduct());
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            userControl = Utlitity.showPage(PanelMain, new PageSale());
        }

        private void btnUserView_Click(object sender, EventArgs e)
        {
            Login.userwindow.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            userControl = Utlitity.showPage(PanelMain, new PageEmployee());
        }
    }
}
