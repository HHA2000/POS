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
    public partial class PageEmployee : UserControl
    {
        UserDAO userdao = new UserDAO();
        public PageEmployee()
        {
            InitializeComponent();
            populateIsNotApproveUser();
            populateEmployee();
        }

        public void populateEmployee()
        {
            dataGridViewEmployee.AutoGenerateColumns = false;
            dataGridViewEmployee.DataSource = userdao.getEmployee();
        }

        public void populateIsNotApproveUser()
        {
            flowLayoutPanel.Controls.Clear();
            List<User> users = userdao.getNotApproveUsers();
            NotApproveUser useritem;
            foreach (User user in users)
            {
                useritem = new NotApproveUser(user);
                flowLayoutPanel.Controls.Add(useritem);
            }
        }
    }
}
