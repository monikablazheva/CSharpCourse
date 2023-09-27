using BusinessLayer;
using DataLayerV3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer6
{
    public partial class ProductsForm : Form
    {
        private CRUDContext<Product, string> productContext;
        private Product selectedProduct;
        private List<Product> products;
        int selectedRowIndex = -1;

        public ProductsForm(CRUDContext<Product, string> productContext)
        {
            InitializeComponent();

            this.productContext = productContext;

            LoadHeaderRow();
            LoadProducts();
        }

        #region Events

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    string barcode = barcodeTxtBox.Text;
                    string name = nameTxtBox.Text;
                    string brand = brandTxtBox.Text;
                    decimal price = priceBox.Value;
                    int quantity = Convert.ToInt32(quantityBox.Value);

                    Product product = new Product(barcode, name, brand, quantity, price);

                    productContext.Create(product);

                    MessageBox.Show("Product created successfully!", ":]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddProductRow(product);

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must fill all of the textboxes, dude/lass!", ":@", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Lazy software developer!", ":[", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData() && selectedProduct != null)
                {
                    selectedProduct.Name = nameTxtBox.Text;
                    selectedProduct.Barcode = barcodeTxtBox.Text;
                    selectedProduct.Brand = brandTxtBox.Text;
                    selectedProduct.Price = priceBox.Value;
                    selectedProduct.Quantity = (int)quantityBox.Value;

                    productContext.Update(selectedProduct);

                    MessageBox.Show("Product updated successfully!", ":]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateProductRow();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must fill all of the textboxes, dude/lass!", ":@", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error: Lazy software developer!", ":[", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProduct != null)
                {
                    productContext.Delete(selectedProduct.Barcode);

                    MessageBox.Show("Product deleted successfully!", ":]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DeleteProductRow();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must select product!!!!!", ">:@", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ":|", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string barcode = productsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string name = productsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string brand = productsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                decimal price = Convert.ToDecimal(productsDataGridView.Rows[e.RowIndex].Cells[3].Value);
                int quantity = Convert.ToInt32(productsDataGridView.Rows[e.RowIndex].Cells[4].Value);

                selectedProduct = products.First(p => p.Barcode == barcode);

                barcodeTxtBox.Text = barcode;
                nameTxtBox.Text = name;
                brandTxtBox.Text = brand;
                priceBox.Value = price;
                quantityBox.Value = quantity;

                selectedRowIndex = e.RowIndex;

                barcodeTxtBox.Enabled = false;
            }
        }

        #endregion

        #region Helper Methods

        private void LoadHeaderRow()
        {
            productsDataGridView.Columns.Add("barcode", "Barcode");
            productsDataGridView.Columns.Add("name", "Name");
            productsDataGridView.Columns.Add("brand", "Brand");
            productsDataGridView.Columns.Add("price", "Price");
            productsDataGridView.Columns.Add("quantity", "Quantity");
            productsDataGridView.Columns.Add("customers", "Customers");
        }

        private void LoadProducts()
        {
            products = productContext.ReadAll().ToList();

            foreach (Product item in products)
            {
                DataGridViewRow row = (DataGridViewRow)productsDataGridView.Rows[0].Clone();
                
                row.Cells[0].Value = item.Barcode;
                row.Cells[1].Value = item.Name;
                row.Cells[2].Value = item.Brand;
                row.Cells[3].Value = item.Price;
                row.Cells[4].Value = item.Quantity;

                if (item.FavouriteForCustomers != null)
                {
                    row.Cells[5].Value = string.Join(", ", item.FavouriteForCustomers.Select(c => c.Name));
                }

                productsDataGridView.Rows.Add(row);
            }
        }

        private void AddProductRow(Product item)
        {
            DataGridViewRow row = (DataGridViewRow)productsDataGridView.Rows[0].Clone();

            row.Cells[0].Value = item.Barcode;
            row.Cells[1].Value = item.Name;
            row.Cells[2].Value = item.Brand;
            row.Cells[3].Value = item.Price;
            row.Cells[4].Value = item.Quantity;

            if (item.FavouriteForCustomers != null)
            {
                row.Cells[5].Value = string.Join(", ", item.FavouriteForCustomers);
            }

            productsDataGridView.Rows.Add(row);
        }

        private void UpdateProductRow()
        {
            productsDataGridView.Rows[selectedRowIndex].Cells[0].Value = selectedProduct.Barcode;
            productsDataGridView.Rows[selectedRowIndex].Cells[1].Value = selectedProduct.Name;
            productsDataGridView.Rows[selectedRowIndex].Cells[2].Value = selectedProduct.Brand;
            productsDataGridView.Rows[selectedRowIndex].Cells[3].Value = selectedProduct.Price;
            productsDataGridView.Rows[selectedRowIndex].Cells[4].Value = selectedProduct.Quantity;
        }

        private void DeleteProductRow()
        {
            productsDataGridView.Rows.RemoveAt(selectedRowIndex);
        }

        private bool ValidateData()
        {
            if (nameTxtBox.Text != string.Empty && barcodeTxtBox.Text != string.Empty && brandTxtBox.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            nameTxtBox.Text = string.Empty;
            barcodeTxtBox.Text = string.Empty;
            brandTxtBox.Text = string.Empty;
            quantityBox.Value = quantityBox.Minimum;
            priceBox.Value = priceBox.Minimum;

            selectedProduct = null;
            selectedRowIndex = -1;

            barcodeTxtBox.Enabled = true;
        }

        #endregion

    }
}
