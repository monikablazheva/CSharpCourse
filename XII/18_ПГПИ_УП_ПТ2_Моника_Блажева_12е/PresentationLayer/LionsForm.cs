using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace PresentationLayer
{
    
    public partial class LionsForm : Form
    {
        private AnimalContext<Lion> _context;
        private Lion selectedLion;
        //инициализация
        public LionsForm()
        {
            _context = new AnimalContext<Lion>(new AppDbContext());
            InitializeComponent();
            LoadLions();
        }
        //метод за зареждане на обекти лъв
        private void LoadLions()
        {
            lionsDataGridView.DataSource = _context.ReadAll();
        }
        // метод за валидция на данните
        private bool ValidateData()
        {
            if (MName.Text != string.Empty && MGender.Text != string.Empty && MAge.Value >= 0)
            {
                return true;
            }

            return false;
        }
        //метод за почистване на данните
        private void ClearData()
        {
            MName.Text = string.Empty;
            MGender.Text = string.Empty;
            MAge.Value = 0;

            selectedLion = null;
        }



        private void IName_TextChanged(object sender, EventArgs e)
        {

        }
        //метод, отговарящ за натискането на бутон Create - създава запис в бд с данни от потребителя
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedLion != null)
                {
                    MessageBox.Show("You can't create duplicated Lion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = MName.Text;
                    string gender = MGender.Text;
                    int age = Convert.ToInt32(MAge.Value);

                    Lion Lion = new Lion(name, age, gender);

                    _context.Create(Lion);
                    MessageBox.Show("Lion created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadLions();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("All fields required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //метод, отговарящ за натискането на бутон Update - редактира запис в бд с данни от потребителя
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                selectedLion.Name = MName.Text;
                selectedLion.Gender = MGender.Text;
                selectedLion.Age = Convert.ToInt32(MAge.Value);

                _context.Update(selectedLion);

                MessageBox.Show("Lion updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLions();

                ClearData();
            }
            else
            {
                MessageBox.Show("All fields required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //метод, отговарящ за натискането на бутон Exit - излиза от формата
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //метод, отговарящ за натискането на бутон Delete - изтрива запис в бд 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedLion != null)
            {
                _context.Delete(selectedLion.Id, typeof(Lion));

                LoadLions();

                ClearData();
            }
            else
            {
                MessageBox.Show("You must select Lion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //метод, който следи върху кой запис е кликнал потребителя  
        private void interestsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = lionsDataGridView.Rows[e.RowIndex];

            selectedLion = row.DataBoundItem as Lion;

            MName.Text = selectedLion.Name;
            MGender.Text = selectedLion.Gender;
            MAge.Value = selectedLion.Age;
        }
    }
}
