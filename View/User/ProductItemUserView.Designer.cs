
namespace POS
{
    partial class ProductItemUserView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 180);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(196, 180);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.btnBuy);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 42);
            this.panel2.TabIndex = 1;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Green;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuy.Location = new System.Drawing.Point(89, 3);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(89, 34);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Add to Cart";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrice.Location = new System.Drawing.Point(20, 20);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(20, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // ProductItemUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductItemUserView";
            this.Size = new System.Drawing.Size(196, 222);
            this.Load += new System.EventHandler(this.ProductItemUserView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
