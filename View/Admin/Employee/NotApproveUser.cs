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
    public partial class NotApproveUser : UserControl
    {
        private User user;
        private UserDAO userdao = new UserDAO();
        public NotApproveUser(User user)
        {
            InitializeComponent();
            this.user = user;
            lblName.Text = user.Username;
            lblType.Text = user.Type;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            userdao.approveUser(user.ID);
            ((PageEmployee)(Login.mainwindow.userControl)).populateEmployee();
            ((PageEmployee)(Login.mainwindow.userControl)).populateIsNotApproveUser();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            userdao.deleteUser(user.ID);
            ((PageEmployee)(Login.mainwindow.userControl)).populateIsNotApproveUser();
        }
    }

}
