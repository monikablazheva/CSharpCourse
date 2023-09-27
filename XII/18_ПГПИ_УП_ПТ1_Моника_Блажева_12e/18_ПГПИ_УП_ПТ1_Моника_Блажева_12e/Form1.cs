using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_ПГПИ_УП_ПТ1_Моника_Блажева_12e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region "ИНФОРМАЦИЯ В СИСТЕМАТА"
        private void button2_Click(object sender, EventArgs e)//ИМЕ
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)//ГОДИНА
        {
            comboBox1.Items.Add(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)//ЖАНР
        {
            comboBox2.Items.Add(textBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)//ИЗПЪЛНИТЕЛ
        {
            checkedListBox1.Items.Add(textBox4.Text);
        }
        #endregion

        #region "ДАННИ ЗА МУЗИКАТА"
        private void button1_Click(object sender, EventArgs e)//ИЗБОР ПЕСЕН
        {
            foreach (var i in listBox1.SelectedItems)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button6_Click(object sender, EventArgs e)//ИЗБОР ГОДИНА
        {
            listBox2.Items.Add(comboBox1.SelectedItem);
        }

        private void button7_Click(object sender, EventArgs e)//ИЗБОР ЖАНР
        {
            listBox2.Items.Add(comboBox2.SelectedItem);
        }

        private void button8_Click(object sender, EventArgs e)//ИЗБОР ИЗПЪЛНИТЕЛ
        {
            foreach(var i in checkedListBox1.CheckedItems)
            {
                listBox2.Items.Add(i);
            }
        }
        #endregion

        #region "ИЗБРАНА МУЗИКА"
        private void checkBox1_CheckedChanged(object sender, EventArgs e) //BOLD
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                if (checkBox2.CheckState == CheckState.Checked)
                {
                    listBox2.Font = new Font(listBox2.Font, FontStyle.Bold | FontStyle.Italic);
                }
                else
                {
                    listBox2.Font = new Font(listBox2.Font, FontStyle.Bold);
                }    
            }
            else
            {
                if (checkBox2.CheckState == CheckState.Checked)
                {
                    listBox2.Font = new Font(listBox2.Font, FontStyle.Regular | FontStyle.Italic);
                }
                else
                {
                    listBox2.Font = new Font(listBox2.Font, FontStyle.Regular);
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //ITALIC
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    listBox2.Font = new Font(listBox2.Font, FontStyle.Italic | FontStyle.Bold);
                }
                else
                {
                    listBox2.Font = new Font(listBox2.Font, FontStyle.Italic);
                }  
            }
            else
            {
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    listBox2.Font = new Font(listBox2.Font, FontStyle.Regular | FontStyle.Bold);
                }
                else
                {
                    listBox2.Font = new Font(listBox2.Font, FontStyle.Regular);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //ЧЕРВЕНО
        {
            listBox2.ForeColor = radioButton1.ForeColor;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //ОРАНЖЕВО
        {
            listBox2.ForeColor = radioButton2.ForeColor;
        }

        #endregion

        #region "ИЗЧИСТИ"
        private void button9_Click(object sender, EventArgs e) //ИЗЧИСТИ
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            comboBox1.ResetText();
            comboBox2.Items.Clear();
            comboBox2.ResetText();
            checkedListBox1.Items.Clear();

            listBox2.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        #endregion
    }
}
