
namespace POS
{
    partial class ProductAddForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelAdd = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(107, 49);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(133, 22);
            this.txtQuantity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(108, 85);
            this.txtPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 22);
            this.txtPrice.TabIndex = 2;
            // 
            // picProduct
            // 
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.InitialImage = null;
            this.picProduct.Location = new System.Drawing.Point(285, 14);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(168, 168);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 3;
            this.picProduct.TabStop = false;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddPhoto.Location = new System.Drawing.Point(106, 152);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(134, 30);
            this.btnAddPhoto.TabIndex = 4;
            this.btnAddPhoto.Text = "Browse";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(106, 120);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(134, 24);
            this.comboCategory.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Category";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(108, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Image";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.txtName);
            this.panelAdd.Controls.Add(this.btnCancel);
            this.panelAdd.Controls.Add(this.comboCategory);
            this.panelAdd.Controls.Add(this.btnAdd);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Controls.Add(this.picProduct);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.btnAddPhoto);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.txtPrice);
            this.panelAdd.Controls.Add(this.txtQuantity);
            this.panelAdd.Location = new System.Drawing.Point(12, 6);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(486, 238);
            this.panelAdd.TabIndex = 6;
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 252);
            this.ControlBox = false;
            this.Controls.Add(this.panelAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductAddForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panelAdd;
    }
}