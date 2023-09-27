using BusinessLayer;
using ServiceLayerV3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer5
{
    public partial class CustomersForm : Form
    {
        private DBManager<Customer, int> customerDBManager;
        private DBManager<Product, string> productsDBManager;
        private Customer selectedCustomer;
        private Product selectedProduct;

        public CustomersForm()
        {
            InitializeComponent();

            customerDBManager = new DBManager<Customer, int>(DBContextManager.CreateCustomerContext(DBContextManager.CreateContext()));
            productsDBManager = new DBManager<Product, string>(DBContextManager.CreateProductContext(DBContextManager.GetContext()));

            LoadCustomers();
            LoadProducts();

        }

        #region Events

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomer != null)
                {
                    MessageBox.Show("You can't create duplicated customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = nameTxtBox.Text;
                    string country = countryTxtBox.Text;
                    int age = Convert.ToInt32(ageBox.Value);

                    Customer customer = new Customer(name, country, age);

                    customerDBManager.Create(customer);
                    MessageBox.Show("Customer created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadCustomers();

                    ClearData();

                    nameTxtBox.Focus();
                }
                else
                {
                    MessageBox.Show("Name and Country are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (ValidateData() && selectedCustomer != null)
            {
                // I way:
                //Customer customer = new Customer(selectedCustomer.ID, nameTxtBox.Text, countryTxtBox.Text, Convert.ToInt32(ageBox.Value));

                //dBManager.Update(customer);

                // II way:
                selectedCustomer.Name = nameTxtBox.Text;
                selectedCustomer.Country = countryTxtBox.Text;

                customerDBManager.Update(selectedCustomer);

                MessageBox.Show("Customer updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCustomers();

                ClearData();
            }
            else
            {
                MessageBox.Show("Name and Country are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedCustomer != null)
            {
                customerDBManager.Delete(selectedCustomer.ID);

                LoadCustomers();

                ClearData();
            }
            else
            {
                MessageBox.Show("You must select customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addProductsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomer != null && selectedProduct != null)
                {
                    if (!((HashSet<Product>)selectedCustomer.FavouriteProducts).Contains(selectedProduct))
                    {
                        ((HashSet<Product>)selectedCustomer.FavouriteProducts).Add(selectedProduct);
                        
                        customerDBManager.Update(selectedCustomer);

                        MessageBox.Show(string.Format("{0} added successfully!", selectedProduct.Name),
                            ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This product is already added to favourites!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You must choose customer and product!", ":|", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void customersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = customersDataGridView.Rows[e.RowIndex];

                selectedCustomer = row.DataBoundItem as Customer;

                nameTxtBox.Text = selectedCustomer.Name;
                countryTxtBox.Text = selectedCustomer.Country;
                ageBox.Value = selectedCustomer.Age;
            }
            
        }

        private void productsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (productsListBox.SelectedValue != null)
            {
                selectedProduct = productsListBox.SelectedItem as Product;
            }


        }

        #endregion

        #region Helper Methods

        private void LoadCustomers()
        {
            customersDataGridView.DataSource = customerDBManager.ReadAll();
        }

        private void LoadProducts()
        {
            productsListBox.DataSource = productsDBManager.ReadAll();

            productsListBox.DisplayMember = "Name";
            productsListBox.ValueMember = "Barcode";
        }

        private bool ValidateData()
        {
            if (nameTxtBox.Text != string.Empty && countryTxtBox.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            nameTxtBox.Text = string.Empty;
            countryTxtBox.Text = string.Empty;
            ageBox.Value = ageBox.Minimum;

            selectedCustomer = null;
        }

        #endregion

        
    }
}
