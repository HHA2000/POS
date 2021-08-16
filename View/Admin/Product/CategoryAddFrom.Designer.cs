
namespace POS
{
    partial class CategoryAddFrom
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
            this.textCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCategoryName
            // 
            this.textCategoryName.Location = new System.Drawing.Point(121, 34);
            this.textCategoryName.Name = "textCategoryName";
            this.textCategoryName.Size = new System.Drawing.Size(111, 22);
            this.textCategoryName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddCategory.Location = new System.Drawing.Point(121, 77);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(111, 27);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // CategoryAddFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 148);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCategoryName);
            this.Name = "CategoryAddFrom";
            this.Text = "CategoryAddFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCategory;
    }
}