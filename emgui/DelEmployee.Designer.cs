namespace emgui
{
    partial class DelEmployee
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
            this.txtDelEmployeeSurname = new System.Windows.Forms.TextBox();
            this.txtDelEmployeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelEmployee = new System.Windows.Forms.Button();
            this.btnDelFinish = new System.Windows.Forms.Button();
            this.btnDelAnotherEmployee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDelEmployeeSurname);
            this.groupBox1.Controls.Add(this.txtDelEmployeeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Del Employee";
            // 
            // txtDelEmployeeSurname
            // 
            this.txtDelEmployeeSurname.Location = new System.Drawing.Point(102, 66);
            this.txtDelEmployeeSurname.Name = "txtDelEmployeeSurname";
            this.txtDelEmployeeSurname.Size = new System.Drawing.Size(100, 20);
            this.txtDelEmployeeSurname.TabIndex = 7;
            // 
            // txtDelEmployeeName
            // 
            this.txtDelEmployeeName.Location = new System.Drawing.Point(102, 33);
            this.txtDelEmployeeName.Name = "txtDelEmployeeName";
            this.txtDelEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txtDelEmployeeName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // btnDelEmployee
            // 
            this.btnDelEmployee.Location = new System.Drawing.Point(424, 44);
            this.btnDelEmployee.Name = "btnDelEmployee";
            this.btnDelEmployee.Size = new System.Drawing.Size(145, 23);
            this.btnDelEmployee.TabIndex = 1;
            this.btnDelEmployee.Text = "Del Employee";
            this.btnDelEmployee.UseVisualStyleBackColor = true;
            this.btnDelEmployee.Click += new System.EventHandler(this.btnDelEmployee_Click);
            // 
            // btnDelFinish
            // 
            this.btnDelFinish.Location = new System.Drawing.Point(25, 373);
            this.btnDelFinish.Name = "btnDelFinish";
            this.btnDelFinish.Size = new System.Drawing.Size(75, 23);
            this.btnDelFinish.TabIndex = 2;
            this.btnDelFinish.Text = "Finish";
            this.btnDelFinish.UseVisualStyleBackColor = true;
            this.btnDelFinish.Click += new System.EventHandler(this.btnDelFinish_Click);
            // 
            // btnDelAnotherEmployee
            // 
            this.btnDelAnotherEmployee.Location = new System.Drawing.Point(424, 96);
            this.btnDelAnotherEmployee.Name = "btnDelAnotherEmployee";
            this.btnDelAnotherEmployee.Size = new System.Drawing.Size(145, 23);
            this.btnDelAnotherEmployee.TabIndex = 3;
            this.btnDelAnotherEmployee.Text = "Del Another Employee";
            this.btnDelAnotherEmployee.UseVisualStyleBackColor = true;
            this.btnDelAnotherEmployee.Click += new System.EventHandler(this.btnDelAnotherEmployee_Click);
            // 
            // DelEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelAnotherEmployee);
            this.Controls.Add(this.btnDelFinish);
            this.Controls.Add(this.btnDelEmployee);
            this.Controls.Add(this.groupBox1);
            this.Name = "DelEmployee";
            this.Text = "DelEmployee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDelEmployeeSurname;
        private System.Windows.Forms.TextBox txtDelEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelEmployee;
        private System.Windows.Forms.Button btnDelFinish;
        private System.Windows.Forms.Button btnDelAnotherEmployee;
    }
}