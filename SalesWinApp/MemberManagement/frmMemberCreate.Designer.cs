namespace SaleWinApp
{
    partial class frmMemberCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tB_Member_Email = new System.Windows.Forms.TextBox();
            this.btn_Member_Cancel = new System.Windows.Forms.Button();
            this.btn_Member_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Member_Email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Member_Company = new System.Windows.Forms.Label();
            this.label_Member_City = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_Member_CompanyName = new System.Windows.Forms.TextBox();
            this.tB_Member_City = new System.Windows.Forms.TextBox();
            this.tB_Member_Country = new System.Windows.Forms.TextBox();
            this.tB_Member_Password = new System.Windows.Forms.TextBox();
            this.label_Member_Id = new System.Windows.Forms.Label();
            this.mTB_Member_Id = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tB_Member_Email
            // 
            this.tB_Member_Email.Location = new System.Drawing.Point(262, 78);
            this.tB_Member_Email.Margin = new System.Windows.Forms.Padding(2);
            this.tB_Member_Email.Name = "tB_Member_Email";
            this.tB_Member_Email.Size = new System.Drawing.Size(202, 23);
            this.tB_Member_Email.TabIndex = 0;
            // 
            // btn_Member_Cancel
            // 
            this.btn_Member_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Member_Cancel.Location = new System.Drawing.Point(168, 232);
            this.btn_Member_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Member_Cancel.Name = "btn_Member_Cancel";
            this.btn_Member_Cancel.Size = new System.Drawing.Size(78, 20);
            this.btn_Member_Cancel.TabIndex = 5;
            this.btn_Member_Cancel.Text = "Reset";
            this.btn_Member_Cancel.UseVisualStyleBackColor = true;
            this.btn_Member_Cancel.Click += new System.EventHandler(this.btn_Member_Cancel_Click);
            // 
            // btn_Member_Save
            // 
            this.btn_Member_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Member_Save.Location = new System.Drawing.Point(326, 232);
            this.btn_Member_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Member_Save.Name = "btn_Member_Save";
            this.btn_Member_Save.Size = new System.Drawing.Size(78, 20);
            this.btn_Member_Save.TabIndex = 6;
            this.btn_Member_Save.Text = "Save";
            this.btn_Member_Save.UseVisualStyleBackColor = true;
            this.btn_Member_Save.Click += new System.EventHandler(this.btn_Member_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(188, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add a new member";
            // 
            // label_Member_Email
            // 
            this.label_Member_Email.AutoSize = true;
            this.label_Member_Email.Location = new System.Drawing.Point(147, 80);
            this.label_Member_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Member_Email.Name = "label_Member_Email";
            this.label_Member_Email.Size = new System.Drawing.Size(87, 15);
            this.label_Member_Email.TabIndex = 8;
            this.label_Member_Email.Text = "Member Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Country:";
            // 
            // label_Member_Company
            // 
            this.label_Member_Company.AutoSize = true;
            this.label_Member_Company.Location = new System.Drawing.Point(145, 114);
            this.label_Member_Company.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Member_Company.Name = "label_Member_Company";
            this.label_Member_Company.Size = new System.Drawing.Size(97, 15);
            this.label_Member_Company.TabIndex = 10;
            this.label_Member_Company.Text = "Company Name:";
            // 
            // label_Member_City
            // 
            this.label_Member_City.AutoSize = true;
            this.label_Member_City.Location = new System.Drawing.Point(147, 143);
            this.label_Member_City.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Member_City.Name = "label_Member_City";
            this.label_Member_City.Size = new System.Drawing.Size(31, 15);
            this.label_Member_City.TabIndex = 11;
            this.label_Member_City.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password:";
            // 
            // tB_Member_CompanyName
            // 
            this.tB_Member_CompanyName.Location = new System.Drawing.Point(262, 110);
            this.tB_Member_CompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.tB_Member_CompanyName.Name = "tB_Member_CompanyName";
            this.tB_Member_CompanyName.Size = new System.Drawing.Size(202, 23);
            this.tB_Member_CompanyName.TabIndex = 13;
            // 
            // tB_Member_City
            // 
            this.tB_Member_City.Location = new System.Drawing.Point(262, 139);
            this.tB_Member_City.Margin = new System.Windows.Forms.Padding(2);
            this.tB_Member_City.Name = "tB_Member_City";
            this.tB_Member_City.Size = new System.Drawing.Size(202, 23);
            this.tB_Member_City.TabIndex = 14;
            // 
            // tB_Member_Country
            // 
            this.tB_Member_Country.Location = new System.Drawing.Point(262, 167);
            this.tB_Member_Country.Margin = new System.Windows.Forms.Padding(2);
            this.tB_Member_Country.Name = "tB_Member_Country";
            this.tB_Member_Country.Size = new System.Drawing.Size(202, 23);
            this.tB_Member_Country.TabIndex = 15;
            // 
            // tB_Member_Password
            // 
            this.tB_Member_Password.Location = new System.Drawing.Point(262, 198);
            this.tB_Member_Password.Margin = new System.Windows.Forms.Padding(2);
            this.tB_Member_Password.Name = "tB_Member_Password";
            this.tB_Member_Password.PasswordChar = '*';
            this.tB_Member_Password.Size = new System.Drawing.Size(202, 23);
            this.tB_Member_Password.TabIndex = 16;
            // 
            // label_Member_Id
            // 
            this.label_Member_Id.AutoSize = true;
            this.label_Member_Id.Location = new System.Drawing.Point(147, 52);
            this.label_Member_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Member_Id.Name = "label_Member_Id";
            this.label_Member_Id.Size = new System.Drawing.Size(68, 15);
            this.label_Member_Id.TabIndex = 18;
            this.label_Member_Id.Text = "Member Id:";
            // 
            // mTB_Member_Id
            // 
            this.mTB_Member_Id.Location = new System.Drawing.Point(262, 50);
            this.mTB_Member_Id.Margin = new System.Windows.Forms.Padding(2);
            this.mTB_Member_Id.Mask = "00000";
            this.mTB_Member_Id.Name = "mTB_Member_Id";
            this.mTB_Member_Id.Size = new System.Drawing.Size(202, 23);
            this.mTB_Member_Id.TabIndex = 19;
            this.mTB_Member_Id.ValidatingType = typeof(int);
            // 
            // frmMemberCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.mTB_Member_Id);
            this.Controls.Add(this.label_Member_Id);
            this.Controls.Add(this.tB_Member_Password);
            this.Controls.Add(this.tB_Member_Country);
            this.Controls.Add(this.tB_Member_City);
            this.Controls.Add(this.tB_Member_CompanyName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_Member_City);
            this.Controls.Add(this.label_Member_Company);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Member_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Member_Save);
            this.Controls.Add(this.btn_Member_Cancel);
            this.Controls.Add(this.tB_Member_Email);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMemberCreate";
            this.Text = "Add a new Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Member_Email;
        private System.Windows.Forms.Button btn_Member_Cancel;
        private System.Windows.Forms.Button btn_Member_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Member_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Member_Company;
        private System.Windows.Forms.Label label_Member_City;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_Member_CompanyName;
        private System.Windows.Forms.TextBox tB_Member_City;
        private System.Windows.Forms.TextBox tB_Member_Country;
        private System.Windows.Forms.TextBox tB_Member_Password;
        private System.Windows.Forms.Label label_Member_Id;
        private System.Windows.Forms.MaskedTextBox mTB_Member_Id;
    }
}