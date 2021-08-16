
namespace POS
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnToregister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelRegister = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegisterName = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.comboRegisterType = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnTologin = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(128, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(137, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(128, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(137, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(128, 112);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(70, 28);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.Controls.Add(this.btnToregister);
            this.panelLogin.Controls.Add(this.btnCancel);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Location = new System.Drawing.Point(45, 51);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(311, 207);
            this.panelLogin.TabIndex = 3;
            // 
            // btnToregister
            // 
            this.btnToregister.Location = new System.Drawing.Point(128, 155);
            this.btnToregister.Name = "btnToregister";
            this.btnToregister.Size = new System.Drawing.Size(137, 28);
            this.btnToregister.TabIndex = 2;
            this.btnToregister.Text = "Register";
            this.btnToregister.UseVisualStyleBackColor = true;
            this.btnToregister.Click += new System.EventHandler(this.btnToregister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "POS";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.btnTologin);
            this.panelRegister.Controls.Add(this.btnRegister);
            this.panelRegister.Controls.Add(this.comboRegisterType);
            this.panelRegister.Controls.Add(this.txtRegisterPassword);
            this.panelRegister.Controls.Add(this.txtRegisterName);
            this.panelRegister.Controls.Add(this.label6);
            this.panelRegister.Controls.Add(this.label5);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Location = new System.Drawing.Point(45, 51);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(311, 207);
            this.panelRegister.TabIndex = 3;
            this.panelRegister.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Type";
            // 
            // txtRegisterName
            // 
            this.txtRegisterName.Location = new System.Drawing.Point(112, 24);
            this.txtRegisterName.Name = "txtRegisterName";
            this.txtRegisterName.Size = new System.Drawing.Size(158, 22);
            this.txtRegisterName.TabIndex = 1;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(112, 54);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '*';
            this.txtRegisterPassword.Size = new System.Drawing.Size(158, 22);
            this.txtRegisterPassword.TabIndex = 1;
            // 
            // comboRegisterType
            // 
            this.comboRegisterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRegisterType.FormattingEnabled = true;
            this.comboRegisterType.Location = new System.Drawing.Point(113, 86);
            this.comboRegisterType.Name = "comboRegisterType";
            this.comboRegisterType.Size = new System.Drawing.Size(157, 24);
            this.comboRegisterType.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(112, 116);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(158, 33);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnTologin
            // 
            this.btnTologin.Location = new System.Drawing.Point(112, 155);
            this.btnTologin.Name = "btnTologin";
            this.btnTologin.Size = new System.Drawing.Size(158, 33);
            this.btnTologin.TabIndex = 3;
            this.btnTologin.Text = "To LOGIN";
            this.btnTologin.UseVisualStyleBackColor = true;
            this.btnTologin.Click += new System.EventHandler(this.btnTologin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 288);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnToregister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.ComboBox comboRegisterType;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTologin;
        private System.Windows.Forms.Button btnRegister;
    }
}