using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //change le text dans le label si cliquer dessus
            label1.Text = "OwO what's this";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //change le label du texte principal
            label2.BackColor = Color.LightGray;

            //Change le texte du label1
            label1.Text = "Vous avez bien clicke";
        }
    }
}
