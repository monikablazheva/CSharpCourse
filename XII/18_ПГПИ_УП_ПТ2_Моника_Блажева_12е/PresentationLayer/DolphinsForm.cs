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
    public partial class DolphinsForm : Form
    {
        private AnimalContext<Dolphin> _context;
        private Dolphin selectedDolphin;
        //инициализация
        public DolphinsForm()
        {
            _context = new AnimalContext<Dolphin>(new AppDbContext());
            InitializeComponent();
            LoadDolphin();
        }
        //метод за зареждане на обекти делфин
        private void LoadDolphin()
        {
            dolphinsDataGridView.DataSource = _context.ReadAll();
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

            selectedDolphin = null;
        }

        //метод, отговарящ за натискането на бутон Create - създава запис в бд с данни от потребителя
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedDolphin != null)
                {
                    MessageBox.Show("You can't create duplicated Dolphin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = MName.Text;
                    string gender = MGender.Text;
                    int age = Convert.ToInt32(MAge.Value);

                    Dolphin Dolphin = new Dolphin(name, age, gender);

                    _context.Create(Dolphin);
                    MessageBox.Show("Dolphin created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDolphin();

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
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                selectedDolphin.Name = MName.Text;
                selectedDolphin.Gender = MGender.Text;
                selectedDolphin.Age = Convert.ToInt32(MAge.Value);

                _context.Update(selectedDolphin);

                MessageBox.Show("Dolphin updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDolphin();

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
            if (selectedDolphin != null)
            {
                _context.Delete(selectedDolphin.Id, typeof(Dolphin));

                LoadDolphin();

                ClearData();
            }
            else
            {
                MessageBox.Show("You must select dolphin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //метод, който следи върху кой запис е кликнал потребителя  
        private void dolphinsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dolphinsDataGridView.Rows[e.RowIndex];

            selectedDolphin = row.DataBoundItem as Dolphin;

            MName.Text = selectedDolphin.Name;
            MGender.Text = selectedDolphin.Gender;
            MAge.Value = selectedDolphin.Age;
        }
    }
}
