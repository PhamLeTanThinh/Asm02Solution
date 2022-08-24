using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProduct : Form
    {
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;

        public Member Member { get; set; }
        public frmProduct()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show data form source to dgv
        /// </summary>
        /// <param name="_object"></param>
        private void ShowData(Object _object)
        {
            source = new BindingSource();
            source.DataSource = _object;
            ClearDataBinding();
            AddDataBinding(source);
            dgvProductList.DataSource = null;
            dgvProductList.DataSource = source;
            dgvProductList.Columns["Category"].Visible = false;
            dgvProductList.Columns["OrderDetails"].Visible = false;
        }

        private void ShowData(IEnumerable<Object> _object)
        {
            source = new BindingSource();
            source.DataSource = _object;
            ClearDataBinding();
            AddDataBinding(source);
            dgvProductList.DataSource = null;
            dgvProductList.DataSource = source;
            dgvProductList.Columns["Category"].Visible = false;
            dgvProductList.Columns["OrderDetails"].Visible = false;
        }


        /// <summary>
        /// Clear and Add data
        /// </summary>
        private void ClearDataBinding()
        {
            txtProductId.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtWeight.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtUnitsInStock.DataBindings.Clear();
            cboxCategoryId.DataBindings.Clear();
        }

        private void AddDataBinding(BindingSource bindingSource)
        {
            txtProductId.DataBindings.Add("Text", bindingSource, "ProductId");
            txtProductName.DataBindings.Add("Text", bindingSource, "ProductName");
            txtWeight.DataBindings.Add("Text", bindingSource, "Weight");
            txtUnitPrice.DataBindings.Add("Text", bindingSource, "UnitPrice");
            txtUnitsInStock.DataBindings.Add("Text", bindingSource, "UnitsInStock");
            cboxCategoryId.DataBindings.Add("Text", bindingSource, "CategoryId");
        }

        /// <summary>
        /// Load data
        /// </summary>
        public void LoadCategoryList()
        {
            try
            {
                var catList = productRepository.GetCategories();
                cboxCategoryId.DataSource = catList;
                cboxCategoryId.ValueMember = "CategoryId";
                cboxCategoryId.DisplayMember = "CategoryName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }
        }

        public void LoadProductList()
        {
            try
            {
                var ProductList = productRepository.GetProducts();
                ShowData(ProductList);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Loading ProductList");
            }
        }

        private Product GetProduct()
        {
            Product product = null;
            try
            {
                product = new Product
                {
                    ProductId = Int32.Parse(txtProductId.Text),
                    CategoryId = Int32.Parse(cboxCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = Int32.Parse(txtUnitsInStock.Text),
                };
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product");
            }
            return product;
        }


        //-----------------------------------------------------

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
            LoadProductList();
        }

        /// <summary>
        /// Search Product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e) //Search by Id, Name, Unit Price, Units In Stock
        {
            try
            {
                switch (cboxSearch.SelectedItem)
                {
                    case "Product Id":
                        {
                            var Product = productRepository.GetProductById(Int32.Parse(txtSearch.Text));
                            ShowData(Product);
                        }
                        break;
                    case "Product Name":
                        {
                            var Product = productRepository.GetProductByName(txtSearch.Text);
                            ShowData(Product);
                        }
                        break;
                    case "Unit Price":
                        {
                            var Product = productRepository.GetProductByUnitPrice(Int32.Parse(txtSearch.Text));
                            ShowData(Product);
                        }
                        break;
                    case "Units In Stock":
                        {
                            var Product = productRepository.GetProductByUnitsInStock(Int32.Parse(txtSearch.Text));
                            ShowData(Product);
                        }
                        break;
                }
                
            } 
            catch(System.FormatException ex)
            {
                MessageBox.Show("Input must be Integer", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        /// <summary>
        /// Update Product
        /// </summary>
        private void UpdateProduct()
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                ProductRepository = productRepository,
                Text = "Update Product",
                CreateOrUpdate = false,
                Product = GetProduct(),
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadCategoryList();
                LoadProductList();
            }
        }
        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateProduct();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        /// <summary>
        /// Create Product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CreateProduct()
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                ProductRepository = productRepository,
                Text = "Create Product",
                CreateOrUpdate = true,
                Product = GetProduct(),
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadCategoryList();
                LoadProductList();
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateProduct();
        }

        //Add to Cart
        public static List<Cart> CartList = new List<Cart>();
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Product product = GetProduct();
            foreach(Cart cartItem in CartList)
            {
                if (cartItem.Product.ProductId == product.ProductId)
                {
                    cartItem.quantity += 1;
                    return;
                }
            }
            CartList.Add(new Cart
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                quantity = 1,
                Product = product,
            });
            foreach(Cart cartItem in CartList)
            {
                Debug.WriteLine(cartItem.ProductId + " " + cartItem.ProductName);
            }
            
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            
            frmCart frmCart = new frmCart
            {
                CartList = CartList,
                Member = Member
            };
            if (frmCart.ShowDialog() == DialogResult.OK)
            {
                LoadCategoryList();
                LoadProductList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProduct();
                var confirmation = MessageBox.Show("Are you want to delete this product?", "Confirm Delete!!!", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    productRepository.DeleteProduct(product);
                    MessageBox.Show("Delete successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
