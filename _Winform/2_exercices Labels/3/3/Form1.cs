using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        int iN = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = iN.ToString();
            iN++;
            label1.Text = iN.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = iN.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = iN.ToString();
            iN -= 1;
            label1.Text = iN.ToString();
        }
    }
}
