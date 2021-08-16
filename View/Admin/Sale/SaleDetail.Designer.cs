
namespace POS
{
    partial class SaleDetail
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
            this.dataGridViewSaleDetial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleDetial)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSaleDetial
            // 
            this.dataGridViewSaleDetial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSaleDetial.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewSaleDetial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleDetial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSaleDetial.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSaleDetial.Name = "dataGridViewSaleDetial";
            this.dataGridViewSaleDetial.RowHeadersWidth = 51;
            this.dataGridViewSaleDetial.RowTemplate.Height = 24;
            this.dataGridViewSaleDetial.Size = new System.Drawing.Size(434, 358);
            this.dataGridViewSaleDetial.TabIndex = 0;
            // 
            // SaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(434, 358);
            this.Controls.Add(this.dataGridViewSaleDetial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaleDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleDetial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSaleDetial;
    }
}