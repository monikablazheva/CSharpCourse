using BusinessLayer;
using DataLayerV3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer6
{
    public partial class MainForm : Form
    {
        private CRUDContext<Customer, int> customerContext;
        private CRUDContext<Product, string> productContext;


        public MainForm()
        {
            InitializeComponent();

            OnlineShopDBContext context = new OnlineShopDBContext();

            customerContext = new CRUDContext<Customer, int>(context.Customers, context);
            productContext = new CRUDContext<Product, string>(context.Products, context);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm(customerContext, productContext);
            customersForm.ShowDialog();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm(productContext);
            productsForm.ShowDialog();
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented Exception", ":|", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
