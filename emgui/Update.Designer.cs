namespace emgui
{
    partial class Update
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
            this.btnUpdateShow = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // 
            // btnUpdateShow
            // 
            this.btnUpdateShow.Location = new System.Drawing.Point(46, 293);
            this.btnUpdateShow.Name = "btnUpdateShow";
            this.btnUpdateShow.Size = new System.Drawing.Size(109, 23);
            this.btnUpdateShow.TabIndex = 1;
            this.btnUpdateShow.Text = "Show Employee";
            this.btnUpdateShow.UseVisualStyleBackColor = true;
            this.btnUpdateShow.Click += new System.EventHandler(this.btnUpdateShow_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(197, 293);
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
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUpdateShow);
            this.Controls.Add(this.dgvUpdate);
            this.Name = "Update";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpdate;
        private System.Windows.Forms.Button btnUpdateShow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
    }
}