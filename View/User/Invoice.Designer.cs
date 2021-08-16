
namespace POS
{
    partial class Invoice
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
            this.btnOK = new System.Windows.Forms.Button();
            this.dataGridViewTransaction = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(254, 318);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 33);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dataGridViewTransaction
            // 
            this.dataGridViewTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTransaction.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewTransaction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTransaction.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewTransaction.Name = "dataGridViewTransaction";
            this.dataGridViewTransaction.ReadOnly = true;
            this.dataGridViewTransaction.RowHeadersWidth = 51;
            this.dataGridViewTransaction.RowTemplate.Height = 24;
            this.dataGridViewTransaction.Size = new System.Drawing.Size(342, 219);
            this.dataGridViewTransaction.TabIndex = 1;
            this.dataGridViewTransaction.SelectionChanged += new System.EventHandler(this.dataGridViewTransaction_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductName";
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Quantity";
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(260, 276);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(56, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 363);
            this.ControlBox = false;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTransaction);
            this.Controls.Add(this.btnOK);
            this.Name = "Invoice";
            this.Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dataGridViewTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}