﻿namespace SaleWinApp
{
    partial class frmGeneralManagement
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
            this.btn_MemberManagement = new System.Windows.Forms.Button();
            this.btn_OrderManagement = new System.Windows.Forms.Button();
            this.btn_ProductManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_MemberManagement
            // 
            this.btn_MemberManagement.Location = new System.Drawing.Point(197, 79);
            this.btn_MemberManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_MemberManagement.Name = "btn_MemberManagement";
            this.btn_MemberManagement.Size = new System.Drawing.Size(162, 20);
            this.btn_MemberManagement.TabIndex = 0;
            this.btn_MemberManagement.Text = "Member Management";
            this.btn_MemberManagement.UseVisualStyleBackColor = true;
            this.btn_MemberManagement.Click += new System.EventHandler(this.btn_MemberManagement_Click);
            // 
            // btn_OrderManagement
            // 
            this.btn_OrderManagement.Location = new System.Drawing.Point(197, 163);
            this.btn_OrderManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_OrderManagement.Name = "btn_OrderManagement";
            this.btn_OrderManagement.Size = new System.Drawing.Size(162, 20);
            this.btn_OrderManagement.TabIndex = 1;
            this.btn_OrderManagement.Text = "Order Management";
            this.btn_OrderManagement.UseVisualStyleBackColor = true;
            this.btn_OrderManagement.Click += new System.EventHandler(this.btn_OrderManagement_Click);
            // 
            // btn_ProductManagement
            // 
            this.btn_ProductManagement.Location = new System.Drawing.Point(197, 122);
            this.btn_ProductManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ProductManagement.Name = "btn_ProductManagement";
            this.btn_ProductManagement.Size = new System.Drawing.Size(162, 20);
            this.btn_ProductManagement.TabIndex = 2;
            this.btn_ProductManagement.Text = "Product Management";
            this.btn_ProductManagement.UseVisualStyleBackColor = true;
            this.btn_ProductManagement.Click += new System.EventHandler(this.btn_ProductManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(139, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "General Management";
            // 
            // frmGeneralManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 206);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ProductManagement);
            this.Controls.Add(this.btn_OrderManagement);
            this.Controls.Add(this.btn_MemberManagement);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGeneralManagement";
            this.Text = "General Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGeneralManagement_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MemberManagement;
        private System.Windows.Forms.Button btn_OrderManagement;
        private System.Windows.Forms.Button btn_ProductManagement;
        private System.Windows.Forms.Label label1;
    }
}