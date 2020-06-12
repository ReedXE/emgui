namespace emgui
{
    partial class Show
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtShowSurname = new System.Windows.Forms.TextBox();
            this.btnFinishUpdates = new System.Windows.Forms.Button();
            this.btnFindBySurname = new System.Windows.Forms.Button();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.btnShowAllEmployees = new System.Windows.Forms.Button();
            this.btnShowClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname:";
            // 
            // txtShowSurname
            // 
            this.txtShowSurname.Location = new System.Drawing.Point(138, 28);
            this.txtShowSurname.Name = "txtShowSurname";
            this.txtShowSurname.Size = new System.Drawing.Size(100, 20);
            this.txtShowSurname.TabIndex = 1;
            // 
            // btnFinishUpdates
            // 
            this.btnFinishUpdates.Location = new System.Drawing.Point(325, 349);
            this.btnFinishUpdates.Name = "btnFinishUpdates";
            this.btnFinishUpdates.Size = new System.Drawing.Size(98, 23);
            this.btnFinishUpdates.TabIndex = 3;
            this.btnFinishUpdates.Text = "Finish";
            this.btnFinishUpdates.UseVisualStyleBackColor = true;
            this.btnFinishUpdates.Click += new System.EventHandler(this.btnFinishUpdates_Click);
            // 
            // btnFindBySurname
            // 
            this.btnFindBySurname.Location = new System.Drawing.Point(365, 24);
            this.btnFindBySurname.Name = "btnFindBySurname";
            this.btnFindBySurname.Size = new System.Drawing.Size(144, 23);
            this.btnFindBySurname.TabIndex = 4;
            this.btnFindBySurname.Text = "Find Employee";
            this.btnFindBySurname.UseVisualStyleBackColor = true;
            this.btnFindBySurname.Click += new System.EventHandler(this.btnFindBySurname_Click);
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvEmployeeList.Location = new System.Drawing.Point(49, 103);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.ReadOnly = true;
            this.dgvEmployeeList.RowHeadersVisible = false;
            this.dgvEmployeeList.Size = new System.Drawing.Size(565, 150);
            this.dgvEmployeeList.TabIndex = 5;
            // 
            // btnShowAllEmployees
            // 
            this.btnShowAllEmployees.Location = new System.Drawing.Point(558, 24);
            this.btnShowAllEmployees.Name = "btnShowAllEmployees";
            this.btnShowAllEmployees.Size = new System.Drawing.Size(116, 23);
            this.btnShowAllEmployees.TabIndex = 6;
            this.btnShowAllEmployees.Text = "All employees";
            this.btnShowAllEmployees.UseVisualStyleBackColor = true;
            this.btnShowAllEmployees.Click += new System.EventHandler(this.btnShowAllEmployees_Click);
            // 
            // btnShowClear
            // 
            this.btnShowClear.Location = new System.Drawing.Point(506, 349);
            this.btnShowClear.Name = "btnShowClear";
            this.btnShowClear.Size = new System.Drawing.Size(75, 23);
            this.btnShowClear.TabIndex = 7;
            this.btnShowClear.Text = "Clear";
            this.btnShowClear.UseVisualStyleBackColor = true;
            this.btnShowClear.Click += new System.EventHandler(this.btnShowClear_Click);
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowClear);
            this.Controls.Add(this.btnShowAllEmployees);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.btnFindBySurname);
            this.Controls.Add(this.btnFinishUpdates);
            this.Controls.Add(this.txtShowSurname);
            this.Controls.Add(this.label1);
            this.Name = "Show";
            this.Text = "Show";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShowSurname;
        private System.Windows.Forms.Button btnFinishUpdates;
        private System.Windows.Forms.Button btnFindBySurname;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.Button btnShowAllEmployees;
        private System.Windows.Forms.Button btnShowClear;
    }
}