using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8
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
            if (Nb == 11)
            {
                Nb = 0;
            }

            button1.Text = Nb.ToString();
        }
    }
}
