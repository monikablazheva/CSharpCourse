using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if(comboBox1.Text == "Маргарита")
            {
                pictureBox1.Image = Image.FromFile("Margarita.jpeg");
            }
            if (comboBox1.Text == "4 сирена")
            {
                pictureBox1.Image = Image.FromFile("ChetSir.jpg");
            }
            if (comboBox1.Text == "Прошуто")
            {
                pictureBox1.Image = Image.FromFile("Proshuto.jpg");
            }
            if (comboBox1.Text == "Калцоне")
            {
                pictureBox1.Image = Image.FromFile("Kalcone.jpg");
            }
            if (comboBox1.Text == "Вегетариана")
            {
                pictureBox1.Image = Image.FromFile("Vegetariana.jpg");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
