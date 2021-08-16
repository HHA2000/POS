
namespace POS
{
    partial class CartItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(3, 27);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 17);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "label1";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(55, 22);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(60, 22);
            this.numericQuantity.TabIndex = 1;
            this.numericQuantity.ValueChanged += new System.EventHandler(this.numericQuantity_ValueChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemove.Location = new System.Drawing.Point(131, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 24);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(163, 61);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Button btnRemove;
    }
}
