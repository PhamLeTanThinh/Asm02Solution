using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetail : Form
    {

        public frmProductDetail()
        {
            InitializeComponent();
        }

        public IProductRepository ProductRepository { get; set; }
        public bool CreateOrUpdate { get; set; } //True: Create, False: Update
        public Product Product { get; set; }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            cboCategoryId.SelectedIndex = 0;
            txtProductId.Enabled = CreateOrUpdate;
            
            if (!CreateOrUpdate == true)
            {
                txtProductId.Text = Product.ProductId.ToString();
                cboCategoryId.Text = Product.CategoryId.ToString();
                txtProductName.Text = Product.ProductName.ToString();
                txtWeight.Text = Product.Weight.ToString();
                txtUnitPrice.Text = Product.UnitPrice.ToString();
                txtUnitsInStock.Text = Product.UnitsInStock.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    ProductId = Int32.Parse(txtProductId.Text),
                    CategoryId = Int32.Parse(cboCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = Int32.Parse(txtUnitsInStock.Text),
                };

                if (product.CategoryId == null || product.ProductName.Trim().Equals("") || product.Weight.Trim().Equals("")
                        || product.UnitPrice == 0 || product.UnitsInStock == 0)
                {
                    throw new Exception("All Field Must Not Empty!");
                }

                if (CreateOrUpdate == true)
                {
                    ProductRepository.AddProduct(product);
                }
                else
                {
                    ProductRepository.UpdateProduct(product);
                }
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CreateOrUpdate == false ? "Create new Product" : "Update Product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
