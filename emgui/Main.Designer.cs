
namespace emgui
{
    partial class Main
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
            this.tpKlienci = new System.Windows.Forms.TabPage();
            this.dgvKlienci = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKlienciAdd = new System.Windows.Forms.Button();
            this.btnKlienciDel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbKlienciSearch = new System.Windows.Forms.ComboBox();
            this.tbKlienciSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKlienciUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tpSklepy = new System.Windows.Forms.TabPage();
            this.dgvShopList = new System.Windows.Forms.DataGridView();
            this.btnAddShop = new System.Windows.Forms.Button();
            this.btnDelShop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSklepySearch = new System.Windows.Forms.TextBox();
            this.cbSklepySearch = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tpProdukty = new System.Windows.Forms.TabPage();
            this.dgvProdukty = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSearchData = new System.Windows.Forms.ComboBox();
            this.txtboxSearchData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tpKlienci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlienci)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tpSklepy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpProdukty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpKlienci
            // 
            this.tpKlienci.Controls.Add(this.button2);
            this.tpKlienci.Controls.Add(this.btnKlienciUpdate);
            this.tpKlienci.Controls.Add(this.groupBox3);
            this.tpKlienci.Controls.Add(this.btnKlienciDel);
            this.tpKlienci.Controls.Add(this.btnKlienciAdd);
            this.tpKlienci.Controls.Add(this.label6);
            this.tpKlienci.Controls.Add(this.dgvKlienci);
            this.tpKlienci.Location = new System.Drawing.Point(4, 22);
            this.tpKlienci.Name = "tpKlienci";
            this.tpKlienci.Padding = new System.Windows.Forms.Padding(3);
            this.tpKlienci.Size = new System.Drawing.Size(791, 428);
            this.tpKlienci.TabIndex = 6;
            this.tpKlienci.Text = "Klienci";
            this.tpKlienci.UseVisualStyleBackColor = true;
            // 
            // dgvKlienci
            // 
            this.dgvKlienci.AllowUserToAddRows = false;
            this.dgvKlienci.AllowUserToDeleteRows = false;
            this.dgvKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlienci.Location = new System.Drawing.Point(52, 29);
            this.dgvKlienci.Name = "dgvKlienci";
            this.dgvKlienci.ReadOnly = true;
            this.dgvKlienci.Size = new System.Drawing.Size(671, 145);
            this.dgvKlienci.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lista klientów:";
            // 
            // btnKlienciAdd
            // 
            this.btnKlienciAdd.Location = new System.Drawing.Point(52, 203);
            this.btnKlienciAdd.Name = "btnKlienciAdd";
            this.btnKlienciAdd.Size = new System.Drawing.Size(133, 23);
            this.btnKlienciAdd.TabIndex = 2;
            this.btnKlienciAdd.Text = "Dodaj klienta";
            this.btnKlienciAdd.UseVisualStyleBackColor = true;
            this.btnKlienciAdd.Click += new System.EventHandler(this.btnKlienciAdd_Click);
            // 
            // btnKlienciDel
            // 
            this.btnKlienciDel.Location = new System.Drawing.Point(211, 203);
            this.btnKlienciDel.Name = "btnKlienciDel";
            this.btnKlienciDel.Size = new System.Drawing.Size(133, 23);
            this.btnKlienciDel.TabIndex = 3;
            this.btnKlienciDel.Text = "Usuń klienta";
            this.btnKlienciDel.UseVisualStyleBackColor = true;
            this.btnKlienciDel.Click += new System.EventHandler(this.btnKlienciDel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbKlienciSearch);
            this.groupBox3.Controls.Add(this.cbKlienciSearch);
            this.groupBox3.Location = new System.Drawing.Point(52, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wyszukiwanie klienta:";
            // 
            // cbKlienciSearch
            // 
            this.cbKlienciSearch.FormattingEnabled = true;
            this.cbKlienciSearch.Items.AddRange(new object[] {
            "Name",
            "Surrname",
            "CompanyName",
            "MobileNo",
            "FaxNo"});
            this.cbKlienciSearch.Location = new System.Drawing.Point(6, 54);
            this.cbKlienciSearch.Name = "cbKlienciSearch";
            this.cbKlienciSearch.Size = new System.Drawing.Size(161, 21);
            this.cbKlienciSearch.TabIndex = 0;
            // 
            // tbKlienciSearch
            // 
            this.tbKlienciSearch.Location = new System.Drawing.Point(239, 54);
            this.tbKlienciSearch.Name = "tbKlienciSearch";
            this.tbKlienciSearch.Size = new System.Drawing.Size(215, 20);
            this.tbKlienciSearch.TabIndex = 1;
            this.tbKlienciSearch.TextChanged += new System.EventHandler(this.tbKlienciSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Wyszukaj po:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wprowadź dane do wyszukania:";
            // 
            // btnKlienciUpdate
            // 
            this.btnKlienciUpdate.Location = new System.Drawing.Point(373, 203);
            this.btnKlienciUpdate.Name = "btnKlienciUpdate";
            this.btnKlienciUpdate.Size = new System.Drawing.Size(133, 23);
            this.btnKlienciUpdate.TabIndex = 5;
            this.btnKlienciUpdate.Text = "Aktualizuj dane";
            this.btnKlienciUpdate.UseVisualStyleBackColor = true;
            this.btnKlienciUpdate.Click += new System.EventHandler(this.btnKlienciUpdate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tpSklepy
            // 
            this.tpSklepy.Controls.Add(this.label7);
            this.tpSklepy.Controls.Add(this.button1);
            this.tpSklepy.Controls.Add(this.groupBox1);
            this.tpSklepy.Controls.Add(this.btnDelShop);
            this.tpSklepy.Controls.Add(this.btnAddShop);
            this.tpSklepy.Controls.Add(this.dgvShopList);
            this.tpSklepy.Location = new System.Drawing.Point(4, 22);
            this.tpSklepy.Name = "tpSklepy";
            this.tpSklepy.Padding = new System.Windows.Forms.Padding(3);
            this.tpSklepy.Size = new System.Drawing.Size(791, 428);
            this.tpSklepy.TabIndex = 1;
            this.tpSklepy.Text = "Sklepy";
            this.tpSklepy.UseVisualStyleBackColor = true;
            // 
            // dgvShopList
            // 
            this.dgvShopList.AllowUserToAddRows = false;
            this.dgvShopList.AllowUserToDeleteRows = false;
            this.dgvShopList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShopList.Location = new System.Drawing.Point(57, 41);
            this.dgvShopList.Name = "dgvShopList";
            this.dgvShopList.ReadOnly = true;
            this.dgvShopList.Size = new System.Drawing.Size(665, 153);
            this.dgvShopList.TabIndex = 1;
            // 
            // btnAddShop
            // 
            this.btnAddShop.Location = new System.Drawing.Point(57, 228);
            this.btnAddShop.Name = "btnAddShop";
            this.btnAddShop.Size = new System.Drawing.Size(122, 23);
            this.btnAddShop.TabIndex = 2;
            this.btnAddShop.Text = "Dodaj nowy sklep";
            this.btnAddShop.UseVisualStyleBackColor = true;
            this.btnAddShop.Click += new System.EventHandler(this.btnAddShop_Click);
            // 
            // btnDelShop
            // 
            this.btnDelShop.Location = new System.Drawing.Point(57, 287);
            this.btnDelShop.Name = "btnDelShop";
            this.btnDelShop.Size = new System.Drawing.Size(122, 23);
            this.btnDelShop.TabIndex = 3;
            this.btnDelShop.Text = "Usuń sklep";
            this.btnDelShop.UseVisualStyleBackColor = true;
            this.btnDelShop.Click += new System.EventHandler(this.btnDelShop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbSklepySearch);
            this.groupBox1.Controls.Add(this.tbSklepySearch);
            this.groupBox1.Location = new System.Drawing.Point(275, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 126);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyszukiwanie";
            // 
            // tbSklepySearch
            // 
            this.tbSklepySearch.Location = new System.Drawing.Point(239, 61);
            this.tbSklepySearch.Name = "tbSklepySearch";
            this.tbSklepySearch.Size = new System.Drawing.Size(179, 20);
            this.tbSklepySearch.TabIndex = 4;
            this.tbSklepySearch.TextChanged += new System.EventHandler(this.tbSklepySearch_TextChanged);
            // 
            // cbSklepySearch
            // 
            this.cbSklepySearch.FormattingEnabled = true;
            this.cbSklepySearch.Items.AddRange(new object[] {
            "Name",
            "storeAddress",
            "City",
            "Phone",
            "Other"});
            this.cbSklepySearch.Location = new System.Drawing.Point(9, 59);
            this.cbSklepySearch.Name = "cbSklepySearch";
            this.cbSklepySearch.Size = new System.Drawing.Size(121, 21);
            this.cbSklepySearch.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aktualizuj dane sklepu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpProdukty
            // 
            this.tpProdukty.Controls.Add(this.button3);
            this.tpProdukty.Controls.Add(this.btnUpdateProduct);
            this.tpProdukty.Controls.Add(this.groupBox2);
            this.tpProdukty.Controls.Add(this.btnRemoveProduct);
            this.tpProdukty.Controls.Add(this.btnAddProduct);
            this.tpProdukty.Controls.Add(this.label1);
            this.tpProdukty.Controls.Add(this.dgvProdukty);
            this.tpProdukty.Location = new System.Drawing.Point(4, 22);
            this.tpProdukty.Name = "tpProdukty";
            this.tpProdukty.Padding = new System.Windows.Forms.Padding(3);
            this.tpProdukty.Size = new System.Drawing.Size(791, 428);
            this.tpProdukty.TabIndex = 0;
            this.tpProdukty.Text = "Produkty";
            this.tpProdukty.UseVisualStyleBackColor = true;
            // 
            // dgvProdukty
            // 
            this.dgvProdukty.AllowUserToAddRows = false;
            this.dgvProdukty.AllowUserToDeleteRows = false;
            this.dgvProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukty.Location = new System.Drawing.Point(52, 29);
            this.dgvProdukty.Name = "dgvProdukty";
            this.dgvProdukty.ReadOnly = true;
            this.dgvProdukty.Size = new System.Drawing.Size(671, 145);
            this.dgvProdukty.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista produktów:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(52, 203);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(133, 23);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Dodaj produkt";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(211, 203);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(133, 23);
            this.btnRemoveProduct.TabIndex = 3;
            this.btnRemoveProduct.Text = "Usuń produkt";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtboxSearchData);
            this.groupBox2.Controls.Add(this.cbSearchData);
            this.groupBox2.Location = new System.Drawing.Point(52, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyszukiwanie produktu:";
            // 
            // cbSearchData
            // 
            this.cbSearchData.FormattingEnabled = true;
            this.cbSearchData.Items.AddRange(new object[] {
            "Name",
            "ProductName"});
            this.cbSearchData.Location = new System.Drawing.Point(6, 54);
            this.cbSearchData.Name = "cbSearchData";
            this.cbSearchData.Size = new System.Drawing.Size(161, 21);
            this.cbSearchData.TabIndex = 0;
            // 
            // txtboxSearchData
            // 
            this.txtboxSearchData.Location = new System.Drawing.Point(239, 54);
            this.txtboxSearchData.Name = "txtboxSearchData";
            this.txtboxSearchData.Size = new System.Drawing.Size(215, 20);
            this.txtboxSearchData.TabIndex = 1;
            this.txtboxSearchData.TextChanged += new System.EventHandler(this.txtboxSearchData_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wyszukaj po:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wprowadź dane do wyszukania:";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(373, 203);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(133, 23);
            this.btnUpdateProduct.TabIndex = 5;
            this.btnUpdateProduct.Text = "Aktualizuj dane";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(648, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpProdukty);
            this.tabControl1.Controls.Add(this.tpSklepy);
            this.tabControl1.Controls.Add(this.tpKlienci);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 454);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lista sklepów:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Wprowadź dane do wyszukania:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Wyszukaj po:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tpKlienci.ResumeLayout(false);
            this.tpKlienci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlienci)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpSklepy.ResumeLayout(false);
            this.tpSklepy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpProdukty.ResumeLayout(false);
            this.tpProdukty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpKlienci;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnKlienciUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKlienciSearch;
        private System.Windows.Forms.ComboBox cbKlienciSearch;
        private System.Windows.Forms.Button btnKlienciDel;
        private System.Windows.Forms.Button btnKlienciAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvKlienci;
        private System.Windows.Forms.TabPage tpSklepy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSklepySearch;
        private System.Windows.Forms.TextBox tbSklepySearch;
        private System.Windows.Forms.Button btnDelShop;
        private System.Windows.Forms.Button btnAddShop;
        private System.Windows.Forms.DataGridView dgvShopList;
        private System.Windows.Forms.TabPage tpProdukty;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxSearchData;
        private System.Windows.Forms.ComboBox cbSearchData;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProdukty;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}