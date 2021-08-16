
namespace POS
{
    partial class CategoryItem
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
            this.btnName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.Location = new System.Drawing.Point(0, 0);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(96, 33);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // CategoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnName);
            this.Name = "CategoryItem";
            this.Size = new System.Drawing.Size(96, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnName;
    }
}
