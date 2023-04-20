using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        int Nb = 0;
        int Nb2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nb += 1;
            if (Nb == 10)
            {
                this.BackColor = Color.Green;
            }

            button1.Text = Nb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nb2 += 1;
            if (Nb2 == 10)
            {
                this.Close();
            }

            button2.Text = Nb2.ToString();
        }
    }
}
