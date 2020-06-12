namespace emgui
{
    partial class NewEmployee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.txtEmployeeCity = new System.Windows.Forms.TextBox();
            this.txtEmployeePosition = new System.Windows.Forms.TextBox();
            this.txtEmployeeStatus = new System.Windows.Forms.TextBox();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.btnAddAnotherEmployee = new System.Windows.Forms.Button();
            this.btnAddFinish = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numSalary);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.txtEmployeeStatus);
            this.groupBox1.Controls.Add(this.txtEmployeePosition);
            this.groupBox1.Controls.Add(this.txtEmployeeCity);
            this.groupBox1.Controls.Add(this.txtEmployeeAddress);
            this.groupBox1.Controls.Add(this.txtEmployeeSurname);
            this.groupBox1.Controls.Add(this.txtEmployeeName);
            this.groupBox1.Controls.Add(this.txtEmployeeId);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Status";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(108, 30);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeId.TabIndex = 9;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(108, 62);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeName.TabIndex = 10;
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.Location = new System.Drawing.Point(108, 92);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeSurname.TabIndex = 11;
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(108, 125);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeAddress.TabIndex = 12;
            // 
            // txtEmployeeCity
            // 
            this.txtEmployeeCity.Location = new System.Drawing.Point(108, 157);
            this.txtEmployeeCity.Name = "txtEmployeeCity";
            this.txtEmployeeCity.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeCity.TabIndex = 13;
            // 
            // txtEmployeePosition
            // 
            this.txtEmployeePosition.Location = new System.Drawing.Point(108, 188);
            this.txtEmployeePosition.Name = "txtEmployeePosition";
            this.txtEmployeePosition.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeePosition.TabIndex = 14;
            // 
            // txtEmployeeStatus
            // 
            this.txtEmployeeStatus.Location = new System.Drawing.Point(108, 275);
            this.txtEmployeeStatus.Name = "txtEmployeeStatus";
            this.txtEmployeeStatus.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeStatus.TabIndex = 17;
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Location = new System.Drawing.Point(385, 278);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(160, 23);
            this.btnAddNewEmployee.TabIndex = 1;
            this.btnAddNewEmployee.Text = "Add new employee";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // btnAddAnotherEmployee
            // 
            this.btnAddAnotherEmployee.Location = new System.Drawing.Point(385, 346);
            this.btnAddAnotherEmployee.Name = "btnAddAnotherEmployee";
            this.btnAddAnotherEmployee.Size = new System.Drawing.Size(160, 23);
            this.btnAddAnotherEmployee.TabIndex = 2;
            this.btnAddAnotherEmployee.Text = "Add Another Employee";
            this.btnAddAnotherEmployee.UseVisualStyleBackColor = true;
            this.btnAddAnotherEmployee.Click += new System.EventHandler(this.btnAddAnotherEmployee_Click);
            // 
            // btnAddFinish
            // 
            this.btnAddFinish.Location = new System.Drawing.Point(21, 396);
            this.btnAddFinish.Name = "btnAddFinish";
            this.btnAddFinish.Size = new System.Drawing.Size(75, 23);
            this.btnAddFinish.TabIndex = 3;
            this.btnAddFinish.Text = "Finish";
            this.btnAddFinish.UseVisualStyleBackColor = true;
            this.btnAddFinish.Click += new System.EventHandler(this.btnAddFinish_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(108, 217);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(100, 20);
            this.dtpStartDate.TabIndex = 18;
            // 
            // numSalary
            // 
            this.numSalary.DecimalPlaces = 2;
            this.numSalary.Location = new System.Drawing.Point(108, 248);
            this.numSalary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numSalary.Size = new System.Drawing.Size(100, 20);
            this.numSalary.TabIndex = 19;
            this.numSalary.ThousandsSeparator = true;
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddFinish);
            this.Controls.Add(this.btnAddAnotherEmployee);
            this.Controls.Add(this.btnAddNewEmployee);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewEmployee";
            this.Text = "NewEmployee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmployeeStatus;
        private System.Windows.Forms.TextBox txtEmployeePosition;
        private System.Windows.Forms.TextBox txtEmployeeCity;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Button btnAddAnotherEmployee;
        private System.Windows.Forms.Button btnAddFinish;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.NumericUpDown numSalary;
    }
}