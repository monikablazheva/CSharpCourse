using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MonkeysForm FForm = new MonkeysForm();
            FForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LionsForm LionsForm = new LionsForm();
            LionsForm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DolphinsForm DolphForm = new DolphinsForm();
            DolphForm.ShowDialog();
        }
    }
}
