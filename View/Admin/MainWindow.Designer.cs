
namespace POS
{
    partial class MainWindow
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUserView = new System.Windows.Forms.Button();
            this.PanelButton = new System.Windows.Forms.Panel();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.PanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnUserView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 58);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(104, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Behind";
            // 
            // btnUserView
            // 
            this.btnUserView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUserView.FlatAppearance.BorderSize = 0;
            this.btnUserView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserView.Location = new System.Drawing.Point(863, 9);
            this.btnUserView.Name = "btnUserView";
            this.btnUserView.Size = new System.Drawing.Size(94, 43);
            this.btnUserView.TabIndex = 0;
            this.btnUserView.Text = "UserView";
            this.btnUserView.UseVisualStyleBackColor = false;
            this.btnUserView.Click += new System.EventHandler(this.btnUserView_Click);
            // 
            // PanelButton
            // 
            this.PanelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelButton.Controls.Add(this.btnAnalysis);
            this.PanelButton.Controls.Add(this.btnSupplier);
            this.PanelButton.Controls.Add(this.btnReport);
            this.PanelButton.Controls.Add(this.btnEmployee);
            this.PanelButton.Controls.Add(this.btnProduct);
            this.PanelButton.Controls.Add(this.btnSale);
            this.PanelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelButton.Location = new System.Drawing.Point(0, 58);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(100, 584);
            this.PanelButton.TabIndex = 2;
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalysis.FlatAppearance.BorderSize = 0;
            this.btnAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalysis.Location = new System.Drawing.Point(3, 401);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(94, 43);
            this.btnAnalysis.TabIndex = 0;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Location = new System.Drawing.Point(3, 352);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(94, 43);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(3, 303);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(94, 43);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Location = new System.Drawing.Point(3, 254);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(94, 43);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Location = new System.Drawing.Point(3, 205);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(94, 43);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSale
            // 
            this.btnSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Location = new System.Drawing.Point(3, 156);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(94, 43);
            this.btnSale.TabIndex = 0;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(100, 58);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(869, 584);
            this.PanelMain.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 642);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelButton);
            this.Controls.Add(this.panel2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelButton;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button btnUserView;
    }
}