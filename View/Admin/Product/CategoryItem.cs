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
    public partial class CategoryItem : UserControl
    {
        private string type;
        public CategoryItem(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        #region Property
        private string _name;
        private int _id;

        [Category("custom prop")]
        public string CategoryName
        {
            get { return _name; }
            set { _name = value; btnName.Text = value; }
        }

        
        [Category("custom prop")]
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        #endregion

        private void btnName_Click(object sender, EventArgs e)
        {
            if(type == "admin")
            {
                ((PageProduct)Login.mainwindow.userControl).populateProduct(ID);
            }
            else
            {
                Login.userwindow.populateProduct(ID);
            }
        }
    }
}
