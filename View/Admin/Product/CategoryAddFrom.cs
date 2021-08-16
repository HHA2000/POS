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
    public partial class CategoryAddFrom : Form
    {
        public CategoryAddFrom()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            new CategoryDAO().addCategory(new Category
            {
                Name = textCategoryName.Text.Trim()
            });
            ((PageProduct) Login.mainwindow.userControl).populateCategory();
            textCategoryName.Text = "";
        }
    }
}
