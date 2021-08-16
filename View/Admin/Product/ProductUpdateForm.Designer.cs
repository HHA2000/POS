
namespace POS
{
    partial class ProductUpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(99, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(142, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(99, 53);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(142, 22);
            this.numericQuantity.TabIndex = 2;
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(99, 94);
            this.numericPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(142, 22);
            this.numericPrice.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(99, 134);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(142, 24);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(99, 188);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 30);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(173, 188);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProductUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 253);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductUpdateForm";
            this.Text = "ProductUpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
    }
}