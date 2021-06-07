
namespace emgui
{
    partial class ClientAdd
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClientPhone = new System.Windows.Forms.TextBox();
            this.tbClientCompany = new System.Windows.Forms.TextBox();
            this.tbClientSurname = new System.Windows.Forms.TextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.tbClientFax = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Firma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nazwisko:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Imie:";
            // 
            // tbClientPhone
            // 
            this.tbClientPhone.Location = new System.Drawing.Point(63, 179);
            this.tbClientPhone.Name = "tbClientPhone";
            this.tbClientPhone.Size = new System.Drawing.Size(100, 20);
            this.tbClientPhone.TabIndex = 15;
            // 
            // tbClientCompany
            // 
            this.tbClientCompany.Location = new System.Drawing.Point(63, 138);
            this.tbClientCompany.Name = "tbClientCompany";
            this.tbClientCompany.Size = new System.Drawing.Size(100, 20);
            this.tbClientCompany.TabIndex = 14;
            // 
            // tbClientSurname
            // 
            this.tbClientSurname.Location = new System.Drawing.Point(63, 96);
            this.tbClientSurname.Name = "tbClientSurname";
            this.tbClientSurname.Size = new System.Drawing.Size(100, 20);
            this.tbClientSurname.TabIndex = 13;
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(63, 56);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 20);
            this.tbClientName.TabIndex = 12;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(28, 280);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(117, 23);
            this.btnAddClient.TabIndex = 11;
            this.btnAddClient.Text = "Dodaj klienta";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // tbClientFax
            // 
            this.tbClientFax.Location = new System.Drawing.Point(63, 218);
            this.tbClientFax.Name = "tbClientFax";
            this.tbClientFax.Size = new System.Drawing.Size(100, 20);
            this.tbClientFax.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbClientFax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbClientPhone);
            this.Controls.Add(this.tbClientCompany);
            this.Controls.Add(this.tbClientSurname);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.btnAddClient);
            this.Name = "ClientAdd";
            this.Text = "ClientAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClientPhone;
        private System.Windows.Forms.TextBox tbClientCompany;
        private System.Windows.Forms.TextBox tbClientSurname;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox tbClientFax;
        private System.Windows.Forms.Button button1;
    }
}