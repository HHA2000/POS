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
    public partial class Login : Form
    {
        public static MainWindow mainwindow;
        public static UserView userwindow;
        public Login()
        {
            InitializeComponent();
            populateRegisterType();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            auth();
        }

        private void auth()
        {
            if (inputValidate(panelLogin))
            {
                UserDAO userdao = new UserDAO();
                User user = new User() { Username = txtUsername.Text.Trim(), Password = txtPassword.Text.Trim() };
                bool check = userdao.checkUsernameAndPassword(user);
                if (check)
                {
                    user = userdao.getApproveUser(user);
                    switch (user.Type.ToLower())
                    {
                        case "admin":
                            mainwindow = new MainWindow();
                            userwindow = new UserView();
                            this.Hide();
                            mainwindow.ShowDialog();
                            this.Close();
                            break;

                        case "user":
                            userwindow = new UserView();
                            this.Hide();
                            userwindow.ShowDialog();
                            this.Close();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("wrong credentials");
                }
            }
        }

        private bool inputValidate(Panel panel)
        {
            int count = 0;
            foreach(Control control in panel.Controls)
            {
                if(control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        errorProvider.SetError(control, $"{control.Name} is empty");
                        count++;
                    }
                    else
                    {
                        errorProvider.SetError(control, string.Empty);
                    }
                }
            }

            if(count == 0)
            {
                return true;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void populateRegisterType()
        {
            string[] type = { "admin", "user" };
            comboRegisterType.DataSource = type;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (inputValidate(panelRegister))
            {
                UserDAO userdao = new UserDAO();
                if (!userdao.existUsername(txtRegisterName.Text.Trim()))
                {
                    User user = new User() {
                        Username = txtRegisterName.Text.Trim(),
                        Password = txtRegisterPassword.Text.Trim(),
                        Type = comboRegisterType.SelectedItem.ToString() };
                    userdao.addUser(user);
                }
                else
                {
                    MessageBox.Show("Username already exists");
                }
            }
        }

        private void btnTologin_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            panelLogin.Visible = true;
        }

        private void btnToregister_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelRegister.Visible = true;
        }
    }
}
