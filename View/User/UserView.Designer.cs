
namespace POS
{
    partial class UserView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.flowLayoutPanelCart = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefreshProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnRefreshProduct);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanelProduct);
            this.panel1.Controls.Add(this.flowLayoutPanelCategory);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 673);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // flowLayoutPanelProduct
            // 
            this.flowLayoutPanelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelProduct.AutoScroll = true;
            this.flowLayoutPanelProduct.Location = new System.Drawing.Point(0, 144);
            this.flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
            this.flowLayoutPanelProduct.Size = new System.Drawing.Size(823, 529);
            this.flowLayoutPanelProduct.TabIndex = 0;
            // 
            // flowLayoutPanelCategory
            // 
            this.flowLayoutPanelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelCategory.Location = new System.Drawing.Point(0, 39);
            this.flowLayoutPanelCategory.Name = "flowLayoutPanelCategory";
            this.flowLayoutPanelCategory.Size = new System.Drawing.Size(823, 59);
            this.flowLayoutPanelCategory.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnSell);
            this.panel2.Controls.Add(this.flowLayoutPanelCart);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(826, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 673);
            this.panel2.TabIndex = 1;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(101, 13);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(88, 33);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // flowLayoutPanelCart
            // 
            this.flowLayoutPanelCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelCart.AutoScroll = true;
            this.flowLayoutPanelCart.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanelCart.Name = "flowLayoutPanelCart";
            this.flowLayoutPanelCart.Size = new System.Drawing.Size(209, 624);
            this.flowLayoutPanelCart.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cart";
            // 
            // btnRefreshProduct
            // 
            this.btnRefreshProduct.Location = new System.Drawing.Point(80, 113);
            this.btnRefreshProduct.Name = "btnRefreshProduct";
            this.btnRefreshProduct.Size = new System.Drawing.Size(71, 25);
            this.btnRefreshProduct.TabIndex = 2;
            this.btnRefreshProduct.Text = "Refresh";
            this.btnRefreshProduct.UseVisualStyleBackColor = true;
            this.btnRefreshProduct.Click += new System.EventHandler(this.btnRefreshProduct_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserView";
            this.Text = "UserView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSell;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProduct;
        private System.Windows.Forms.Button btnRefreshProduct;
    }
}