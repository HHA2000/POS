
namespace POS
{
    partial class PageSale
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
            this.panelDisplaySale = new System.Windows.Forms.Panel();
            this.btnSaleDetail = new System.Windows.Forms.Button();
            this.lblTodaySale = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDisplaySale.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDisplaySale
            // 
            this.panelDisplaySale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelDisplaySale.Controls.Add(this.btnSaleDetail);
            this.panelDisplaySale.Controls.Add(this.lblTodaySale);
            this.panelDisplaySale.Controls.Add(this.label1);
            this.panelDisplaySale.Location = new System.Drawing.Point(89, 73);
            this.panelDisplaySale.Name = "panelDisplaySale";
            this.panelDisplaySale.Size = new System.Drawing.Size(247, 143);
            this.panelDisplaySale.TabIndex = 0;
            // 
            // btnSaleDetail
            // 
            this.btnSaleDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSaleDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleDetail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSaleDetail.Location = new System.Drawing.Point(88, 95);
            this.btnSaleDetail.Name = "btnSaleDetail";
            this.btnSaleDetail.Size = new System.Drawing.Size(75, 36);
            this.btnSaleDetail.TabIndex = 2;
            this.btnSaleDetail.Text = "Detail";
            this.btnSaleDetail.UseVisualStyleBackColor = false;
            this.btnSaleDetail.Click += new System.EventHandler(this.btnSaleDetail_Click);
            // 
            // lblTodaySale
            // 
            this.lblTodaySale.AutoSize = true;
            this.lblTodaySale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySale.Location = new System.Drawing.Point(98, 59);
            this.lblTodaySale.Name = "lblTodaySale";
            this.lblTodaySale.Size = new System.Drawing.Size(53, 20);
            this.lblTodaySale.TabIndex = 1;
            this.lblTodaySale.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today Sale";
            // 
            // PageSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDisplaySale);
            this.Name = "PageSale";
            this.Size = new System.Drawing.Size(822, 584);
            this.panelDisplaySale.ResumeLayout(false);
            this.panelDisplaySale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplaySale;
        private System.Windows.Forms.Label lblTodaySale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaleDetail;
    }
}
