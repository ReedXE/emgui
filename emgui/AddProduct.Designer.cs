
namespace emgui
{
    partial class AddProduct
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
            this.tbAddProductId = new System.Windows.Forms.TextBox();
            this.tbAddProductName = new System.Windows.Forms.TextBox();
            this.tbAddProductType = new System.Windows.Forms.TextBox();
            this.tbAddProductPrice = new System.Windows.Forms.TextBox();
            this.tbAddProductModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnAddProductReset = new System.Windows.Forms.Button();
            this.dgvAddProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAddProductId
            // 
            this.tbAddProductId.Location = new System.Drawing.Point(58, 129);
            this.tbAddProductId.Name = "tbAddProductId";
            this.tbAddProductId.ReadOnly = true;
            this.tbAddProductId.Size = new System.Drawing.Size(100, 20);
            this.tbAddProductId.TabIndex = 0;
            // 
            // tbAddProductName
            // 
            this.tbAddProductName.Location = new System.Drawing.Point(56, 175);
            this.tbAddProductName.Name = "tbAddProductName";
            this.tbAddProductName.Size = new System.Drawing.Size(100, 20);
            this.tbAddProductName.TabIndex = 1;
            // 
            // tbAddProductType
            // 
            this.tbAddProductType.Location = new System.Drawing.Point(56, 226);
            this.tbAddProductType.Name = "tbAddProductType";
            this.tbAddProductType.Size = new System.Drawing.Size(100, 20);
            this.tbAddProductType.TabIndex = 2;
            // 
            // tbAddProductPrice
            // 
            this.tbAddProductPrice.Location = new System.Drawing.Point(59, 268);
            this.tbAddProductPrice.Name = "tbAddProductPrice";
            this.tbAddProductPrice.Size = new System.Drawing.Size(100, 20);
            this.tbAddProductPrice.TabIndex = 3;
            // 
            // tbAddProductModel
            // 
            this.tbAddProductModel.Location = new System.Drawing.Point(59, 320);
            this.tbAddProductModel.Name = "tbAddProductModel";
            this.tbAddProductModel.Size = new System.Drawing.Size(100, 20);
            this.tbAddProductModel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id sklepu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nazwa produktu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Typ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numer modelu:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(59, 358);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(88, 23);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Dodaj produkt";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnAddProductReset
            // 
            this.btnAddProductReset.Location = new System.Drawing.Point(195, 358);
            this.btnAddProductReset.Name = "btnAddProductReset";
            this.btnAddProductReset.Size = new System.Drawing.Size(75, 23);
            this.btnAddProductReset.TabIndex = 11;
            this.btnAddProductReset.Text = "Reset";
            this.btnAddProductReset.UseVisualStyleBackColor = true;
            this.btnAddProductReset.Click += new System.EventHandler(this.btnAddProductReset_Click);
            // 
            // dgvAddProduct
            // 
            this.dgvAddProduct.AllowUserToAddRows = false;
            this.dgvAddProduct.AllowUserToDeleteRows = false;
            this.dgvAddProduct.AllowUserToResizeColumns = false;
            this.dgvAddProduct.AllowUserToResizeRows = false;
            this.dgvAddProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddProduct.Location = new System.Drawing.Point(30, 12);
            this.dgvAddProduct.Name = "dgvAddProduct";
            this.dgvAddProduct.ReadOnly = true;
            this.dgvAddProduct.Size = new System.Drawing.Size(672, 98);
            this.dgvAddProduct.TabIndex = 12;
            this.dgvAddProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddProduct_CellClick);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 420);
            this.Controls.Add(this.dgvAddProduct);
            this.Controls.Add(this.btnAddProductReset);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddProductModel);
            this.Controls.Add(this.tbAddProductPrice);
            this.Controls.Add(this.tbAddProductType);
            this.Controls.Add(this.tbAddProductName);
            this.Controls.Add(this.tbAddProductId);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddProductId;
        private System.Windows.Forms.TextBox tbAddProductName;
        private System.Windows.Forms.TextBox tbAddProductType;
        private System.Windows.Forms.TextBox tbAddProductPrice;
        private System.Windows.Forms.TextBox tbAddProductModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnAddProductReset;
        private System.Windows.Forms.DataGridView dgvAddProduct;
    }
}