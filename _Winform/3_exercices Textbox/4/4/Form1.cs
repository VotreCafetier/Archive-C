using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        int nb = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nb = int.Parse(textBox1.Text);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (nb % 2 == 0)
            {
                label1.Text = "pair";
            }

            else
            {
                label1.Text = "impair";
            }
        }

    }
}
