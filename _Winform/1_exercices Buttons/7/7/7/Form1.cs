using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        int Nb = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nb += 1;
            button1.Text = Nb.ToString();
            button2.Text = Nb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nb += 1;
            button2.Text = Nb.ToString();
            button1.Text = Nb.ToString();
        }
    }
}
