
namespace POS
{
    partial class ProductItem
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductName.Location = new System.Drawing.Point(38, 3);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(45, 17);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Name";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductQuantity.Location = new System.Drawing.Point(61, 20);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblProductQuantity.TabIndex = 1;
            this.lblProductQuantity.Text = "Quantity";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductPrice.Location = new System.Drawing.Point(15, 20);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(40, 17);
            this.lblProductPrice.TabIndex = 1;
            this.lblProductPrice.Text = "Price";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(210, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.lblProductQuantity);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.lblProductPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 44);
            this.panel1.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(137, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(27, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "+";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(170, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(27, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(210, 244);
            this.Load += new System.EventHandler(this.ProductItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
