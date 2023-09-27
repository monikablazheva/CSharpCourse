using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DataLayer;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class HobbyForm : Form
    {
        private DBContext dbContext;
        private HobbyContext hobbyContext;
        private Hobby selectedHobby;
        private Field selectedField;
        private FieldContext fieldContext;
        public HobbyForm()
        {
            InitializeComponent();
            dbContext = new DBContext();
            hobbyContext = new HobbyContext(dbContext);
            fieldContext = new FieldContext(dbContext);
            LoadHobbies();
            BindComboBox();
        }

        private void LoadHobbies()
        {
            dataGridView1.DataSource = hobbyContext.ReadAll();
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

            selectedHobby = null;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedHobby != null)
            {
                hobbyContext.Delete(selectedHobby.Id);

                LoadHobbies();

                ClearData();
            }
            else
            {
                MessageBox.Show("You must select a hobby!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedHobby != null)
                {
                    MessageBox.Show("You can't create duplicated hobby!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = textBox1.Text;
                    Field field = comboBox1.SelectedItem as Field;
                    Hobby hobby = new Hobby(name);
                    hobby.Field = field;

                    hobbyContext.Create(hobby);
                    MessageBox.Show("Hobby was created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadHobbies();

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
            if (ValidateData())
            {
                Hobby hobby = new Hobby(selectedHobby.Id, textBox1.Text);

                hobbyContext.Update(hobby);

                MessageBox.Show("Hobby was updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadHobbies();

                ClearData();
            }
            else
            {
                MessageBox.Show("Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            selectedHobby = row.DataBoundItem as Hobby;

            textBox1.Text = selectedHobby.Name;
        }

        private void BindComboBox()
        {
            //List<Field> fields = fieldContext.ReadAll().ToList();
            //comboBox1.DataSource = fiel
            comboBox1.DataSource = fieldContext.ReadAll();

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            /*var fields = (from f in dbContext.Fields
                             select new { f.Name }).Distinct().ToList();
            comboBox1.DataSource = fields;
            comboBox1.DisplayMember = "Name";*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                selectedField = comboBox1.SelectedItem as Field;
            }
        }
    }
}
