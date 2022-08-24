namespace SalesWinApp.Order_Management
{
    partial class frmOrderCreate
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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            this.lblShippedDate = new System.Windows.Forms.Label();
            this.lblFreight = new System.Windows.Forms.Label();
            this.mtxtOrderId = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFreight = new System.Windows.Forms.MaskedTextBox();
            this.cboMember = new System.Windows.Forms.ComboBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.mtxtDiscount = new System.Windows.Forms.MaskedTextBox();
            this.mtxtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteOrderDetail = new System.Windows.Forms.Button();
            this.btnCancelOrderDetail = new System.Windows.Forms.Button();
            this.btnAddOrderDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(24, 55);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(50, 15);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Order Id";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(24, 83);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(52, 15);
            this.lblMember.TabIndex = 1;
            this.lblMember.Text = "Member";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(24, 115);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(64, 15);
            this.lblOrderDate.TabIndex = 3;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.AutoSize = true;
            this.lblRequiredDate.Location = new System.Drawing.Point(24, 144);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(81, 15);
            this.lblRequiredDate.TabIndex = 4;
            this.lblRequiredDate.Text = "Required Date";
            // 
            // lblShippedDate
            // 
            this.lblShippedDate.AutoSize = true;
            this.lblShippedDate.Location = new System.Drawing.Point(24, 173);
            this.lblShippedDate.Name = "lblShippedDate";
            this.lblShippedDate.Size = new System.Drawing.Size(77, 15);
            this.lblShippedDate.TabIndex = 5;
            this.lblShippedDate.Text = "Shipped Date";
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.Location = new System.Drawing.Point(24, 199);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(44, 15);
            this.lblFreight.TabIndex = 6;
            this.lblFreight.Text = "Freight";
            // 
            // mtxtOrderId
            // 
            this.mtxtOrderId.Location = new System.Drawing.Point(120, 52);
            this.mtxtOrderId.Mask = "000000";
            this.mtxtOrderId.Name = "mtxtOrderId";
            this.mtxtOrderId.Size = new System.Drawing.Size(117, 23);
            this.mtxtOrderId.TabIndex = 7;
            // 
            // mtxtFreight
            // 
            this.mtxtFreight.Location = new System.Drawing.Point(120, 196);
            this.mtxtFreight.Mask = "00000000";
            this.mtxtFreight.Name = "mtxtFreight";
            this.mtxtFreight.Size = new System.Drawing.Size(117, 23);
            this.mtxtFreight.TabIndex = 8;
            // 
            // cboMember
            // 
            this.cboMember.FormattingEnabled = true;
            this.cboMember.Location = new System.Drawing.Point(120, 80);
            this.cboMember.Name = "cboMember";
            this.cboMember.Size = new System.Drawing.Size(214, 23);
            this.cboMember.TabIndex = 9;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(120, 109);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(214, 23);
            this.dtpOrderDate.TabIndex = 10;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Location = new System.Drawing.Point(120, 138);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(214, 23);
            this.dtpRequiredDate.TabIndex = 11;
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Location = new System.Drawing.Point(120, 167);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(214, 23);
            this.dtpShippedDate.TabIndex = 12;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(398, 55);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(49, 15);
            this.lblProduct.TabIndex = 13;
            this.lblProduct.Text = "Product";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(398, 83);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lblUnitPrice.TabIndex = 14;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(398, 115);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(398, 146);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(75, 15);
            this.lblDiscount.TabIndex = 16;
            this.lblDiscount.Text = "Discount (%)";
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(479, 52);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(144, 23);
            this.cboProduct.TabIndex = 17;
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
            // 
            // mtxtDiscount
            // 
            this.mtxtDiscount.Location = new System.Drawing.Point(479, 141);
            this.mtxtDiscount.Mask = "0000";
            this.mtxtDiscount.Name = "mtxtDiscount";
            this.mtxtDiscount.Size = new System.Drawing.Size(144, 23);
            this.mtxtDiscount.TabIndex = 18;
            // 
            // mtxtQuantity
            // 
            this.mtxtQuantity.Location = new System.Drawing.Point(479, 109);
            this.mtxtQuantity.Mask = "000000";
            this.mtxtQuantity.Name = "mtxtQuantity";
            this.mtxtQuantity.Size = new System.Drawing.Size(144, 23);
            this.mtxtQuantity.TabIndex = 19;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(479, 80);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(144, 23);
            this.txtUnitPrice.TabIndex = 24;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(243, 9);
            this.label_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(176, 25);
            this.label_Title.TabIndex = 25;
            this.label_Title.Text = "Create a new Order";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.ProductId,
            this.UnitPrice,
            this.Quantity,
            this.Discount});
            this.dgvOrderDetails.Location = new System.Drawing.Point(12, 225);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowTemplate.Height = 25;
            this.dgvOrderDetails.Size = new System.Drawing.Size(523, 183);
            this.dgvOrderDetails.TabIndex = 26;
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "Order Id";
            this.OrderId.Name = "OrderId";
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.Name = "ProductId";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount (%)";
            this.Discount.Name = "Discount";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(211, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(361, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteOrderDetail);
            this.groupBox1.Controls.Add(this.btnCancelOrderDetail);
            this.groupBox1.Controls.Add(this.btnAddOrderDetail);
            this.groupBox1.Location = new System.Drawing.Point(541, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 153);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Detail";
            // 
            // btnDeleteOrderDetail
            // 
            this.btnDeleteOrderDetail.Location = new System.Drawing.Point(16, 119);
            this.btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            this.btnDeleteOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrderDetail.TabIndex = 30;
            this.btnDeleteOrderDetail.Text = "Delete";
            this.btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            this.btnDeleteOrderDetail.Click += new System.EventHandler(this.btnDeleteOrderDetail_Click);
            // 
            // btnCancelOrderDetail
            // 
            this.btnCancelOrderDetail.Location = new System.Drawing.Point(16, 51);
            this.btnCancelOrderDetail.Name = "btnCancelOrderDetail";
            this.btnCancelOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnCancelOrderDetail.TabIndex = 1;
            this.btnCancelOrderDetail.Text = "Cancel";
            this.btnCancelOrderDetail.UseVisualStyleBackColor = true;
            this.btnCancelOrderDetail.Click += new System.EventHandler(this.btnCancelOrderDetail_Click);
            // 
            // btnAddOrderDetail
            // 
            this.btnAddOrderDetail.Location = new System.Drawing.Point(16, 22);
            this.btnAddOrderDetail.Name = "btnAddOrderDetail";
            this.btnAddOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrderDetail.TabIndex = 0;
            this.btnAddOrderDetail.Text = "Add";
            this.btnAddOrderDetail.UseVisualStyleBackColor = true;
            this.btnAddOrderDetail.Click += new System.EventHandler(this.btnAddOrderDetail_Click);
            // 
            // frmOrderCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.mtxtQuantity);
            this.Controls.Add(this.mtxtDiscount);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.dtpShippedDate);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.cboMember);
            this.Controls.Add(this.mtxtFreight);
            this.Controls.Add(this.mtxtOrderId);
            this.Controls.Add(this.lblFreight);
            this.Controls.Add(this.lblShippedDate);
            this.Controls.Add(this.lblRequiredDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblOrderId);
            this.Name = "frmOrderCreate";
            this.Text = "Create Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOrderId;
        private Label lblMember;
        private Label lblOrderDate;
        private Label lblRequiredDate;
        private Label lblShippedDate;
        private Label lblFreight;
        private MaskedTextBox mtxtOrderId;
        private MaskedTextBox mtxtFreight;
        private ComboBox cboMember;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpShippedDate;
        private Label lblProduct;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblDiscount;
        private ComboBox cboProduct;
        private MaskedTextBox mtxtDiscount;
        private MaskedTextBox mtxtQuantity;
        private TextBox txtUnitPrice;
        private Label label_Title;
        private DataGridView dgvOrderDetails;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Discount;
        private Button btnSave;
        private Button btnCancel;
        private GroupBox groupBox1;
        private Button btnDeleteOrderDetail;
        private Button btnCancelOrderDetail;
        private Button btnAddOrderDetail;
    }
}