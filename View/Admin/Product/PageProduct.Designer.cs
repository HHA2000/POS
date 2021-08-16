
namespace POS
{
    partial class PageProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPanelAddProduct = new System.Windows.Forms.Button();
            this.flowLayoutPanelCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPanelAddCategory = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelProduct
            // 
            this.flowLayoutPanelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelProduct.AutoScroll = true;
            this.flowLayoutPanelProduct.AutoScrollMinSize = new System.Drawing.Size(0, 10);
            this.flowLayoutPanelProduct.Location = new System.Drawing.Point(3, 183);
            this.flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
            this.flowLayoutPanelProduct.Size = new System.Drawing.Size(1037, 571);
            this.flowLayoutPanelProduct.TabIndex = 3;
            // 
            // btnPanelAddProduct
            // 
            this.btnPanelAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPanelAddProduct.FlatAppearance.BorderSize = 0;
            this.btnPanelAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelAddProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPanelAddProduct.Location = new System.Drawing.Point(9, 145);
            this.btnPanelAddProduct.Name = "btnPanelAddProduct";
            this.btnPanelAddProduct.Size = new System.Drawing.Size(37, 32);
            this.btnPanelAddProduct.TabIndex = 1;
            this.btnPanelAddProduct.Text = "+";
            this.btnPanelAddProduct.UseVisualStyleBackColor = false;
            this.btnPanelAddProduct.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // flowLayoutPanelCategory
            // 
            this.flowLayoutPanelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelCategory.AutoScroll = true;
            this.flowLayoutPanelCategory.Location = new System.Drawing.Point(3, 44);
            this.flowLayoutPanelCategory.Name = "flowLayoutPanelCategory";
            this.flowLayoutPanelCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelCategory.Size = new System.Drawing.Size(1037, 64);
            this.flowLayoutPanelCategory.TabIndex = 4;
            this.flowLayoutPanelCategory.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product";
            // 
            // btnPanelAddCategory
            // 
            this.btnPanelAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPanelAddCategory.FlatAppearance.BorderSize = 0;
            this.btnPanelAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelAddCategory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPanelAddCategory.Location = new System.Drawing.Point(9, 6);
            this.btnPanelAddCategory.Name = "btnPanelAddCategory";
            this.btnPanelAddCategory.Size = new System.Drawing.Size(37, 32);
            this.btnPanelAddCategory.TabIndex = 1;
            this.btnPanelAddCategory.Text = "+";
            this.btnPanelAddCategory.UseVisualStyleBackColor = false;
            this.btnPanelAddCategory.Click += new System.EventHandler(this.btnPanelAddCategory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefresh.Location = new System.Drawing.Point(117, 145);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 32);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelCategory);
            this.Controls.Add(this.btnPanelAddCategory);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPanelAddProduct);
            this.Controls.Add(this.flowLayoutPanelProduct);
            this.Name = "PageProduct";
            this.Size = new System.Drawing.Size(1043, 757);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProduct;
        private System.Windows.Forms.Button btnPanelAddProduct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPanelAddCategory;
        private System.Windows.Forms.Button btnRefresh;
    }
}
