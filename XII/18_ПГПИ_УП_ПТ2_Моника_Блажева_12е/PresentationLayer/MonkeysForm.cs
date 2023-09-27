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
    public partial class MonkeysForm : Form
    {
        private AnimalContext<Monkey> _context;
        private Monkey selectedMonkey;
        //инициализация
        public MonkeysForm()
        {
            _context = new AnimalContext<Monkey>(new AppDbContext());
            InitializeComponent();
            LoadMonkey();
        }
        //метод за зареждане на обекти маймуна
        private void LoadMonkey()
        {
            monkeysDataGridView.DataSource = _context.ReadAll();
        }
        // метод за валидция на данните
        private bool ValidateData()
        {
            if (MName.Text != string.Empty && MGender.Text != string.Empty && MAge.Value >=0)
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

            selectedMonkey = null;
        }
        //метод, отговарящ за натискането на бутон Create - създава запис в бд с данни от потребителя
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (selectedMonkey != null)
                {
                    MessageBox.Show("You can't create duplicated Monkey!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = MName.Text;
                    string gender = MGender.Text;
                    int age =Convert.ToInt32(MAge.Value);

                    Monkey Monkey = new Monkey(name,age,gender);

                    _context.Create(Monkey);
                    MessageBox.Show("Monkey created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadMonkey();

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
                selectedMonkey.Name = MName.Text;
                selectedMonkey.Gender = MGender.Text;
                selectedMonkey.Age = Convert.ToInt32(MAge.Value);

                _context.Update(selectedMonkey);

                MessageBox.Show("Monkey updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadMonkey();

                ClearData();
            }
            else
            {
                MessageBox.Show("All fields required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //метод, отговарящ за натискането на бутон Exit - излиза от формата
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //метод, отговарящ за натискането на бутон Delete - изтрива запис в бд 
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedMonkey != null)
            {
                _context.Delete(selectedMonkey.Id, typeof(Monkey));

                LoadMonkey();

                ClearData();
            }
            else
            {
                MessageBox.Show("You must select monkey!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //метод, който следи върху кой запис е кликнал потребителя  
        private void fieldsDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = monkeysDataGridView.Rows[e.RowIndex];

            selectedMonkey = row.DataBoundItem as Monkey;

            MName.Text = selectedMonkey.Name;
            MGender.Text = selectedMonkey.Gender;
            MAge.Value = selectedMonkey.Age;
        }

        private void MName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
