using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class FieldForm : Form
    {
        private DBContext dbContext;
        private FieldContext fieldContext;
        private Field selectedField;
        public FieldForm()
        {
            InitializeComponent();
            dbContext = new DBContext();
            fieldContext = new FieldContext(dbContext);
            LoadFields();
        }
        private void LoadFields()
        {
            dataGridView1.DataSource = fieldContext.ReadAll();
        }

        private bool ValidateData()
        {
            if (textBox1.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            textBox1.Text = string.Empty;

            selectedField = null;
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedField != null)
                {
                    MessageBox.Show("You can't create duplicated field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = textBox1.Text;
                    Field field = new Field(name);

                    fieldContext.Create(field);
                    MessageBox.Show("Field was created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadFields();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(ValidateData())
            {
                Field field = new Field(selectedField.Id, textBox1.Text);
                fieldContext.Update(field);
                
                MessageBox.Show("Field was updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadFields();
                ClearData();
            }
            else
            {
                MessageBox.Show("Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedField != null)
            {
                fieldContext.Delete(selectedField.Id);
                LoadFields();
                ClearData();
            }
            else
            {
                MessageBox.Show("You must select a field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            selectedField = row.DataBoundItem as Field;
            textBox1.Text = selectedField.Name;
        }
    }
}
