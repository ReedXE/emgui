
namespace emgui
{
    partial class DelProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDelProduct = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz produkt do usuniecia";
            // 
            // dgvDelProduct
            // 
            this.dgvDelProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelProduct.Location = new System.Drawing.Point(53, 61);
            this.dgvDelProduct.Name = "dgvDelProduct";
            this.dgvDelProduct.Size = new System.Drawing.Size(681, 156);
            this.dgvDelProduct.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DelProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDelProduct);
            this.Controls.Add(this.label2);
            this.Name = "DelProduct";
            this.Text = "DelProduct";
            this.Load += new System.EventHandler(this.DelProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDelProduct;
        private System.Windows.Forms.Button button1;
    }
}