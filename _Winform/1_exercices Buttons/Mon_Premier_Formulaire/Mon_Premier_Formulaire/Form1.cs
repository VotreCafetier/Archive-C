using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mon_Premier_Formulaire
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Exit(object sender, EventArgs e)
        {
            if (Exit_Button.Text == "Quitter ?")
            {
                this.Close();
            }

            else
            {
                Exit_Button.Text = "Quitter ?";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Hide();
            }

            else
            {
                button1.Show();
            }
        }

        private void tpRep_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {

            }

            else if (!checkBox2.Checked)
            {

            }
        }
    }
}
