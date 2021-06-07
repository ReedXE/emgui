
namespace emgui
{
    partial class ClientUpdate
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
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.dgvClientUpdate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.Location = new System.Drawing.Point(12, 308);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(133, 23);
            this.btnClientUpdate.TabIndex = 13;
            this.btnClientUpdate.Text = "Aktualizuj";
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            this.btnClientUpdate.Click += new System.EventHandler(this.btnClientUpdate_Click);
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(529, 251);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(100, 20);
            this.tb5.TabIndex = 12;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(401, 251);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(100, 20);
            this.tb4.TabIndex = 11;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(272, 251);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 20);
            this.tb3.TabIndex = 10;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(142, 251);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 9;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 251);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 8;
            // 
            // dgvClientUpdate
            // 
            this.dgvClientUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientUpdate.Location = new System.Drawing.Point(12, 12);
            this.dgvClientUpdate.Name = "dgvClientUpdate";
            this.dgvClientUpdate.Size = new System.Drawing.Size(747, 171);
            this.dgvClientUpdate.TabIndex = 7;
            this.dgvClientUpdate.SelectionChanged += new System.EventHandler(this.dgvClientUpdate_SelectionChanged);
            // 
            // ClientUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClientUpdate);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.dgvClientUpdate);
            this.Name = "ClientUpdate";
            this.Text = "ClientUpdate";
            this.Load += new System.EventHandler(this.ClientUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientUpdate;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.DataGridView dgvClientUpdate;
    }
}