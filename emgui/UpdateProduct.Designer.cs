namespace emgui
{
    partial class UpdateProduct
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
            this.dgvUpdate = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbModelNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpdate
            // 
            this.dgvUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdate.Location = new System.Drawing.Point(15, 12);
            this.dgvUpdate.Name = "dgvUpdate";
            this.dgvUpdate.Size = new System.Drawing.Size(776, 232);
            this.dgvUpdate.TabIndex = 0;
            this.dgvUpdate.SelectionChanged += new System.EventHandler(this.dgvUpdate_SelectionChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(359, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "To update employee data, select record in table, change it and then click Update " +
    "Data button.";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(40, 354);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(100, 20);
            this.tbProductName.TabIndex = 4;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(180, 354);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(100, 20);
            this.tbType.TabIndex = 5;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(322, 354);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 6;
            // 
            // tbModelNumber
            // 
            this.tbModelNumber.Location = new System.Drawing.Point(474, 354);
            this.tbModelNumber.Name = "tbModelNumber";
            this.tbModelNumber.Size = new System.Drawing.Size(100, 20);
            this.tbModelNumber.TabIndex = 7;
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbModelNumber);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvUpdate);
            this.Name = "UpdateProduct";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbModelNumber;
    }
}